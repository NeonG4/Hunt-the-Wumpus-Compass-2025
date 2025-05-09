using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveLibrary
{
    public class CaveManager : ICave
    {
        //Cave index

        /// <summary>
        /// Current cave index from 0-4
        /// </summary>
        public int CaveIndex { get; set; }

        //Constructor inputting cave index, to be called when starting game

        /// <summary>
        /// Create an instance of the cave manager
        /// </summary>
        /// <param name="caveIndex">Cave index from 0-4 based on user's choice</param>
        public CaveManager(int caveIndex)
        {
            CaveIndex = caveIndex;
        }

        //Method to get the 6 adjacent rooms for a given room

        FileReader reader = new FileReader();

        /// <summary>
        /// Returns the rooms adjacent to the player's current room
        /// </summary>
        /// <param name="room">Current room number</param>
        /// <returns>Int array of adjacent room number in each direction (0-5)</returns>
        public int[] GetAdjacentRooms(int room)
        {
            if (0 <= room && room <= 29)
            {
                //Get the int[] of adjacent rooms for this room

                return reader.adjacentRooms[room];
            }
            else
            {
                return null;
            }
        }

        //Method to say whether each direction 0-5 is reachable

        /// <summary>
        /// Returns whether each adjacent room is reachable
        /// </summary>
        /// <param name="room">Current room number</param>
        /// <returns>Bool array of whether player can go in each direction (0-5)</returns>
        public bool[] GetDirectionsBoolArray(int room)
        {
            if (0 <= room && room <= 29 &&
                0 <= CaveIndex && CaveIndex <= 4)
            {
                //Read from valid directions data file corresponding to the cave index

                int[] validDirections;

                if (CaveIndex == 0) { validDirections = reader.validDirectionsA[room]; }
                else if (CaveIndex == 1) { validDirections = reader.validDirectionsB[room]; }
                else if (CaveIndex == 2) { validDirections = reader.validDirectionsC[room]; }
                else if (CaveIndex == 3) { validDirections = reader.validDirectionsD[room]; }
                else { validDirections = reader.validDirectionsE[room]; }

                //Define bool array

                bool[] directionsBoolArray = new bool[6];

                //Check if each direction 0-5 is in the array

                for (int i = 0; i <= 5; i++)
                {
                    foreach (int direction in validDirections)
                    {
                        if (i == direction)
                        {
                            directionsBoolArray[i] = true;
                            break;
                        }
                    }
                }

                //Return the bool array of the 6 directions' reachabilities

                return directionsBoolArray;
            }
            else
            {
                return null;
            }
        }

        //Method to get the room number reached when the player moves

        /// <summary>
        /// Returns the number of the new room upon moving
        /// </summary>
        /// <param name="room">Current room number</param>
        /// <param name="direction">Direction (0-5) of the player's move</param>
        /// <returns>Int value for the player's new room</returns>
        public int GetNewRoomNumber(int room, int direction)
        {
            if (0 <= room && room <= 29 &&
                0 <= direction && direction <= 5)
            {
                //Return adjacent room of current room corresponding to direction

                return reader.adjacentRooms[room][direction];
            }
            else
            {
                //To ensure code doesn't break in test application

                return 0;
            }
        }

        //Method to double check that a move a player makes is valid

        /// <summary>
        /// Returns whether a move in a certain direction is valid
        /// </summary>
        /// <param name="room">Current room number</param>
        /// <param name="direction">Direction (0-5) player wishes to move</param>
        /// <returns>Bool for whether the move is valid</returns>
        public bool IsValidMove(int room, int direction)
        {
            if (0 <= room && room <= 29 &&
                0 <= direction && direction <= 5 &&
                0 <= CaveIndex && CaveIndex <= 4)
            {
                //Read from valid directions data file corresponding to the cave index

                int[] validDirections;

                if (CaveIndex == 0) { validDirections = reader.validDirectionsA[room]; }
                else if (CaveIndex == 1) { validDirections = reader.validDirectionsB[room]; }
                else if (CaveIndex == 2) { validDirections = reader.validDirectionsC[room]; }
                else if (CaveIndex == 3) { validDirections = reader.validDirectionsD[room]; }
                else { validDirections = reader.validDirectionsE[room]; }

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
    }

    public interface ICave
    {
        //Make sure GC uses the constructor so that the files are read from

        //Properties for cave index

        int CaveIndex { get; set; }

        //For UI to tell player which rooms are around the player (directions 0-5)

        int[] GetAdjacentRooms(int room);

        //For UI to tell player which directions they can move (directions 0-5)

        bool[] GetDirectionsBoolArray(int room);

        //To get the new room number based on direction moved, to be used after IsValidMove bool

        int GetNewRoomNumber(int room, int direction);

        //To be called by game control to make sure moving in specified direction is valid

        bool IsValidMove(int room, int direction);
    }
}
