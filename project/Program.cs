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

            Console.WriteLine("If you have a code, type it here: ")
            string codeInput = "freemoney";
            string secretCode = Console.ReadLine();
            
            //All variables relating to the direct gameplay will go below:
            int money = 100;
            int schoolChoice = Convert.ToInt32(Console.ReadLine());
            int ageAfterLoop = 10;
            string job = Console.ReadLine();
            //Below is the incomes for one year
            int totalMoneyEarnedMcDs = 25000;
            int totalMoneyEarnedBills = 35000;
            int totalMoneyEarnedMechanic = 45000;
            //Below are the variables for College costs:
            int universityTuition = 50000;
            int comColTuition = 15000;
            int medSchoolTuition = 150000;

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
                Console.WriteLine("You have decided to go to college and can choose from one of the three choices: \n University(1) \n Medical School(2) \n Community College(3).");
                int collegeToGoTo = Convert.ToInt32(Console.ReadLine());
                if (collegeToGoTo == 1)
                {
                    Console.WriteLine("You are going to University and must pay $50000.")
                    moneyRemaining = money - universityTuition;
                    UniversityJobs();
                } else if (collegeToGoTo == 2)
                {
                    Console.WriteLine("You are going to Medical School and must pay $150000.");
                    moneyRemaining = money - medSchoolTuition;
                    MedSchoolJobs();
                } else if (collegeToGoTo == 3)
                {
                    Console.WriteLine("You are going to Community College and must pay $15000.");
                    moneyRemaining = money - comColTuition
                    ComColJobs();
                }
            } else if (collegeChoice == 2)
            {
                Console.WriteLine("You big loser, not going to college! Well, you decide to get a job instead.");
                if (job == "McDonalds")
                {
                    Console.WriteLine("You've been hired an you now make $9 an hour. You are working 40 hours per week");
                    jobIncomeMcDs = money + totalMoneyEarnedMcDs;
                } else if (job == "Bill's Lawncare Services")
                {
                    Console.WriteLine("You've been hired and you now make $12 an hour. You are working 40 hours per week");
                    jobIncomeBills = money + totalMoneyEarnedBills;
                } else if (job == "Mechanic")
                {
                    Console.WriteLine("You've been hired and you now make $15 an hour. You are working 40 hours per week");
                    jobIncomeMechanic = money + totalMoneyEarnedMechanic;
                }
            }
        }

        public static void UniversityJobs()
        {
            Console.WriteLine("Congratulations! You have graduated University. You can pick any of the following jobs");
            Console.WriteLine("Software Developer(1) \n Financial Advisor(2) \n Photographer(3) \n Mechanical Engineer(4).");
            if (universityJobs == 1)
            {
                Console.WriteLine("");
                //math here
                // get vars for the below functions
            } else if (universityJobs == 2)
            {
                Console.WriteLine("You have landed a job at Baker's Small Business Solutions! You now make $85000 per year.");
                //math here
            } else if (universityJobs == 3)
            {
                Console.WriteLine("You have landed a job at Reighloth photography! You now make $65000 per year.");
                //math here
            } else if (universityJobs == 4)
            {
                Console.WriteLine("You have landed a job at NASA as a mechanical engineer! You now make $110000 per year");
                //math here
            }
        } 

        public static void ComColJobs() 
        {
            Console.WriteLine("Congratulations! You have graduated Community College. You can pick any of the following jobs:");
            Console.WriteLine("Artist(1) \n Chef(2) \n Interior Designer(3) ");
            if (comColJobs == 1)
            {
                Console.WriteLine("You have landed a job as an Artist! You now make $45000 per year.");
                //math here
                //get vars for these
            } else if (comColJobs == 2)
            {
                Console.WriteLine("You have landed a job at Chez Francois as a Sous Chef! You now make $65000 per year");
                //math here
            } else if (comColJobs == 3)
            {
                Console.WriteLine("You have landed a job as an Interior Designer! You now make $55000 per year");
                //math here
            }
        }

        public static void MedSchoolJobs()
        {
            Console.WriteLine("Congratulations! You have graduated from Medical School. You can pick any of the following jobs:");
            Console.WriteLine("Surgeon(1) \n Occupational Therapist(2) \n Pediatrician(3).");
            if (medSchoolJobs == 1)
            {
                Console.WriteLine("You have landed a job at Cleveland Clinic as a general surgeon! You now make $130000 per year.");
                //math here
                //get vars for these
            } else if (medSchoolJobs == 2)
            {
                Console.WriteLine("You have landed a job at Orthopaedic Associates as an Occupational Therapist! You now make $110000 per year");
                //math here
            } else if (medSchoolJobs == 3)
            {
                Console.WriteLine("You have landed a job at UH as a Pediatrician! You now make $120000 per year");
                //math here
            }
        }

        public static void Mugged()
        {
            Console.WriteLine("You are walking along in Cleveland when a man runs up to you and demands that you hand over all your cash.");
            Console.WriteLine("You decide to: (1)Do as he says, (2)Run away, (3)Pull your karate moves on him.");
            int muggedChoice = Covert.ToInt32(Console.ReadLine());
            if (muggedChoice == 1)
            {
                Console.WriteLine("You hand over all your money which is everything in your bank account, and he takes it and runs away.");
                LoseGame();
            } else if (muggedChoice == 2)
            {
                Console.WriteLine("You run away as fast as you can and you are shot in the back");
                LoseGame();
            }
        }

        public static void WinGame()
        {
            Console.WriteLine("You have won the game!");
            Console.WriteLine("Credits: \n Programmed and Designed By Zachary Baker");
            Console.WriteLine("As this is a small project, I did not finish the game because coming up with a big storyline for the whole thing is exhausting. I hope to finish it at some point.");
            Console.WriteLine("The secret code is freemoney.");
        }

        public static void LoseGame()
        {
            Console.WriteLine("You have lost the game because you made a bad decision.");
            Console.WriteLine("Cedits: \n Programmed and Designed by Zachary Baker");
            Console.WriteLine("As this is a small project, I did not finish the game because coming up with a big storyline for the whole thing is exhausting. I hope to finish it at some point.");
            Console.WriteLine("You are DEAD.");
            Console.WriteLine("The secret code is freemoney.");
        }
    }
}
