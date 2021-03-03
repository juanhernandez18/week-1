using System;

namespace FizzBuzz //scope
{
    //class(reference type), struct(value type), interfaces(reference type), enum(value type)

    internal class StartingPoint //interal, public within the name space
    {
        //a user should be able to enter the starting and ending count
        //a user should be able to enter these values in any order
        //a user should be able to get the number of times fizz, buzz and fizzbuzz appear
        //a user should be able to set new values for fizz, buzz and fizzbuzz

        static void Main()
        {
            var startCount = 0;
            var endCount = 0;

            var firstCheck = 0;
            var secondCheck = 0;

            var temp = 0;

            var fizzCount = 0;
            var buzzCount = 0;
            var fizzBuzzCount = 0;

            var fizz = "fizz";
            var buzz = "buzz";


            Console.Write("Enter a Starting Number: ");
            startCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Ending Number: ");
            endCount = Convert.ToInt32(Console.ReadLine());

            if (startCount >= endCount)
            {
                //str 20
                //end 10
                temp = startCount; //20
                startCount = endCount; //10
                endCount = temp;
            }

            Console.Write("Set a value for fizz: ");
            firstCheck = Convert.ToInt32(Console.ReadLine());

            Console.Write("Set a value for buzz: ");
            secondCheck = Convert.ToInt32(Console.ReadLine());

            for (; startCount <= endCount; startCount += 1)
            {
                if ((startCount / firstCheck) * firstCheck == startCount && (startCount / secondCheck) * secondCheck == startCount)
                {
                    Console.WriteLine(fizz + buzz);
                    fizzBuzzCount += 1;
                }
                else if ((startCount / firstCheck) * firstCheck == startCount)
                {
                    Console.WriteLine(fizz);
                    fizzCount += 1;
                }
                else if ((startCount / secondCheck) * secondCheck == startCount)
                {
                    Console.WriteLine(buzz);
                    buzzCount += 1;
                }
                else
                {
                    Console.WriteLine(startCount);
                }
            }

            Console.WriteLine("\nfizz appeared: " + fizzCount);
            Console.WriteLine("buzz appeared: " + buzzCount);
            Console.WriteLine("fizzbuzz appeared: " + fizzBuzzCount);

            return;
        }

        private int GetInput()
        {
            var input = Console.ReadLine();

        }

    }
}