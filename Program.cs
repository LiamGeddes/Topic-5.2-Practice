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
            if (grade<=65)
                Console.WriteLine("That is a D!");
            if (grade <= 75)
                Console.WriteLine("That is a C!");
            if (grade <= 85)
                Console.WriteLine("That is a B!");
            else if (grade > 85)
                Console.WriteLine("That is a A!");



        }
    }
}
