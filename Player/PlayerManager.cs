using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerManager : IPlayer
    {
        //Constructor to be called by GC

        public PlayerManager() { }

        //Properties
        public int Arrows { get; set; }
        public int GoldCoins { get; set; }
        public int MoveCount { get; set; }
        public bool KilledWumpusBool { get; set; }
        public int Score
        {
            get
            {
                if (KilledWumpusBool)
                {
                    return 10000 + 200 * GoldCoins + 750 * Arrows + 10000;
                }
                else
                {
                    return 10000 + 200 * GoldCoins + 750 * Arrows;
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

        //Method to indicate wumpus was killed in player class

        public void KilledWumpus()
        {
            KilledWumpusBool = true;
        }

        //Method to calculate ending score

        public int GetEndingScore()
        {
            int score = 100 - MoveCount + GoldCoins + (5 * Arrows);

            //Add 50 if wumpus was killed

            if (KilledWumpusBool)
            {
                score += 50;
            }

            //Return the score

            return score;
        }
    }

    public interface IPlayer
    {
        //Methods to change player inventory
        //IMPORTANT: Returns true or false for whether you can pay/use arrows or not
        //False for gold coins would mean you lose the game!!

        bool AddOrSubtractArrows(bool isAddition, int amount);

        bool AddOrSubtractGoldCoins(bool isAddition, int amount);

        //Method to increment number of moves

        void IncrementMoveCount();

        //Method to tell Player class that the wumpus has been killed

        void KilledWumpus();

        //Method to compute ending score

        int GetEndingScore();
    }
}
