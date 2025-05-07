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

        public PlayerManager(int startingRoom)
        {
            Arrows = 0;
            GoldCoins = 0;
            MoveCount = 0;
            KilledWumpus = false;

            CurrentRoom = startingRoom;
        }

        //Current Room Number Property

        public int CurrentRoom { get; set; }

        //Other Properties

        public int Arrows { get; set; }
        public int GoldCoins { get; set; }
        public int MoveCount { get; set; }
        public bool KilledWumpus { get; set; }
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
