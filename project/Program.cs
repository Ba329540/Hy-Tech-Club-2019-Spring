using System;

namespace CSharp101ProjectZB
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            Console.WriteLine("In this game, you make important life decisions.");
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine("Enter your name:");
                string playerName = Console.ReadLine();
                Console.WriteLine("Hello " + playerName + "!");
                Console.WriteLine("You will start out with $100, which you can spend later on.");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("At various points throughout the game, you will be given a choice between a few things");

            }

            int freeMoney = 1000;
            Console.WriteLine("If you have a code, type it here: ");
            string secretCode = "freemoney";
            string codeInput = Console.ReadLine();
            if (codeInput == secretCode)
            {
                Console.WriteLine("You get $1000 added to your bank account!");
                int totalMoney = money + freeMoney;
            }
            else
            {
                Console.WriteLine("Error!");
            }

            //All variables relating to the direct gameplay will go below:

            int ageAfterLoop = 10;

            //Below is the incomes for one year
            int totalMoneyEarnedMcDs = 25000;
            int totalMoneyEarnedBills = 35000;
            int totalMoneyEarnedMechanic = 45000;
            //Below are the variables for College costs:
            int universityTuition = 50000;
            int comColTuition = 15000;
            int medSchoolTuition = 150000;
            //other vars:
            int moneyRemaining = 0;



            for (int age = 0; age <= 10; age++)
            {
                Console.WriteLine("You have aged 1 year and are now " + age + " years old.");
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine("You have a choice of the middle school you go to: (1)Go to public school, (2) go to private school.");
            int schoolChoice = Convert.ToInt32(Console.ReadLine());
            if (schoolChoice == 1)
            {
                Console.WriteLine("Welcome to Thomas Jefferson Junior High!");
            }
            else if (schoolChoice == 2)
            {
                Console.WriteLine("Welcome to Saint Peter Middle School!");
                ageAfterLoop++;
                Console.WriteLine(ageAfterLoop);
                System.Threading.Thread.Sleep(500);
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
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("You have decided to go to college and can choose from one of the three choices: \n University(1) \n Medical School(2) \n Community College(3).");
                int collegeToGoTo = Convert.ToInt32(Console.ReadLine());
                if (collegeToGoTo == 1)
                {
                    Console.WriteLine("You are going to University and must pay $50000.");
                    moneyRemaining = money - universityTuition;
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("You have " + moneyRemaining + " dollars left.");
                    UniversityJobs();
                }
                else if (collegeToGoTo == 2)
                {
                    Console.WriteLine("You are going to Medical School and must pay $150000.");
                    moneyRemaining = money - medSchoolTuition;
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("You have " + moneyRemaining + " dollars left.");
                    MedSchoolJobs();
                }
                else if (collegeToGoTo == 3)
                {
                    Console.WriteLine("You are going to Community College and must pay $15000.");
                    moneyRemaining = money - comColTuition;
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("You have " + moneyRemaining + " dollars left.");
                    ComColJobs();
                }
            }
            else if (collegeChoice == 2)
            {
                Console.WriteLine("You big loser, not going to college! Well, you decide to get a job instead.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("You can get a job at: (1)McDonalds (2)Bill's Lawncare (3)Mechanic");
                int job = Convert.ToInt32(Console.ReadLine());
                if (job == 1)
                {
                    Console.WriteLine("You've been hired an you now make $9 an hour. You are working 40 hours per week");
                    int jobIncomeMcDs = money + totalMoneyEarnedMcDs;
                    LoseGame();
                }
                else if (job == 2)
                {
                    Console.WriteLine("You've been hired and you now make $12 an hour. You are working 40 hours per week");
                    int jobIncomeBills = money + totalMoneyEarnedBills;
                    LoseGame();
                }
                else if (job == 3)
                {
                    Console.WriteLine("You've been hired and you now make $15 an hour. You are working 40 hours per week");
                    int jobIncomeMechanic = money + totalMoneyEarnedMechanic;
                    WinGame();
                }
            }
          //continue here:
          //continue here:  
        }

        public static void UniversityJobs()
        {
            int money = 100;
            //vars for university jobs go here:
            int developerIncome = 80000;
            int finAdIncome = 70000;
            int photoIncome = 55000;
            int mechEngIncome = 75000;

            Console.WriteLine("Congratulations! You have graduated University. You can pick any of the following jobs");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Software Developer(1) \n Financial Advisor(2) \n Photographer(3) \n Mechanical Engineer(4).");
            int universityJobs = Convert.ToInt32(Console.ReadLine());
            if (universityJobs == 1)
            {
                Console.WriteLine("You've been hired as a Software Developer and now make $80000 per year");
                int totalMoneyEarnedDeveloperIncome = money + developerIncome;
                WinGame();
            }
            else if (universityJobs == 2)
            {
                Console.WriteLine("You have landed a job at Baker's Small Business Solutions! You now make $85000 per year.");
                int totalMoneyEarnedFinAdIncome = money + finAdIncome;
                LoseGame();
            }
            else if (universityJobs == 3)
            {
                Console.WriteLine("You have landed a job at Reighloth photography! You now make $65000 per year.");
                int totalMoneyEarnedPhotoIncome = money + photoIncome;
                LoseGame();
            }
            else if (universityJobs == 4)
            {
                Console.WriteLine("You have landed a job at NASA as a mechanical engineer! You now make $110000 per year");
                int totalMoneyEarnedMechEngIncome = money + mechEngIncome;
                System.Threading.Thread.Sleep(1000);
                Mugged();
            }
        }

        public static void ComColJobs()
        {
            int money = 100;
            //vars for comColJobs go here:
            int artistIncome = 45000;
            int chefIncome = 65000;
            int interDesignerIncome = 55000;
            Console.WriteLine("Congratulations! You have graduated Community College. You can pick any of the following jobs:");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Artist(1) \n Chef(2) \n Interior Designer(3) ");
            int comColJobs = Convert.ToInt32(Console.ReadLine());
            if (comColJobs == 1)
            {
                Console.WriteLine("You have landed a job as an Artist! You now make $45000 per year.");
                int totalMoneyEarnedArtist = money + artistIncome;
                LoseGame();
            }
            else if (comColJobs == 2)
            {
                Console.WriteLine("You have landed a job at Chez Francois as a Sous Chef! You now make $65000 per year");
                int totalMoneyEarnedChef = money + chefIncome;
                System.Threading.Thread.Sleep(1000);
                Mugged();
            }
            else if (comColJobs == 3)
            {
                Console.WriteLine("You have landed a job as an Interior Designer! You now make $55000 per year");
                int totalMoneyEarnedInteriorDesigner = money + interDesignerIncome;
                LoseGame();
            }
        }

        public static void MedSchoolJobs()
        {
            int money = 100;
            //vars for medSchool go here:
            int surgeonIncome = 130000;
            int occTherapistIncome = 110000;
            int pediatricianIncome = 120000;
            Console.WriteLine("Congratulations! You have graduated from Medical School. You can pick any of the following jobs:");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Surgeon(1) \nOccupational Therapist(2) \nPediatrician(3).");
            int medSchoolJobs = Convert.ToInt32(Console.ReadLine());
            if (medSchoolJobs == 1)
            {
                Console.WriteLine("You have landed a job at Cleveland Clinic as a general surgeon! You now make $130000 per year.");
                int totalMoneyEarnedSurgeon = money + surgeonIncome;
                System.Threading.Thread.Sleep(1000);
                Mugged();
            }
            else if (medSchoolJobs == 2)
            {
                Console.WriteLine("You have landed a job at Orthopaedic Associates as an Occupational Therapist! You now make $110000 per year");
                int totalMoneyEarnedOccTherapist = money + occTherapistIncome;
                LoseGame();
            }
            else if (medSchoolJobs == 3)
            {
                Console.WriteLine("You have landed a job at UH as a Pediatrician! You now make $120000 per year");
                int totalMoneyEarnedPediat = money + pediatricianIncome;
                PlayFizzBuzz();
            }
        }

        public static void Mugged()
        {
            Console.WriteLine("You are walking along in Cleveland when a man runs up to you and demands that you hand over all your cash.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You decide to: (1)Do as he says, (2)Run away, (3)Pull your karate moves on him.");
            int muggedChoice = Convert.ToInt32(Console.ReadLine());
            if (muggedChoice == 1)
            {
                Console.WriteLine("You hand over all your money which is everything in your bank account, and he takes it and runs away.");
                LoseGame();
            }
            else if (muggedChoice == 2)
            {
                Console.WriteLine("You run away as fast as you can and you are shot in the back");
                LoseGame();
            }
            else if (muggedChoice == 3)
            {
                Console.WriteLine("You use your killer karate moves on him and knock him out");
                WinGame();
            }
        }

        public static void PlayFizzBuzz()
        {
          for (int z = 0; z <= 3; z++)
          {
          Console.WriteLine("Let's play FizzBuzz!");
          Console.WriteLine("Type in a number, any number!");
          int inputFB = Convert.ToInt32(Console.ReadLine());
          if (inputFB % 3 == 0 && inputFB % 5 == 0)
          {
            Console.WriteLine("FizzBuzz");
          } else if (inputFB % 3 == 0)
          {
            Console.WriteLine("Fizz");
          } else if (inputFB % 5 == 0)
          {
            Console.WriteLine("Buzz");
          } else {
            Console.WriteLine("How much wood could a woodchuck chuck if a woodchuck could chuck wood");
          }
          }
          WinGame();
        }

        public static void Robbed()
        {
          Console.WriteLine("One day you come home from work to find everything in your house is gone! \n what do you do?");
          Console.WriteLine("(1)Call 911; (2)Cry in despair; (3)Track down the robbers");
          int robbedChoice = Convert.ToInt32(Console.ReadLine());
          if (robbedChoice == 1)
          {
            Console.WriteLine("You decide to call 911.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You are put on hold and die of old age.");
            LoseGame();
          } else if (robbedChoice == 2)
          {
            Console.WriteLine("You begin crying in despair.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Oh, my xBox, oh, my cheerios!");
            LoseGame();
          } else if (robbedChoice == 3)
          {
            Console.WriteLine("You decide to try and track down the robbers.");
            Mugged();
          }
        }

        public static void WinGame()
        {
            Console.WriteLine("You have won the game!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Credits: \n Programmed and Designed By Zachary Baker");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("As this is a small project, I did not finish the game because coming up with a big storyline for the whole thing is difficult. I hope to finish it at some point.");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("The secret code is freemoney.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("To win and lose is very random by the way.");
        }

        public static void LoseGame()
        {
            Console.WriteLine("You have lost the game because you made a bad decision.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Cedits: \n Programmed and Designed by Zachary Baker");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("As this is a small project, I did not finish the game because coming up with a big storyline for the whole thing is exhausting. I hope to finish it at some point.");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("You are DEAD.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("To get the secret code, you must win the game");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("To win and lose is very random by the way.");
        }
    }
}
