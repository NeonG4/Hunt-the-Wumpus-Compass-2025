using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class Trivia
    {
        public string Question { get; set; } 
        public string[] PossibleAnswers { get; set; } // not sure how many possible answers we want so figured I wouldn't set an amount
        public string CorrectAnswer { get; set; }

        public Trivia() { } // so that I can call it with out all the data

        public Trivia(string question, string[] possibleAnswers, string correctAnswer) //contructor so I can use it for a list :))
        {
            this.Question = question;
            this.PossibleAnswers = possibleAnswers;
            this.CorrectAnswer = correctAnswer;
        }
        
    }
}
