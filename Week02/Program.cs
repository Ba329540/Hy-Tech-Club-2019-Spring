using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");
            //Hello World
            string userName = "(za-CH)";
            int userAge = 15;
            int numberOfPets = 0;
            string schoolAttended = "Westlake High School";

            Console.WriteLine("Hello! My name is " + userName);
            //Hello! My name is (za-CH)
            Console.WriteLine(String.Format("I am {0} years old and have {1} pets!", userAge, numberOfPets));
            Console.WriteLine(String.Format("I go to {0}", schoolAttended));
            //In-class work
            bool randBool = false;
            double randDouble = 3.14;
            int randInt = 9001;
            string randText = "Just some random text!";

            Console.WriteLine($"{randBool}, {randDouble}, {randInt}, {randText}");
            //Challenges
            Random rnd = new Random();
            int randomInt = rnd.Next(26);
            Console.WriteLine($"{randomInt}");
            int randomDiceRollOne = rnd.Next(1, 7);
            int randomDiceRollTwo = rnd.Next(1, 7);
            Console.WriteLine($"{randomDiceRollOne}, {randomDiceRollTwo}");
        }
        
    }
}
