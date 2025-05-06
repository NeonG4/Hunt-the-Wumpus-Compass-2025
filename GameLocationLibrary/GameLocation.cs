using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cave;

namespace GameLocationLibrary
{
    public class GameLocation : IGameLocation
    {
        public List<Hazards> hazards = new List<Hazards>();
        Random random = new Random();

        //Method that returns a list of hazards/the room they are located in
        public List<Hazards> GetHazards()
        {
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
                int startingroom = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                bool tmp = true;
                //Cycles through the hazards list until the random room is a unique value
                for (int i = 0; i < hazards.Count; i++)
                {
                    if (hazards[i].room == startingroom)
                    {
                        tmp = false;
                        i = hazards.Count();
                    }
                }
                // If the number generated is unique, return the chosen starting room of the player
                if (tmp)
                {
                    return startingroom;
                }
            }
        }
    }
    public interface IGameLocation
    {
        public List<Hazards> GetHazards();

        public int SpawnPlayer();
    }
}
