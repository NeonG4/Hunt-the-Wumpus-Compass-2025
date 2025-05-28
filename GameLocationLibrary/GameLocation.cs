using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveLibrary;
using PlayerLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameLocationLibrary
{
    public class GameLocation : IGameLocation
    {
        public List<Hazards> hazards = new List<Hazards>();
        public List<Hazards> allSpawnables = new List<Hazards>();
        Random random = new Random();
        int wumpusroom = 31;
        public int playerspawn = 31;

        //Method that returns a list of hazards/the room they are located in
        public GameLocation()
        {
            AddHazard("Pit");
            AddHazard("Pit");
            AddHazard("Bats");
            AddHazard("Bats");
            SpawnWumpus();
            SpawnPlayer();
        }
        //Adds a new hazard of a specified type
        
        public int EncounterBat(PlayerManager playerManager)
        {
            int hazardIndex = -1;
            for (int i = 0; i < hazards.Count; i++)
            {
                if (playerManager.CurrentRoom == hazards[i].room)
                {
                    hazardIndex = i;
                    i = hazards.Count();
                }
            }
            hazards.RemoveAt(hazardIndex);
            for (int j = 0; j < allSpawnables.Count; j++)
            {
                if (playerManager.CurrentRoom == allSpawnables[j].room)
                {
                    hazardIndex = j;
                    j = allSpawnables.Count();
                }
            }
            allSpawnables.RemoveAt(hazardIndex);
            AddHazard("Bats");
            return SpawnPlayer();
        }

        public void AddHazard(string hazard)
        {
            while (true)
            {
                int number = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                Hazards newHazard = new Hazards(hazard, number);
                bool tmp = true;
                //Cycles through the hazards list until the random room is a unique value
                for (int i = 0; i < hazards.Count; i++)
                {
                    if (hazards[i].room == number)
                    {
                        tmp = false;
                        i = hazards.Count();
                    }
                }
                // If the number generated is unique, add the hazard
                if (tmp)
                {
                    hazards.Add(newHazard);
                    allSpawnables.Add(newHazard);
                    return;
                }
            }
        }
        //Spawns the player into an empty room
        public int SpawnPlayer()
        {
            while (true)
            {
                int playerstart = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                bool tmp = true;
                //Cycles through the list of hazards/wumpus until the random room is a unique value
                for (int i = 0; i < allSpawnables.Count; i++)
                {
                    if (allSpawnables[i].room == playerstart)
                    {
                        tmp = false;
                        i = allSpawnables.Count();
                    }
                }
                // If the number generated is unique, return a valid room the player can spawn in
                if (tmp)
                {
                    playerspawn = playerstart;
                    return playerstart;
                }
            }

        }
        //Spawns the Wumpus into an room not containing the player
        public int SpawnWumpus()
        {
            while (true)
            {
                int wumpusstart = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                Hazards newWumpus = new Hazards("Wumpus", wumpusstart);
                bool tmp = true;
                //Checks for uniqeness between the player's starting room and the Wumpus's starting room
                if (playerspawn == wumpusstart)
                {
                    tmp = false;
                }
                // If the number generated is unique from the player's, return a valid room the wumpus can spawn in
                if (tmp)
                {
                    allSpawnables.Add(newWumpus);
                    wumpusroom = wumpusstart;
                    return wumpusstart;
                }
            }
        }

        public int GetWumpusRoom()
        {
            return wumpusroom;
        }
        //returns a bool array of what hazards are in the current room (wumpus, bats, pit)
        public bool[] CheckForHazard(PlayerManager playerManager)
        {
            //gets the current room the player is in
            int currentRoom = playerManager.CurrentRoom;
            bool[] hazardChecker = [false, false, false];
            //cycles through the list allSpawnables (contains hazards + the wumpus)
            for (int i = 0; i < allSpawnables.Count; i++)
            {
                if (allSpawnables[i].room == currentRoom)
                {
                    if (allSpawnables[i].hazard == "Wumpus")
                    {
                        hazardChecker[0] = true;
                    }
                    if (allSpawnables[i].hazard == "Bats")
                    {
                        hazardChecker[1] = true;
                    }
                    if (allSpawnables[i].hazard == "Pit")
                    {
                        hazardChecker[2] = true;
                    }
                }
            }
            return hazardChecker;
        }

        //returns a bool array of what hazards are in at least 1 adjacent rooms (wumpus, bats, pit)
        public bool[] CheckForNearbyHazards(PlayerManager playerManager, CaveManager caveManager)
        {
            //gets an array of adjacent rooms based on the current room of the player
            int[] adjacentRooms = caveManager.GetAdjacentRooms(playerManager.CurrentRoom);
            //gets an array of valid directions based on the curernt room of the player
            bool[] validDirections = caveManager.GetDirectionsBoolArray(playerManager.CurrentRoom);
            //cycles through the array of adjacent rooms to remove adjacent rooms that aren't valid directoins
            for (int d = 0; d < adjacentRooms.Length; d++)
            {
                //checks if the direction matching the current adjacent room in the array is valid
                if (validDirections[d] == false)
                {
                    //sets the invalid room to a value no hazards/wumpus could be in
                    adjacentRooms[d] = 31;
                }
            }
            bool[] hazardChecker = [false, false, false];
            //cycles through each of the adjacent rooms
            for (int i = 0; i < adjacentRooms.Length; i++)
            {
                //cycles through the list allSpawnables (contains hazards + the wumpus)
                for (int i2 = 0; i2 < allSpawnables.Count; i2++)
                {
                    if (allSpawnables[i2].room == adjacentRooms[i])
                    {
                        if (allSpawnables[i2].hazard == "Wumpus")
                        {
                            hazardChecker[0] = true;
                        }
                        if (allSpawnables[i2].hazard == "Bats")
                        {
                            hazardChecker[1] = true;
                        }
                        if (allSpawnables[i2].hazard == "Pit")
                        {
                            hazardChecker[2] = true;
                        }
                    }
                }
            }
            return hazardChecker;
        }

        public int MoveWumpus(CaveManager caveManager)
        {
            //gets an array of adjacent rooms based on the current room of the player
            int[] adjacentRooms = caveManager.GetAdjacentRooms(wumpusroom);
            //gets an array of valid directions based on the curernt room of the player
            bool[] validDirections = caveManager.GetDirectionsBoolArray(wumpusroom);
            //cycles through the array of adjacent rooms to remove adjacent rooms that aren't valid directoins
            for (int d = 0; d < adjacentRooms.Length; d++)
            {
                //checks if the direction matching the current adjacent room in the array is valid
                if (validDirections[d] == false)
                {
                    //sets the invalid room to a invalid room
                    adjacentRooms[d] = 31;
                }
            }
            while (wumpusroom == 31)
            {
                wumpusroom = adjacentRooms[random.Next(0, 5)];
            }
            return wumpusroom;
        }

    }
    public interface IGameLocation
    {
        public int SpawnPlayer();
        public int SpawnWumpus();
        public bool[] CheckForHazard(PlayerManager playerManager);
        public bool[] CheckForNearbyHazards(PlayerManager playerManager, CaveManager caveManager);
        public int GetWumpusRoom();
        public int MoveWumpus(CaveManager caveManager);
        public int EncounterBat(PlayerManager playerManager);
    }
}
