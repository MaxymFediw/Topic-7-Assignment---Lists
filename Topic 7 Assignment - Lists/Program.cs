using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Topic_7_Assignment___Lists //Maxym F.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Gen = new Random();
            
            int choice;

            bool numberGen, menu;



            numberGen = false;
            menu = false;
           

            int[] numbers = new int[25];





            while (!menu) 
            {

                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = Gen.Next(10, 21);

                Console.WriteLine("Here are a list of numbers:");
                Console.WriteLine();

                for (int i = 0; i < numbers.Length; i++)
                    Console.Write(numbers[i] + " ");

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("What would you like to do? [Select the Number]");
                Console.WriteLine();
                Console.WriteLine("1 - Sort The List");
                Console.WriteLine("2 - New List of Numbers");
                Console.WriteLine("3 - Remove a Number");
                Console.WriteLine("4 - Add a Value To The List");
                Console.WriteLine("5 - How Mnay Times A Number Appears");
                Console.WriteLine("6 - Print Largest Value");
                Console.WriteLine("7 - Print Smallest Value");
                Console.WriteLine("8 - Sum And Average of List");
                Console.WriteLine("9 - Most Frequent Value(s)"); //Dont need to do 8 AND 9 - Can jst do 1.
                Console.WriteLine("10 - Exit");
                Int32.TryParse(Console.ReadLine(), out choice);

                Console.Clear();

                if (choice == 1) 
                {
                    
                }

                else if (choice == 2)
                {

                }

                else if (choice == 3)
                {

                }

                else if (choice == 4)
                {

                }

                else if (choice == 5)
                {

                }

                else if (choice == 6)
                {

                }

                else if (choice == 7)
                {

                }

                else if (choice == 8)
                {

                }

                else if (choice == 9)
                {

                }

                else if (choice == 10)
                {
                    
                }







            }
            



        }
    }
}
