using System;
using System.Collections.Generic;

namespace Lab_9_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {//Lists of names, hometowns, favorite foods, and favorite movies
            List<string> names = new List<string>
            {
                "Adam", "Betty", "Charlie", "Debbie", "Evan"
            };
            List<string> hometowns = new List<string>
            {
                "Detroit, MI", "Toledo, OH", "Hong Kong, China", "New York, New York", "Columbus, OH"
            };
            List<string> favFoods = new List<string>
            {
                "pizza", "snickers", "dim Sum", "hamburgers", "pretzels"
            };
            List<string> favMovies = new List<string>
            {
                "Saving Private Ryan", "CLueless", "any Marvel movie!", "Inception", "Star Wars: A New Hope"
            };
            string homeFoodMovie = "";
            string userInputName = "";
            char userContinue = 'y';

            while (userContinue == 'y')
            {
                //prompting user to choose a name from list
                Console.WriteLine("Welcome to our C# class! Which student would you like to learn more about? (Enter a name from the list): \n");
                PrintNameList(names);
                Console.WriteLine("===============\n");
                userInputName = Console.ReadLine();
                //preventing blank entry
                if (string.IsNullOrEmpty(userInputName))
                {
                    Console.WriteLine("Empty entry. Please choose a name!");
                    userInputName = Console.ReadLine().ToLower();
                }

                //prompting user to choose a fact catagory about the student
                Console.WriteLine($"You have selected {userInputName}. What would you like to know about {userInputName}? (Enter: [hometown][favorite food][favorite movie]");
                homeFoodMovie = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(homeFoodMovie))
                {
                    Console.WriteLine("Empty entry. Please choose a student fact catagory");
                    homeFoodMovie = Console.ReadLine().ToLower();
                }
                //taking in name and fact catagory to return a statement
                AddStudentHomeFoodMovie(userInputName, homeFoodMovie);
                //user continue
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to pick another student? [y/n]");
                userContinue = char.Parse(Console.ReadLine().ToLower());
                //continue validation
                while (userContinue != 'y' && userContinue != 'n')
                {
                    Console.WriteLine("Please Enter a valid [y/n] response. Would you like to choose another name?");
                    userContinue = char.Parse(Console.ReadLine().ToLower());
                }

            }
            string userContinue2 = "y";
            //prompting user to add a student to the list
            while (userContinue2 == "y")
            {
                Console.WriteLine("Would you like to add a student to the list? [y/any other key to exit]");
                userContinue2 = Console.ReadLine().ToLower();

                if (userContinue2 != "y")
                {
                    Console.WriteLine("Goodbye!!!");
                    break;
                }
            //allowing student to enter student name and info to appropriate lists
                AddUserInputToList(names, "Enter a new student name: ");
                AddUserInputToList(hometowns, $"Where is their hometown?");
                AddUserInputToList(favFoods, "What is their favorite food?");
                AddUserInputToList(favMovies, "What is their favorite movie?");

                Console.WriteLine("Would you like to add another student? [y/n]");
                userContinue2 = Console.ReadLine();

                if (string.IsNullOrEmpty(userContinue2))
                {
                    Console.WriteLine("Empty entry. Please choose [y/n]");
                    userInputName = Console.ReadLine();
                }

                if (userContinue2 == "n")
                {
                    Console.WriteLine("Here's the final list! Goodbye!!!");
                    Console.WriteLine("======================================\n");
                    break;
                }
            }
            PrintFourLists(names, hometowns, favFoods, favMovies);
        }

        public static void AddStudentHomeFoodMovie(string name, string studentFacts)
        {
            
            if (name == "Adam" && studentFacts == "hometown")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Detroit, MI");
            }
            if (name == "Adam" && studentFacts == "favorite food")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Pizza.");
            }
            if (name == "Adam" && studentFacts == "favorite movie")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Saving Private Ryan.");
            }
            
            
            if (name == "Betty" && studentFacts == "hometown")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Toledo, OH.");
            }
            if (name == "Betty" && studentFacts == "favorite food")
            {
                Console.WriteLine($"{name}'s {studentFacts} is snickers.");
            }
            if (name == "Betty" && studentFacts == "favorite movie")
            {
                Console.WriteLine($"{name}'s {studentFacts} is clueless");
            }

            if (name == "Charlie" && studentFacts == "hometown")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Hong Kong, China.");
            }
            if (name == "Charlie" && studentFacts == "favorite food")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Dim Sum.");
            }
            if (name == "Charlie" && studentFacts == "favorite movie")
            {
                Console.WriteLine($"{name}'s {studentFacts} is any Marvel movie!");
            }

            if (name == "Debbie" && studentFacts == "hometown")
            {
                Console.WriteLine($"{name}'s {studentFacts} is New York, New York.");
            }
            if (name == "Debbie" && studentFacts == "favorite food")
            {
                Console.WriteLine($"{name}'s {studentFacts} is hamburgers.");
            }
            if (name == "Debbie" && studentFacts == "favorite movie")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Inception.");
            }
            
            if (name == "Evan" && studentFacts == "hometown")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Columbus, OH.");
            }
            if (name == "Evan" && studentFacts == "favorite food")
            {
                Console.WriteLine($"{name}'s {studentFacts} is pretzels.");
            }
            if (name == "Evan" && studentFacts == "favorite movie")
            {
                Console.WriteLine($"{name}'s {studentFacts} is Star Wars: A New Hope.");
            }

            

        }

        
        public static void PrintFourLists(List<string> list1, List<string> list2, List<string> list3, List<string> list4)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{list1[i]} - {list2[i]} - {list3[i]} - {list4[i]}");
            }
        }

        public static void PrintNameList(List<string> list1)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{list1[i]}");
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void AddUserInputToList(List<string> listOfStrings, string message)
        {
            string input = GetUserInput(message);
            listOfStrings.Add(input);
            //listOfStrings.Add(GetUserInput)(message));
        }
    }
}
