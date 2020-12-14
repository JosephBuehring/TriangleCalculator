using System;
using System.Reflection.Metadata.Ecma335;

namespace Buehring_Week03Homework_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {   //My group that helped with my assignment is myself (Joseph Buehring), Hayden Jones, and Vince Cabahug
            //This section is all purely cosmetic
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========================================");
            Console.WriteLine("This is your Triangle Test Software Program");
            Console.WriteLine("===========================================");
            Console.WriteLine(@"
 /_______________/\
 \ \            / /
  \ \    ______/_/_______
   \ \  /\______________/\
 ___\ \_\_\__/ /_      / /
/\___\ \____/ /__\    / /
\ \   \ \ \ \/ / /   / /
 \ \   \ \/\ \/ /   / /
  \ \   \/_/\/ /   / /
   \ \      / /\  / /
    \ \    / /\ \/ /
     \ \  / /  \_\/
      \ \/ /
       \/_/");
            Console.WriteLine("");
            //This portion continues and is purely cosmetic
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            //Here the program explains the purpose of the application
            Console.WriteLine("This program will take the lengths of 3 sides and determine if they can form a triangle.");
            Console.WriteLine("");
            //Program prompts the user to enter side length in inches
            Console.WriteLine("Please enter the length of the first side in inches  ");
            //Here is where I converted the string variable from Console.ReadLine to an integer variable so it would read the input as an integer
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            //The same prompts continue with the variable conversion until the final prompt of the application
            Console.WriteLine("Please enter the length of the second side in inches");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter the length of the third side in inches");
            int side3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //Here I set the "IsTraingle" method to a bool value so I could use an if statement to provide a different output depending on whether the statement was true or false.
            bool value = IsTriangle(side1, side2, side3);

            //Here the output diplsays based on whether or not the method's equation is satisfied
            if (value == true)
                Console.WriteLine("VALID. The length of these sides can form a triangle");
            else
                Console.WriteLine("INVALID. These side lengths are incorrect and cannot form a triangle.");
        }

        //Here is the method I used to create an array of the triangle sides as variables in order to fit them into my equation as one variable; therefore allowing the equation to consider each side in relation to the other two
        static bool IsTriangle(int side1, int side2, int side3) 
        {

            int[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            if (sides[2] > sides[0] + sides[1])
                return true;
            return false;



        }
    }
}
