using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLibrary
{
    public class PlayerManager : IPlayer
    {
        //Constructor to be called by GC

        /// <summary>
        /// Create an instance of the player manager
        /// </summary>
        /// <param name="startingRoom">Room from which the player starts (from GL)</param>
        public PlayerManager(int startingRoom)
        {
            Arrows = 0;
            GoldCoins = 0;
            MoveCount = 0;
            KilledWumpus = false;

            CurrentRoom = startingRoom;
        }

        //Current Room Number Property

        /// <summary>
        /// Current room number
        /// </summary>
        public int CurrentRoom { get; set; }

        //Other Properties

        /// <summary>
        /// Number of arrows in inventory
        /// </summary>
        public int Arrows { get; set; }

        /// <summary>
        /// Number of gold coins in inventory
        /// </summary>
        public int GoldCoins { get; set; }

        /// <summary>
        /// Number of moves made during this game
        /// </summary>
        public int MoveCount { get; set; }

        /// <summary>
        /// Bool for whether the wumpus has been killed or not
        /// </summary>
        public bool KilledWumpus { get; set; }

        /// <summary>
        /// Returns the current score
        /// </summary>
        public int Score
        {
            get
            {
                if (KilledWumpus)
                {
                    return (int)((1000 + 25 * GoldCoins + 75 * Arrows - 50 * MoveCount) * 1.5);
                }
                else
                {
                    return 1000 + 25 * GoldCoins + 75 * Arrows - 50 * MoveCount;
                }
            }
        }

        //Method to add or subtract arrows

        /// <summary>
        /// Adds or subtracts arrows from player inventory
        /// </summary>
        /// <param name="isAddition">Input true if addition, false if subtraction</param>
        /// <param name="amount">Absolute value of the amount to add or subtract</param>
        /// <returns>Bool for whether the action was successful</returns>
        public bool AddOrSubtractArrows(bool isAddition, int amount)
        {
            //If subtracting too much, return false to tell GC player cannot use arrows

            if (!isAddition && (amount > Arrows))
            {
                return false;
            }

            else
            {
                //Add or subtract as required

                if (isAddition)
                {
                    Arrows += amount;
                }

                else
                {
                    Arrows -= amount;
                }

                //Return true to return and continue the game

                return true;
            }
        }

        //Method to add or subtract gold coins

        /// <summary>
        /// Adds or subtracts coins from player inventory
        /// </summary>
        /// <param name="isAddition">Input true if addition, false if subtraction</param>
        /// <param name="amount">Absolute value of the amount to add or subtract</param>
        /// <returns>Bool for whether the action was successful</returns>
        public bool AddOrSubtractGoldCoins(bool isAddition, int amount)
        {
            //If subtracting too much, return false to tell GC player lost the game

            if (!isAddition && (amount > GoldCoins))
            {
                return false;
            }

            else
            {
                //Add or subtract as required

                if (isAddition)
                {
                    GoldCoins += amount;
                }

                else
                {
                    GoldCoins -= amount;
                }

                //Return true to return and continue the game

                return true;
            }
        }

        //Method to increase move count by 1

        /// <summary>
        /// Increases move count by 1
        /// </summary>
        public void IncrementMoveCount()
        {
            MoveCount++;
        }
    }

    public interface IPlayer
    {
        //Current Room

        int CurrentRoom { get; set; }

        //Properties for arrows, coins, turns for use by GC, high score

        int Arrows { get; set; }
        int GoldCoins { get; set; }
        int MoveCount { get; set; }
        int Score { get; }

        //Methods to change player inventory
        //IMPORTANT: Returns true or false for whether you can pay/use arrows/coins or not
        //isAddition parameter: input true if you're adding arrows/coins, false if removing them
        //False for gold coins would mean you lose the game!!

        bool AddOrSubtractArrows(bool isAddition, int amount);

        bool AddOrSubtractGoldCoins(bool isAddition, int amount);

        //Method to increment number of moves (use every time player moves)

        void IncrementMoveCount();
    }
}
