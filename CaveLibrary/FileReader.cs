using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveLibrary
{
    public class FileReader
    {
        //Constructor

        /// <summary>
        /// Create an instance of the file reader
        /// </summary>
        public FileReader() 
        {
            //Read to files

            adjacentRooms = ReadFromFile(FILE_ADJACENT_ROOMS);
            validDirectionsA = ReadFromFile(FILE_VALID_DIRECTIONS_A);
            validDirectionsB = ReadFromFile(FILE_VALID_DIRECTIONS_B);
            validDirectionsC = ReadFromFile(FILE_VALID_DIRECTIONS_C);
            validDirectionsD = ReadFromFile(FILE_VALID_DIRECTIONS_D);
            validDirectionsE = ReadFromFile(FILE_VALID_DIRECTIONS_E);
        }

        //File names

        const string FILE_ADJACENT_ROOMS = "adjacentRooms.csv";
        const string FILE_VALID_DIRECTIONS_A = "caveA-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_B = "caveB-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_C = "caveC-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_D = "caveD-validDirections.csv";
        const string FILE_VALID_DIRECTIONS_E = "caveE-validDirections.csv";

        //Read from adjacent rooms data file

        /// <summary>
        /// CSV file for rooms adjacent to each room
        /// </summary>
        public List<int[]> adjacentRooms { get; set; }

        //Read from valid directions files

        /// <summary>
        /// CSV file for valid directions for each room in cave A
        /// </summary>
        public List<int[]> validDirectionsA { get; set; }

        /// <summary>
        /// CSV file for valid directions for each room in cave B
        /// </summary>
        public List<int[]> validDirectionsB { get; set; }

        /// <summary>
        /// CSV file for valid directions for each room in cave C
        /// </summary>
        public List<int[]> validDirectionsC { get; set; }

        /// <summary>
        /// CSV file for valid directions for each room in cave D
        /// </summary>
        public List<int[]> validDirectionsD { get; set; }

        /// <summary>
        /// CSV file for valid directions for each room in cave E
        /// </summary>
        public List<int[]> validDirectionsE { get; set; }

        //Method to read a csv file to a List of int arrays

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
}
