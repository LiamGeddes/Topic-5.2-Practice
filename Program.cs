using System.ComponentModel.Design;

namespace Topic_5._2_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int grade;
            Console.WriteLine("What's was your grade?");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
                Console.WriteLine("You Passed!");
            else
                Console.WriteLine("Better luck next time");

            Console.WriteLine("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 16)
                {
                    Console.WriteLine("The roads are not safe!");
                }
                else
                {
                    Console.WriteLine("I can drive without fear!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade < 50)
                Console.WriteLine("That is an F!");
            if (grade <= 65)
                Console.WriteLine("That is a D!");
            if (grade <= 75)
                Console.WriteLine("That is a C!");
            if (grade <= 85)
                Console.WriteLine("That is a B!");
            else if (grade > 85)
                Console.WriteLine("That is a A!");


            //task 2
            double tempature;

            Console.Write("\nEnter the tempature of water in celsius: ");
            double.TryParse(Console.ReadLine(), out tempature);
            if (tempature <= 0)
            {
                Console.WriteLine("The water is a solid.");
            }
            else if (tempature < 100)
            {
                Console.WriteLine("The water is a liquid.");
            }
            else
            {
                Console.WriteLine("The water is a gas");
            }
            Console.ReadLine();
            // task 2
            string answer;
            Console.WriteLine("\nWhat is the largest planet in our solar system?");
            Console.WriteLine("A. Earth");
            Console.WriteLine("B. Mars");
            Console.WriteLine("C. Jupiter");
            Console.WriteLine("D. Venus");

            Console.WriteLine("Enter your answer: ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "c")
            {
                Console.WriteLine("Correct!");
            }
            else if (answer.ToLower() == "a")
            {
                Console.WriteLine("Incorrect. Earth is not the largest planet.");
            }
            else if (answer.ToLower() == "b")
            {
                Console.WriteLine("Incorrect. Mars is not the largest planet.");
            }
            else if (answer.ToLower() == "d")
            {
                Console.WriteLine("Incorrect. Venus is not the largest planet.");
            }
            else
            {
                Console.WriteLine("That is not a valid choice.");
            }

            string name;

            Console.WriteLine("Hey, what's your name? ");
            name = Console.ReadLine();

            Console.Write("Ok, " + name + ", how old are you?");
            int.TryParse(Console.ReadLine(), out age);

            if (age < 0)
            {
                Console.WriteLine("That is not a valid age.");
            }
            else if (age < 16)
            {
                Console.WriteLine("You can't drive, " + name + ".");
            }
            else if (age < 18)
            {
                Console.WriteLine("You can drive but can't vote, " + name + ".");
            }
            else if (age < 25)
            {
                Console.WriteLine("You can vote but not rent a car, " + name + ".");
            }
            else
            {
                Console.WriteLine("You can do pretty much anything, " + name + ".");
            }


        }
    }
}
