using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Hunt_the_Wumpus_2025
{
    public class TriviaManager
    {
        private List<Trivia> TriviaList { get; set; }

        TriviaManager()
        {
            this.Deserialize();
        }

        public Trivia getTriviaData(int i)
        {
            return this.TriviaList[i];
        }

        public string getQuestion(int i)
        {
            return this.TriviaList[i].Question;
        }
        public string[] getPosssibleAnswers(int i)
        {
            return this.TriviaList[i].PossibleAnswers;
        }
        public string getCorrectAnswer(int i)
        {
            return this.TriviaList[i].CorrectAnswer;
        }

        public class Trivia // pretty sure i need to define the class in this class to get the json to work. I will delete this if i find out its useless
        {
            public string Question { get; set; }
            public string[] PossibleAnswers { get; set; }
            public string CorrectAnswer { get; set; }
        }

        private void Serialize()
        {
            string filePath = "TriviaQuestions.json";
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
            string filePath = "TriviaQuestions.json";
            try
            {
                string jsonString = File.ReadAllText(filePath);
                this.TriviaList = JsonSerializer.Deserialize<List<Trivia>>(jsonString);
                Console.WriteLine("List successfully deserialized:");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during deserialization: {ex.Message}");
            }
        }
    }
}
