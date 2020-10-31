using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSC205_Math_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            // request user name, age and gender and save to variables for later use.
            Console.Write("Enter your Name: ");
            string userName = (Console.ReadLine());
            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int userAge);

            //instantiate the Student class and create a new instance of Student called student.
            Student student = new Student(userName, userAge);
            student.Gender = Gender.Female;
            StreamWriter output = new StreamWriter("output.txt");
            output.WriteLine(DateTime.Now);
            output.WriteLine($"Name: {student.Name}");
            output.WriteLine($"Age:  {student.Age}");
            output.Close();

            Console.Clear();

            Console.WriteLine($"Hello {student.Name}! Welcome to Math Mindset!");
            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine("===================");
            Console.WriteLine("A. Addition");
            Console.WriteLine("S. Subtraction");
            Console.WriteLine("M. Multiplication");
            Console.WriteLine("D. Division");
            Console.WriteLine("X. Exit the game");
            Console.WriteLine("===================");
            Console.Write("Enter letter choice from MENU: ");
            string useroption = Console.ReadLine();

            switch (useroption.ToUpper())
            {
                case "A":
                    AdditionEquationGenerator();
                    break;

                case "S":
                    SubtractionEquationGenerator();
                    break;

                case "M":
                    MultiplicationEquationGenerator();
                    break;

                case "D":
                    DivisionEquationGenerator();
                    break;

                case "X":
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }

        }
        public static void AdditionEquationGenerator()
        {
            Console.Write("Enter the upper range of integer for your addition equations: ");
            int.TryParse(Console.ReadLine(), out int upper);
            // Don't forget to add "using System.IO;" initializing new instance of streamwriter class and creating varialbe "output"
            StreamWriter output = new StreamWriter("output.txt", true);
            // initialize counters.
            int i = 0;
            int count = 0;

            // ask 20 questions.
            while (i < 20)
            {
                // randomly generate 2 int between 1 and "upper" called "a" and "b".
                var rand = new Random();
                var a = rand.Next(1, upper + 1);
                var b = rand.Next(1, upper + 1);

                // variable to hold corrct answer.
                int answer = 0;
                // Give the user different expressions based on the random values of "a" and "b".
                Console.Write($"{a} + {b}= ");
                // write above line to "output.txt" file.
                output.Write($"{a} + {b}= ");
                // store correct answer to "answer"
                answer = a + b;
                // convert user input to int and store in variable "userInput" 
                int.TryParse(Console.ReadLine(), out int userInput);
                output.WriteLine(userInput);
                // compare value in "userInput to value in "answer"
                if (userInput == answer)
                {
                    Console.WriteLine($"Congratulations!!! That is correct.");
                    output.WriteLine($"Congratulations!!! That is correct.");
                    count++;
                }
                else if (userInput != answer)
                {
                    Console.WriteLine("Sorry, That is not correct. Try again.");
                    output.WriteLine("Sorry, That is not correct.");
                    int.TryParse(Console.ReadLine(), out userInput);
                    if (userInput == answer)
                    {
                        Console.WriteLine($"Congratulations!!! That is correct.");
                    }
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine($"You answered {count} questions correctly.");
            output.WriteLine($"You answered {count} questions correctly.");
            output.Close();
        }

        public static void SubtractionEquationGenerator()
        {
            Console.Write("Enter the upper range of integer for your subtraction equations: ");
            int.TryParse(Console.ReadLine(), out int upper);
            // Don't forget to add "using System.IO;" initializing new instance of streamwriter class and creating varialbe "output"
            StreamWriter output = new StreamWriter("output.txt", true);
            // initialize counters.
            int i = 0;
            int count = 0;

            // ask 20 questions.
            while (i < 20)
            {
                // randomly generate 2 int between 1 and "upper" called "a" and "b".
                var rand = new Random();
                var a = rand.Next(1, upper + 1);
                var b = rand.Next(1, a + 1);

                // variable to hold corrct answer.
                int answer = 0;
                // Give the user different expressions based on the random values of "a" and "b".
                Console.Write($"{a} - {b}= ");
                // write above line to "output.txt" file.
                output.Write($"{a} - {b}= ");
                // store correct answer to "answer"
                answer = a - b;
                // convert user input to int and store in variable "userInput" 
                int.TryParse(Console.ReadLine(), out int userInput);
                output.WriteLine(userInput);
                // compare value in "userInput to value in "answer"
                if (userInput == answer)
                {
                    Console.WriteLine($"Congratulations!!! That is correct.");
                    output.WriteLine($"Congratulations!!! That is correct.");
                    count++;
                }
                else if (userInput != answer)
                {
                    Console.WriteLine("Sorry, That is not correct. Try again.");
                    output.WriteLine("Sorry, That is not correct.");
                    int.TryParse(Console.ReadLine(), out userInput);
                    if (userInput == answer)
                    {
                        Console.WriteLine($"Congratulations!!! That is correct.");
                    }
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine($"You answered {count} questions correctly.");
            output.WriteLine($"You answered {count} questions correctly.");
            output.Close();
        }

        public static void MultiplicationEquationGenerator()
        {
            Console.Write("Enter the upper range of integer for your multiplication equations: ");
            int.TryParse(Console.ReadLine(), out int upper);
            // Don't forget to add "using System.IO;" initializing new instance of streamwriter class and creating varialbe "output"
            StreamWriter output = new StreamWriter("output.txt", true);
            // initialize counters.
            int i = 0;
            int count = 0;

            // ask 20 questions.
            while (i < 20)
            {
                // randomly generate 2 int between 1 and "upper" called "a" and "b".
                var rand = new Random();
                var a = rand.Next(1, upper + 1);
                var b = rand.Next(1, upper + 1);

                // variable to hold corrct answer.
                int answer = 0;
                // Give the user different expressions based on the random values of "a" and "b".
                Console.Write($"{a} * {b}= ");
                // write above line to "output.txt" file.
                output.Write($"{a} * {b}= ");
                // store correct answer to "answer"
                answer = a * b;
                // convert user input to int and store in variable "userInput" 
                int.TryParse(Console.ReadLine(), out int userInput);
                output.WriteLine(userInput);
                // compare value in "userInput to value in "answer"
                if (userInput == answer)
                {
                    Console.WriteLine($"Congratulations!!! That is correct.");
                    output.WriteLine($"Congratulations!!! That is correct.");
                    count++;
                }
                else if (userInput != answer)
                {
                    Console.WriteLine("Sorry, That is not correct. Try again.");
                    output.WriteLine("Sorry, That is not correct.");
                    int.TryParse(Console.ReadLine(), out userInput);
                    if (userInput == answer)
                    {
                        Console.WriteLine($"Congratulations!!! That is correct.");
                    }
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine($"You answered {count} questions correctly.");
            output.WriteLine($"You answered {count} questions correctly.");
            output.Close();
        }

        public static void DivisionEquationGenerator()
        {
            Console.Write("Enter the upper range of integer for your Division equations: ");
            int.TryParse(Console.ReadLine(), out int upper);
            // Don't forget to add "using System.IO;" initializing new instance of streamwriter class and creating varialbe "output"
            StreamWriter output = new StreamWriter("output.txt", true);
            // initialize counters.
            int i = 0;
            int count = 0;

            // ask 20 questions.
            while (i < 20)
            {
                // randomly generate 2 int between 1 and "upper" called "a" and "b".
                var rand = new Random();
                var a = rand.Next(2, upper + 1);
                //add multiples of "a" to arraylist "multiplesOf"
                ArrayList multiplesOfa = new ArrayList();
                for(int x = 2; x <= a; x++)
                {
                    if(a % x == 0)
                    {
                        multiplesOfa.Add(x);
                    }
                }
                //randomly pick one of the multiples of "a" from the arraylist "multiplesOf"
                var rand2 = (rand.Next(0, multiplesOfa.Count-1));
                int b = Convert.ToInt32(multiplesOfa[rand2]);

                // variable to hold corrct answer.
                int answer = 0;
                // Give the user different expressions based on the random values of "a" and "b".
                Console.Write($"{a} / {b}= ");
                // write above line to "output.txt" file.
                output.Write($"{a} / {b}= ");
                // store correct answer to "answer"
                answer = a / b;
                // convert user input to int and store in variable "userInput" 
                int.TryParse(Console.ReadLine(), out int userInput);
                output.WriteLine(userInput);
                // compare value in "userInput to value in "answer"
                if (userInput == answer)
                {
                    Console.WriteLine($"Congratulations!!! That is correct.");
                    output.WriteLine($"Congratulations!!! That is correct.");
                    count++;
                }
                else if (userInput != answer)
                {
                    Console.WriteLine("Sorry, That is not correct. Try again.");
                    output.WriteLine("Sorry, That is not correct.");
                    int.TryParse(Console.ReadLine(), out userInput);
                    if (userInput == answer)
                    {
                        Console.WriteLine($"Congratulations!!! That is correct.");
                    }
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine($"You answered {count} questions correctly.");
            output.WriteLine($"You answered {count} questions correctly.");
            output.Close();
        }

    }
    //create enumeration for use with students gender.
    public enum Gender {Male, Female};

    // create a class called Student.
    public class Student
    {
        // create properties name, gender and age for student.       
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        // create a non-default (takes parameters) contructor to call when instantiating a class in main.
        public Student(string userName, int userAge)
        {
            Name = userName;
            Age = userAge;
        }

    }
}
