using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Enter your age");
             int age = int.Parse(Console.ReadLine());


             if (age >= 17)
             {
                 Console.WriteLine("You can see this movie");

             }
             else if (age == 16)
             {
                 Console.WriteLine("Let's get a drink.");
             }

             else
             {
                 Console.WriteLine("Sorry you are too young.  You need a parent present.");
             }

            Console.WriteLine("Enter your percentage");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("You got an A!!");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("You got a B!! Not bad.");
            }
            
            Console.WriteLine("How many diners were in your group?");
            int diners = int.Parse(Console.ReadLine());

            Console.WriteLine("What was your cost per diner?");
            double costPerDiner = double.Parse(Console.ReadLine());

           

            if (diners * costPerDiner >= 50)
            {
                Console.WriteLine("You received a 10% discount.  Your new total is $ " + diners * costPerDiner * .90);
            }
            else
            {
                
                Console.WriteLine("You received a 5% discount. Your new total is $ " + diners * costPerDiner * .95);
            }
             */

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >=0 && userAge<= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if(userAge >= 3 && userAge <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (userAge >= 5 && userAge <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (userAge >= 12 && userAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (userAge >= 15 && userAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (userAge >= 19 && userAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (userAge >= 23 && userAge <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (userAge >= 66 && userAge <= 100)
            {
                Console.WriteLine("Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans.");
            }






        }
    }
}
