using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_7_Assignment___Lists //Maxym F.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Gen = new Random();
            int ranNum;
            ranNum = Gen.Next(0, 101);

            int[] numbers = new int[25];
            numbers[0] = ranNum;



            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Gen.Next(10, 21);

            Console.WriteLine("Here are a list of numbers:");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ", "); //Was : ("Item number " + i + ": " + numbers[i]);

            
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



        }
    }
}
