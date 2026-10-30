using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic_7_Assignment___Lists //Maxym F.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Gen = new Random();

            string deleteVegString, searchVeg, addVeg;
            int deleteVegIndex;

            int choice, numberList, removeNum, addNum, vegChoice, numOccurences, target, startChoice, indexVeg;

            bool numberGen, menu, menuInterface, start, menuTwo, vegChoice2;

            numOccurences = 0;

            numberGen = false;
            menu = false;
            menuInterface = true;
            start = false;
            menuTwo = true;
            vegChoice2 = false;

            indexVeg = 0;


            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(Gen.Next(10, 21));
            }

            List<string> vegetables = new List<string>() { "CARROT", "BEET", "CELERY", "RADDISH", "CABBAGE" };

            



            //add initial menu to choose part 1 from part 2:
            while (!start)
            {



                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Lists of Integers");
                Console.WriteLine("2 - Vegetables");
                Console.WriteLine("3 - Quit");
                Int32.TryParse(Console.ReadLine(), out startChoice);

                if (startChoice == 1)
                {
                    menuInterface = false;
                }

                else if (startChoice == 2)
                {
                    menuTwo = false;
                }

                else if (startChoice == 3) 
                {
                    Console.Clear();
                    return;
                }





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
                            menuInterface = true;
                        }



                    }




                //Part 2:

                while (!menuTwo)
                {
                    Console.Clear();
                    Console.WriteLine("VEGETABLES:");
                    for (int i = 0; i < vegetables.Count; i++)
                        Console.WriteLine(i + "-" + vegetables[i] + " ");

                    Console.WriteLine();

                    Console.WriteLine("1 - Remove a vegetable by Index");
                    Console.WriteLine("2 - Remove a vegetable by value");
                    Console.WriteLine("3 - Search for a Vegetable");
                    Console.WriteLine("4 - Add a Vegetable");
                    Console.WriteLine("5 - Sort List");
                    Console.WriteLine("6 - Return");
                    Int32.TryParse(Console.ReadLine(), out vegChoice);

                    if (vegChoice == 1) 
                    {
                        Console.Clear();

                        Console.WriteLine("Remove an INDEX of your choice from the list of vegtables!");
                        Int32.TryParse(Console.ReadLine(), out deleteVegIndex);

                        if (deleteVegIndex <= vegetables.Count - 1)
                        {
                            vegetables.RemoveAt(deleteVegIndex);

                        }

                        else 
                        {
                            Console.WriteLine("INVALID");
                            Console.WriteLine("Press Anything To Continue.");
                            Console.ReadKey();
                        }

                    }

                    else if (vegChoice == 2) 
                    {

                        Console.Clear();

                        Console.WriteLine("What vegetable would you like to get rid of?");
                        deleteVegString = Console.ReadLine().ToUpper();

                        vegetables.Remove(deleteVegString);




                    }

                    else if (vegChoice == 3) //WIP
                    {
                        Console.Clear();
                        Console.WriteLine("Which vegetable are you looking for?");
                        searchVeg = Console.ReadLine().ToUpper();

                        

                        for (int i = 0; i <= vegetables.Count - 1; i++) 
                        {
                            if (vegetables[i] == searchVeg)
                            {
                                indexVeg = i;

                            }


                        }

                        if (vegetables.Contains(searchVeg))
                        {
                            Console.WriteLine($"{searchVeg} Exists At {indexVeg}.");
                            Console.WriteLine("Press Anything To Continue.");   
                        }

                        else 
                        {
                            Console.WriteLine($"{searchVeg} does not exist.");
                            Console.WriteLine("Press Anything To Continue.");

                        }

                        Console.ReadKey();

                    }

                    else if (vegChoice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("What vegetable would you like to add?");
                        addVeg = Console.ReadLine().ToUpper();

                        vegetables.Add(addVeg);
                    }

                    else if (vegChoice == 5)
                    {
                        Console.Clear();
                        vegetables.Sort();
                    }

                    else if (vegChoice == 6) 
                    {
                        Console.Clear();
                        menuTwo = true;
                    }


                }




            }
        }
    }
}
