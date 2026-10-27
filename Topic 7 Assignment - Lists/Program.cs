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

            string deleteVeg, searchVeg, addVeg;

            int choice, numberList, removeNum, addNum, vegChoice, numOccurences, target, startChoice;

            bool numberGen, menu, menuInterface, start;

            numOccurences = 0;

            numberGen = false;
            menu = false;
            menuInterface = false;
            start = false;


            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(Gen.Next(10, 21));
            }


            //add initial menu to choose part 1 from part 2:
            while (!start)
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Lists of Intigers");
                Console.WriteLine("2 - Vegetables");
                Int32.TryParse(Console.ReadLine(), out startChoice);

                if (startChoice == 1)
                {
                    menuInterface = false;
                }

                else if (startChoice == 2) 
                {
                    //make summ for part 2
                }


                    while (!menu)
                    {



                        //Part 1:
                        while (!menuInterface)
                        {



                            Console.WriteLine("Here are a list of numbers:");
                            Console.WriteLine();


                            for (int i = 0; i < numbers.Count; i++)
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

                            Console.WriteLine("9 - Exit");
                            Int32.TryParse(Console.ReadLine(), out choice);

                            Console.Clear();

                            if (choice == 1)
                            {
                                numbers.Sort();
                            }

                            else if (choice == 2)
                            {


                                numbers.Clear();
                                Console.WriteLine("Here are your new Numbers:");

                                for (int i = 0; i < 25; i++)
                                {
                                    numbers.Add(Gen.Next(10, 21));
                                }

                                Console.WriteLine();

                                menuInterface = false;

                            }

                            else if (choice == 3)
                            {
                                Console.WriteLine("Insert a Number To Be Removed");
                                Int32.TryParse(Console.ReadLine(), out removeNum);

                                for (int i = 0; i <= numbers.Count; i++)
                                {
                                    bool isRemoved = numbers.Remove(removeNum);
                                }
                            }

                            else if (choice == 4)
                            {
                                Console.WriteLine("What Number Do You Want To Add?");

                                if (Int32.TryParse(Console.ReadLine(), out addNum))
                                {
                                    numbers.Add(addNum);
                                }

                                Console.WriteLine();

                            }

                            else if (choice == 5)
                            {
                                Console.WriteLine("What number do you want to count its occurences?");

                                if (Int32.TryParse(Console.ReadLine(), out target))
                                {
                                    for (int i = 0; i < numbers.Count; i++)
                                    {
                                        if (numbers[i] == target)
                                        {
                                            numOccurences++;
                                        }

                                    }



                                    Console.WriteLine($"The number {target} appears {numOccurences} times.");

                                }



                            }

                            else if (choice == 6)
                            {
                                Console.WriteLine("The largest number in this list is: " + numbers.Max());
                                Console.WriteLine();
                            }

                            else if (choice == 7)
                            {


                                Console.WriteLine("The smallest number in this list is: " + numbers.Min());
                                Console.WriteLine();

                            }

                            else if (choice == 8)
                            {
                                Console.WriteLine("The average of this list is: " + numbers.Average());
                                Console.WriteLine("The sum of this list is: " + numbers.Sum());
                            }



                            else if (choice == 9)
                            {
                                return;
                            }






                        }

                        //Part 2:

                        Console.WriteLine("Choose a vegetable! [Input the Corrisponding Number]");
                        Console.WriteLine("1 - CARROT");
                        Console.WriteLine("2 - BEET");
                        Console.WriteLine("3 - CELERY");
                        Console.WriteLine("4 - RADISH");
                        Console.WriteLine("5 - CABBAGE");
                        Int32.TryParse(Console.ReadLine(), out vegChoice);

                        if (vegChoice == 1)
                        {

                        }

                        else if (vegChoice == 2)
                        {
                            Console.WriteLine("What vegetable would you like to get rid of?");
                            deleteVeg = Console.ReadLine().ToUpper();

                            Console.WriteLine($"Okay, you have chosen to get rid of {deleteVeg}.");
                        }

                        else if (vegChoice == 3)
                        {
                            Console.WriteLine("Which vegetable are you looking for?");
                            searchVeg = Console.ReadLine().ToUpper();

                            Console.WriteLine($"Alrighty, you chose {searchVeg}.");
                        }

                        else if (vegChoice == 4)
                        {
                            Console.WriteLine("What vegetable would you like to add?");
                            addVeg = Console.ReadLine().ToUpper();
                        }

                        else if (vegChoice == 5) //Sort List
                        {

                        }

                        else if (vegChoice == 6)
                        {
                            return;
                        }

                    }




            }
        }
    }
}
