using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace Hunt_the_Wumpus_2025
{
    public class TriviaManager
    {
        private List<TriviaQuestion> TriviaList { get; set; }
        public int triviaIndex {  get; set; }

        string filePath = "TriviaQuestions.json";
        public TriviaManager()
        {
            this.Deserialize();
            Random rand = new Random();
            triviaIndex = rand.Next(99);
        }

        public TriviaQuestion getTriviaData(int i)
        {
            if (i > TriviaList.Count - 1)
            {
                return this.TriviaList[1];
            }
            return this.TriviaList[i];
        }

        public string getQuestion(int i)
        {
            return this.TriviaList[i].question;
        }
        public string[] getPossibleAnswers(int i)
        {
            return this.TriviaList[i].possibleAnswers;
        }
        public string getCorrectAnswer(int i)
        {
            return this.TriviaList[i].correctAnswer;
        }

        private void Serialize()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(this.TriviaList);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine($"List successfully serialized and saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during serialization: {ex.Message}");
            }

        }
        private void Deserialize()
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                this.TriviaList = JsonSerializer.Deserialize<List<TriviaQuestion>>(jsonString);
                Console.WriteLine("List successfully deserialized:");
            }
            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine($"An error occurred during deserialization: {ex.Message}");
            }
        }
    }



    public class TriviaQuestion 
    {
        public string question { get; set; }
        public string[] possibleAnswers { get; set; }
        public string correctAnswer { get; set; }
        public TriviaQuestion(string question, string[] possibleAnswers, string correctAnswer)
        {
            this.question = question;
            this.possibleAnswers = possibleAnswers;
            this.correctAnswer = correctAnswer;
        }
    }
}
