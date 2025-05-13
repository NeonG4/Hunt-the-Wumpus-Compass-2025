using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveLibrary;

namespace GameLocationLibrary
{
    public class GameLocation : IGameLocation
    {
        public List<Hazards> hazards = new List<Hazards>();
        public List<Hazards> allSpawnables = new List<Hazards>();
        Random random = new Random();
        int wumpusspawn = 31;
        int playerspawn = 31;

        //Method that returns a list of hazards/the room they are located in
        public GameLocation()
        {
            AddHazard("Pit");
            AddHazard("Pit");
            AddHazard("Bats");
            AddHazard("Bats");
            SpawnWumpus();
            SpawnPlayer();
            /*
            //If there are no hazards, add 4 hazards (2 pits and 2 bats)
            if (hazards.Count == 0)
            {
                AddHazard("Pit");
                AddHazard("Pit");
                AddHazard("Bats");
                AddHazard("Bats");
            }
            //Return the hazards list
            return new List<Hazards>();
            */
        }

        //Adds a new hazard of a specified type
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
                // If the number generated is unique, add the new hazard
                if (tmp)
                {
                    hazards.Add(newHazard);
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
                Hazards newHazard = new Hazards("Player", playerstart);
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
                // If the number generated is unique, spawn the player
                if (tmp)
                {
                    allSpawnables.Add(newHazard);
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
                Hazards newHazard = new Hazards("Wumpus", wumpusstart);
                bool tmp = true;
                //Checks for uniqeness between the player's starting room and the Wumpus's starting room
                if (playerspawn == wumpusstart)
                {
                    tmp = false;

                }
                // If the number generated is unique from the player's, spawn the Wumpus
                if (tmp)
                {
                    allSpawnables.Add(newHazard);
                    wumpusspawn = wumpusstart;
                    return wumpusstart;
                }
            }
        }
    }
    public interface IGameLocation
    {
        public int SpawnPlayer();
        public int SpawnWumpus();
    }
}
