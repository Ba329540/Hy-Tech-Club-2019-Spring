using System;

namespace Week_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this game, you make important life decisions");
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine("Enter your name:");
                string playerName = Console.ReadLine();
                Console.WriteLine("Hello " + playerName + "!");
                Console.WriteLine("You will start out with $100, which you can spend later on.");
                Console.WriteLine("At various points throughout the game, you will be given a choice between a few things");

            }
            //All variables relating to the direct gameplay will go below:
            int money = 100;
            int schoolChoice = Convert.ToInt32(Console.ReadLine());
            int ageAfterLoop = 10;
            string job = Console.ReadLine();
            //Below is the incomes for one year
            int jobIncomeMcDs = 25000;
            int jobIncomeBills = 35000;
            int jobIncomeMechanic = 45000;

            for (int age = 0; age <= 10; age++)
            {
                Console.WriteLine("You have aged 1 year and are now " + age + " years old.");
            }

            Console.WriteLine("You have a choice of the middle school you go to: (1)Go to public school, (2) go to private school.");
            if (schoolChoice == 1)
            {
                Console.WriteLine("Welcome to Thomas Jefferson Junior High!");
            } else if (schoolChoice == 2)
            {
                Console.WriteLine("Welcome to Saint Peter Middle School!");
                ageAfterLoop++;
                Console.WriteLine(ageAfterLoop);
                Console.WriteLine("You hate Catholicism so you leave after only 1 year.");
            }
            
            ageAfterLoop++;
            ageAfterLoop++;
            ageAfterLoop++;
            ageAfterLoop++;
            ageAfterLoop++;
            ageAfterLoop++;
            ageAfterLoop++;
            Console.WriteLine("You are now 18 years old.");
            Console.WriteLine("Do you want to go to college?");
            Console.WriteLine("(1)Yes; (2)No.");
            int collegeChoice = Convert.ToInt32(Console.ReadLine());
            if (collegeChoice == 1)
            {
                Console.WriteLine("You have spent all your money on college and your parents payed the rest");
                while(money > 0)
                {
                    money--;
                    Console.WriteLine(money);
                }
            } else if (collegeChoice == 2)
            {
                Console.WriteLine("You big loser, not going to college! Well, you decide to get a job instead");
                if (job == "McDonalds")
                {
                    Console.WriteLine("You've been hired an you now make $9 an hour. You are working 40 hours per week");
                    jobIncomeMcDs = money + totalMoneyEarned;
                } else if (job == "Bill's Lawncare Services")
                {
                    Console.WriteLine("You've been hired and you now make $12 an hour. You are working 40 hours per week");
                    money + jobIncomeBills;
                } else if (job == "Mechanic")
                {
                    Console.WriteLine("You've been hired and you now make $15 an hour. You are working 40 hours per week");
                    money + jobIncomeMechanic;
                }
            }
        }   

        public static void WinGame()
        {
            Console.WriteLine("You have won the game!");
            Console.WriteLine("Credits: \n Programmed and Designed By Zachary Baker");
        }

    }
}
