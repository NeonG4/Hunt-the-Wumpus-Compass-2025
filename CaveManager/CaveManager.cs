using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cave
{
    public class CaveManager : ICave
    {
        //Constructor

        public CaveManager() { }

        //File names

        const string FILE_ADJACENT_ROOMS = "adjacentRooms.csv";
        const string FILE_VALID_DIRECTIONS_A = "caveA-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_B = "caveB-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_C = "caveC-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_D = "caveD-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_E = "caveE-validDirections.csv";

        //Read from adjacent rooms data file

        List<int[]> adjacentRooms = ReadFromFile(FILE_ADJACENT_ROOMS);

        //Read from valid directions files

        List<int[]> validDirectionsA = ReadFromFile(FILE_VALID_DIRECTIONS_A);
        List<int[]> validDirectionsB = ReadFromFile(FILE_VALID_DIRECTIONS_B);
        List<int[]> validDirectionsC = ReadFromFile(FILE_VALID_DIRECTIONS_C);
        List<int[]> validDirectionsD = ReadFromFile(FILE_VALID_DIRECTIONS_D);
        List<int[]> validDirectionsE = ReadFromFile(FILE_VALID_DIRECTIONS_E);

        public int[] GetAdjacentRooms(int room)
        {
            if (0 <= room && room <= 29)
            {
                //Get the int[] of adjacent rooms for this room

                return adjacentRooms[room];
            }
            else
            {
                return null;
            }
        }
        public int[] GetValidDirections(int room, int caveIndex)
        {
            if (0 <= room && room <= 29 &&
                0 <= caveIndex && caveIndex <= 4)
            {
                //Read from valid directions data file corresponding to the cave index

                int[] validDirections;

                if (caveIndex == 0) { validDirections = validDirectionsA[room]; }
                else if (caveIndex == 1) { validDirections = validDirectionsB[room]; }
                else if (caveIndex == 2) { validDirections = validDirectionsC[room]; }
                else if (caveIndex == 3) { validDirections = validDirectionsD[room]; }
                else { validDirections = validDirectionsE[room]; }

                return validDirections;
            }
            else
            {
                return null;
            }
        }

        public int GetNewRoomNumber(int room, int direction)
        {
            if (0 <= room && room <= 29 &&
                0 <= direction && direction <= 5)
            {
                //Return adjacent room of current room corresponding to direction

                return adjacentRooms[room][direction];
            }
            else
            {
                //To ensure code doesn't break in test application

                return 0;
            }
        }

        public bool IsValidMove(int room, int direction, int caveIndex)
        {
            if (0 <= room && room <= 29 && 
                0 <= direction && direction <= 5 && 
                0 <= caveIndex && caveIndex <= 4)
            {
                //Read from valid directions data file corresponding to the cave index

                int[] validDirections;

                if (caveIndex == 0) { validDirections = validDirectionsA[room]; }
                else if (caveIndex == 1) { validDirections = validDirectionsB[room]; }
                else if (caveIndex == 2) { validDirections = validDirectionsC[room]; }
                else if (caveIndex == 3) { validDirections = validDirectionsD[room]; }
                else { validDirections = validDirectionsE[room]; }

                //Return true if direction is present in the valid directions array for this room index

                foreach (int i in validDirections)
                {
                    if (i == direction)
                    {
                        return true;
                    }
                }

                //Otherwise

                return false;
            }
            else
            {
                return false;
            }
        }

        private static List<int[]> ReadFromFile(string fileName)
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

    public interface ICave
    {
        //Make sure GC uses the constructor so that the files are read from!

        //For UI to tell player which rooms are around the player

        int[] GetAdjacentRooms(int room);

        //For UI to tell player which directions they can move

        int[] GetValidDirections(int room, int caveIndex);

        //To get the new room number based on direction moved, to be used after IsValidMove bool

        int GetNewRoomNumber(int room, int direction);

        //To be called by game control to make sure moving in specified direction is valid

        bool IsValidMove(int room, int direction, int caveIndex);
    }
}
