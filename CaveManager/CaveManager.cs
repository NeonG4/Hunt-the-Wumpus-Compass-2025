using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveManager
{
    public class CaveManager
    {
        //File names

        const string FILE_ADJACENT_ROOMS = "adjacentRooms.csv";
        const string FILE_VALID_DIRECTIONS_A = "caveA-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_B = "caveB-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_C = "caveC-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_D = "caveD-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_E = "caveE-validDirections.csv";

        public int[] GetNeighboringRooms(int room)
        {
            //placeholder, to get from file
            //(which has neighboring rooms)

            //placeholder

            return [0, 0, 0, 0, 0, 0];
        }

        public bool IsValidMove(int room, int direction, int caveIndex)
        {
            //placeholder

            return true;
        }

        public int[] GetReachableNeighboringRooms(int room, int caveIndex)
        {
            //placeholder

            return [0, 0, 0];
        }

        private List<int[]> ReadFromFile(string fileName)
        {
            //Read from file

            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();

            List<int[]> list = new List<int[]>();

            while (line != null)
            {
                //Parse the line

                string[] array = line.Split(',');

                //Convert to integers

                int[] intArray = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    intArray[i] = int.Parse(array[i]);
                }

                list.Add(intArray);

                line = reader.ReadLine();
            }

            reader.Close();

            return list;
        }
    }
}
