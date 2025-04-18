using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    internal class Trivia
    {
        public string Question { get; set; }
        public string[] PossibleAnswers { get; set; }
        public  string CorrectAnswer { get; set; }

        public Trivia() { }

        public Trivia(string question, string[] possibleAnswer, string correctAnswer)
        {
            this.Question = question;
            this.PossibleAnswers = possibleAnswer;
            this.CorrectAnswer = correctAnswer;
        }
    }
}
