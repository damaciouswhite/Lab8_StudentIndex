using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput = int.Parse(userInputString) - 1;
            string[,] studentInfo = new string[19, 3]
            {

                {"Andrea","Detroit","Pasta"},
                {"Anthony","Grand Rapids","Pizza"},
                {"Brian","Wyoming","Chicken"},
                {"Camille","Gun Lake","Chicken Wings"},
                {"Clayton","Southfield","Pancakes"},
                {"Damacious","Detroit","Chicken Alfredo"},
                {"David","Royal Oak","Tacos"},
                {"Evan","Oak Park","Eggs"},
                {"Heather","Clawson","Waffles"},
                {"Jacky","West Bloomfield","Oatmeal"},
                {"Johnathan","Bloomfield Hills","Steak"},
                {"Katie","Pontiac","Salsbury Steak"},
                {"Levi","Wayland","Potatoes"},
                {"Mauricio","Benton Harbor","Cake"},
                {"Nicholas","Lansing","Pie"},
                {"Rudy","Clarkston","Bananas"},
                {"Sean.O","Flint","Oranges"},
                {"Steve","Highland Park","McDonalds"},
                {"Ty","Hazel Park","Checkers"},
             };

            Console.WriteLine("Lab 8");
            Console.WriteLine("Welcome to our C# class! ");


            for (int i = 0; i == 0;)
            {
                Console.WriteLine("Which student would you want to leanrn about? Please enter a number between 1-19");

                string userInputString = Console.ReadLine();

                try
                {
                    StudentInfo(userInputString);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please use the proper format");
                }


                Console.WriteLine(studentInfo[userInput, 0]);

                Console.WriteLine("What would you like to know about {0}? Enter (hometown) or (favorite food).", userInput);
                for (int j = 0; j == 0;)
                {

                    string factChoice = Console.ReadLine().ToLower();
                    if (factChoice == "hometown")
                    {
                        Console.WriteLine(studentInfo[userInput, 1]);
                        j++;
                    }
                    else if (factChoice == "favorite food" || factChoice == "favoritefood")
                    {
                        Console.WriteLine(studentInfo[userInput, 2]);
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again. Enter (hometown) or (favorite food).");
                    }


                    Console.WriteLine("Would you like to know more? y/n");
                    string choice = Console.ReadLine().ToLower();
                    for (int j = 0; j == 0;)
                    {

                        if (choice == "n")
                        {
                            i++;
                            j++;
                        }
                        else if (choice == "y")
                        {
                            j++;
                        }
                        else if (choice != "n" && choice != "y")
                        {
                            Console.WriteLine("Please enter y or n");
                            choice = Console.ReadLine().ToLower();
                        }
                    }
                }

            }
        }
    }
}
        
    
