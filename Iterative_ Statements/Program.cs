/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of iterative statements after getting input from users. 
*/
using System;
using System.Data.SqlTypes;
using System.Security;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("Enter an Integar value between 1 and 25 to excute an interative statement: ");
            try

            {
                // this variable will gather data from user input 
                String input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is pursed as an integer 
                int value_of_input = int.Parse(input);
                /*
                 This conditional If/Else Statement is used to text the values of the user input between 1 and 25 a different type of iterative statement will excute.
                */
                // If the value of user input is between 1 and 25 excute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop! ");
                    Console.Write("You have entered " + value_of_input.ToString() + " Time.");
                    // Here is the For Loop 
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + " This is the current integar value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and wait for the user to press a key to end the program
                    Console.ReadKey(true);

                }

                // If the user does not enter a value between 1 and 25, display a message
                else
                {
                    Console.WriteLine(" Please enter an integer between 1 and 20 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }//End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }// End of catch 
        }// End of Main 
    }// End of Class 
}// End of namesplace 







