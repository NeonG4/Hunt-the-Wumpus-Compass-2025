using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerManager : IPlayer
    {
        //Constructor to be called by Game Control

        public PlayerManager() { }

        //Define the player

        Player player = new Player();

        //Method to add or subtract arrows

        public bool AddOrSubtractArrows(bool isAddition, int amount)
        {
            //If subtracting too much, return false to tell GC player cannot use arrows

            if (!isAddition && (amount > player.Arrows))
            {
                return false;
            }

            else
            {
                //Add or subtract as required

                if (isAddition)
                {
                    player.Arrows += amount;
                }

                else
                {
                    player.Arrows -= amount;
                }

                //Return true to return and continue the game

                return true;
            }
        }

        //Method to add or subtract gold coins

        public bool AddOrSubtractGoldCoins(bool isAddition, int amount)
        {
            //If subtracting too much, return false to tell GC player lost the game

            if (!isAddition && (amount > player.GoldCoins))
            {
                return false;
            }

            else
            {
                //Add or subtract as required

                if (isAddition)
                {
                    player.GoldCoins += amount;
                }

                else
                {
                    player.GoldCoins -= amount;
                }

                //Return true to return and continue the game

                return true;
            }
        }

        //Method to increase move count by 1

        public void IncrementMoveCount()
        {
            player.MoveCount++;
        }

        //Method to calculate ending score

        public int GetEndingScore(bool killedWumpus)
        {
            int score = 100 - player.MoveCount + player.GoldCoins + (5 * player.Arrows);

            //Add 50 if wumpus was killed

            if (killedWumpus)
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

        //Method to compute ending score

        int GetEndingScore(bool killedWumpus);
    }
}
