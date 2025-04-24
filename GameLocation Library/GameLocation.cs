using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class GameLocation : IGameLocation
    {
        public List<Hazards> hazards = new List<Hazards>();
        Random random = new Random();

        public GameLocation()
        {
            // places hazards in 4 random rooms (2 rooms for pits, 2 for bats)
            string h = string.Empty;
            int r = 0;
            Hazards newHazard = new Hazards(h, r);
            int number;
            for (int room = 0; room < 2; room++)
            {
                do {
                    number = random.Next(31);
                } while (newHazard.room == number);
                h = "Pit";
                hazards.Add(newHazard);
            }
            for (int room = 0; room < 2; room++)
            {
                do
                {
                    number = random.Next(31);
                } while (newHazard.room == number);
                h = "Bats";
                hazards.Add(newHazard);
            }
        }
    }
    public interface IGameLocation
    {

    }
}
