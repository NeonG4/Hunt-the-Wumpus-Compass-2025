using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Hunt_the_Wumpus_2025
{
    public class TriviaManager
    {
        private List<Trivia> TriviaList { get; set; }

        TriviaManager()
        {
            AddTriviaQuestions();
        }

        public Trivia[] getRandomTriviaQuestions(int i) // i is the number of questions that you want to get (no- it is not zerobased, that would make no sense)
        {
            Random rand = new Random();

            Trivia[] Questions = new Trivia[i];
            int[] randomNumbs = new int[i];
            bool sameNumber = false;

            for (int j = 0; j < i; j++) 
            {
                int newNum = rand.Next(); //gets a new reandome number 

                sameNumber = false; // sets the same number as false before checking if it is true

                for (int k = 0; k < i; k++) // loop to see if any of the numbers are the same 
                {
                    if (randomNumbs[k] != null) break; //if there are no more numbers in the array, it stops the loop

                    else if (newNum == randomNumbs[k]) //if the new number is the same as another then sameNumber becomes true and it stoos the loop
                    {
                        sameNumber = true; 
                        break;
                    }
                }

                if (sameNumber == false) //gets te
                {
                    randomNumbs[j] = newNum;
                    Questions[j] = TriviaList[i];
                }
            }
            return Questions;
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

        // Hardcoded trivia questions for now. i will get a file out soon 
        private void AddTriviaQuestions()
        {

            string[] answers1 = { "Luigi", "Mario", "Wario", "Toad" };
            triviaList.Add(new Trivia("What is the name of the main character in the original 'Super Mario Bros.'?", answers1, "Mario"));

            string[] answers2 = { "Peach", "Daisy", "Zelda", "Rosalina" };
            triviaList.Add(new Trivia("In 'The Legend of Zelda', what is the name of the princess?", answers2, "Zelda"));

            string[] answers3 = { "Pong", "Pac-Man", "Space Invaders", "Donkey Kong" };
            triviaList.Add(new Trivia("What was the first commercially successful arcade video game?", answers3, "Pong"));

            string[] answers4 = { "Koopa Troopa", "Ghost", "Creeper", "Space Invader" };
            triviaList.Add(new Trivia("Which creature is the primary antagonist in the 'Pac-Man' arcade game?", answers4, "Ghost"));

            string[] answers5 = { "Samus Aran", "Link", "Mega Man", "Pit" };
            triviaList.Add(new Trivia("What is the name of the hero in the 'Metroid' series?", answers5, "Samus Aran"));

            string[] answers6 = { "Plumber", "Carpenter", "Electrician", "Chef" };
            triviaList.Add(new Trivia("In 'Donkey Kong', what does Mario (Jumpman) do for a living?", answers6, "Carpenter"));

            string[] answers7 = { "Knuckles", "Tails", "Amy", "Shadow" };
            triviaList.Add(new Trivia("What is the name of Sonic the Hedgehog's best friend?", answers7, "Tails"));

            string[] answers8 = { "Uncharted", "Prince of Persia", "Tomb Raider", "Indiana Jones" };
            triviaList.Add(new Trivia("Which game introduced the character Lara Croft?", answers8, "Tomb Raider"));

            string[] answers9 = { "Fire-type", "Water-type", "Electric-type", "Grass-type" };
            triviaList.Add(new Trivia("What type of creature is Pikachu in the 'Pokémon' franchise?", answers9, "Electric-type"));

            string[] answers10 = { "Millennium Falcon", "Enterprise", "Rockethip", "There is no named ship" };
            triviaList.Add(new Trivia("What is the name of the spaceship in 'Asteroids'?", answers10, "There is no named ship"));

            string[] answers11 = { "Destroy Earth", "Steal resources", "Communicate with humans", "Just fly around" };
            triviaList.Add(new Trivia("In 'Space Invaders', what are the enemies trying to do?", answers11, "Destroy Earth"));

            string[] answers12 = { "Sword", "Gun", "Buster", "Whip" };
            triviaList.Add(new Trivia("What is the primary weapon of Mega Man?", answers12, "Buster"));

            string[] answers13 = { "Galaga", "Centipede", "Pac-Man", "Frogger" };
            triviaList.Add(new Trivia("Which classic arcade game involves eating dots and avoiding ghosts in a maze?", answers13, "Pac-Man"));

            string[] answers14 = { "Rex", "Yoshi", "Wart", "Birdo" };
            triviaList.Add(new Trivia("What is the name of the green dinosaur in the 'Super Mario' series?", answers14, "Yoshi"));

            string[] answers15 = { "Harp", "Flute", "Ocarina", "Drums" };
            triviaList.Add(new Trivia("In 'The Legend of Zelda: Ocarina of Time', what is Link's primary instrument?", answers15, "Ocarina"));

            string[] answers16 = { "Atari", "Nintendo", "Sega", "Namco" };
            triviaList.Add(new Trivia("What company developed the 'Donkey Kong' arcade game?", answers16, "Nintendo"));

            string[] answers17 = { "Goombas", "Koopa Troopas", "Spinies", "Piranha Plants" };
            triviaList.Add(new Trivia("What is the name of the spiky-shelled enemies in the 'Super Mario' series?", answers17, "Spinies"));

            string[] answers18 = { "Castlevania", "Contra", "Ninja Gaiden", "Ghosts 'n Goblins" };
            triviaList.Add(new Trivia("Which game features a character named Simon Belmont?", answers18, "Castlevania"));

            string[] answers19 = { "Cars", "Planes", "Boats", "Tanks" };
            triviaList.Add(new Trivia("What type of vehicle does Frogger try to cross in the classic game 'Frogger'?", answers19, "Cars"));

            string[] answers20 = { "Adam Malkovich", "Justin Bailey", "Samus Aran", "Sylux" };
       

           
        }
    }
}
