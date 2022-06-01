using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num -DONE!
            int num;
            //initialize the variable with a value of 0 -DONE!
            num = 0;


            // Create a do-while loop and use the template below:-DONE!
            do
            {
                // Increment num by 1 -DONE!
                num++;
                // Then add num to the collection - numbers -DONE!
                numbers.Add(num);
                // Hint: reference num inside of the Add method's parentheses
                //numbers.Add(/* num */);

            } while (num < 100);// <---- While your variable is less than 100-DONE!



            // Create a while loop
            // <--- While num is less than 200-DONE!
            while (num<200)
            {
                // Increment num by 1-DONE!
                num++;
                // Then add num to the collection numbers -DONE!
                //HINT: copy how this was done in the do while loop
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers-DONE!
            foreach (int i in numbers)
            //In the scope of the foreach loop, print each number in numbers-DONE!
            {
                Console.WriteLine($"{i}");
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1-DONE!
            for (int i = 199; i<=numbers.Count&&i >= 0; i--)
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method-DONE!
                Console.WriteLine(numbers[i]);
            }

            //------------End of exercise
        }
    }
}
