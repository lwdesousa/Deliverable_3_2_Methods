/* Author:Leticia W. de Sousa
 * Date:02/04/2020
 * Description:
 */
    using System;

namespace Deliverable_3_2_Methods
{
    class Program
       
    {
        static void Main(string[] args)
        {
      
            try
            {
                //Ask the user to write a input (name)
                Console.WriteLine("Please,enter your name:");
                string userName = HelloName();

                //Show messsage to user
                Console.WriteLine("Hello " + userName + "!");
            }

                catch
            {
                //If error in the code, show the following message
                Console.WriteLine("An error was present in the code. Please try again. ");

            }
        }


        private static string HelloName()
        {
            string UserName = Console.ReadLine();
            return UserName;
        }
    }
}
