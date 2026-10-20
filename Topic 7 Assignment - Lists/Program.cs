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

            int[] numbers = new int[31];
            numbers[0] = ranNum;



            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Gen.Next(1, 101);

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("Item number " + i + ": " + numbers[i]);

        }
    }
}
