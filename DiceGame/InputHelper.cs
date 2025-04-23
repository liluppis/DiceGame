using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    // static help-class to handle user input
    public static class InputHelper
    {
        // read string inputs
        public static string ReadString(string prompt)
        {
            Console.Write(prompt); // prints prompt
            return Console.ReadLine(); // reads user input
        }

        // read integer inputs
        public static int ReadInt(string prompt)
        {
            Console.Write(prompt); //  print prompt
            
            // loop to catch wrongful datatype input
            while(true)
            {
                // try to convert user input string to int 
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    return value; // return value if successfull
                }   
                    
                // if unsuccessfull -- print message and loop
                Console.Write("Invalid number, try again.");
                
            }

        }


    }
}
