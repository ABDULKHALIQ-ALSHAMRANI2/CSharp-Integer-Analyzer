using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingForArray_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool bIschek = true;
            do
            {
                Console.Clear();
                //Welcome.
                Console.WriteLine("=====================================");
                Console.WriteLine("   Universal Integer Analyzer Pro⚡  ");
                Console.WriteLine("=====================================");
                Console.WriteLine();

                //Definition Size of Array inside loop for try.
                int nArraySize = GetValidArraySize();

                //Definition of Array.
                int[] nArrayNumber = FillArrayWithNumbers(nArraySize);


                //Finding the largest number in the array using an iterative loop.
                AnalyzeAndPrintArray(nArrayNumber);

                //The user is asked whether they want to close or continue.
                Console.WriteLine("To continue, press (1).\nTo close, press (0).") ;
                int nCkek;
                while (!int.TryParse(Console.ReadLine(), out nCkek) || (nCkek != 0 && nCkek != 1))
                {
                    Console.WriteLine("❌ Incorrect entry.\nPlease try again. ( 1️ ) or ( 0️ )...") ;
                }
                if (nCkek == 0) 
                { 
                    bIschek=false;
                    Console.Clear();
                    Console.WriteLine("=====================================");
                    Console.WriteLine("    Thank you for using our app!     ");
                    Console.WriteLine("        👋 See you soon 👋          ");
                    Console.WriteLine("    Developed by: C# Fazza ++        ");
                    Console.WriteLine("=====================================");
                }
            } while (bIschek);

        }
        static int GetValidArraySize()
        {
            int nSizeArray = 0;

            Console.WriteLine("Please enter Size of Array:");
            while (!int.TryParse(Console.ReadLine(), out nSizeArray) || nSizeArray <= 0)
            {
                Console.WriteLine("❌ Incorrect entry.\nPlease enter a valid positive number:");
                
            }
            Console.WriteLine("   Integer value ✅");
            Console.WriteLine("------------------------");
            return nSizeArray;
        }
        static int[] FillArrayWithNumbers(int nSize)
        {
            Console.Clear();
            int[] nNumbers = new int[nSize];

            for (int i = 0; i < nSize; i++)
            {
                Console.WriteLine($"Please Enter A New Number ({i + 1}) :");
                while (!int.TryParse(Console.ReadLine(), out nNumbers[i]))
                {
                    Console.WriteLine("❌ Incorrect entry; it must be a valid number.");
                }
                Console.WriteLine("   Integer value ✅");
                Console.WriteLine("------------------------");
                
            }
            return nNumbers;
        }
        static void AnalyzeAndPrintArray(int[] numbers)
        {
            Console.Clear();
            Console.WriteLine("Results of the examination of even and odd numbers.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int nLargestNumber = numbers[0];
            int nSmallestNumber = numbers[0];
            int nSum = 0;
            int nEvenNumber = 0;
            int nOddNumber = 0;
            double nEven = 0;
            double nOdd = 0;
            foreach (int nForeach in numbers)
            {
                if (nForeach % 2 == 0)
                {
                    Console.WriteLine($"-> {nForeach} (Even number).");
                    nEvenNumber++;
                    nEven += nForeach;

                }
                else
                {
                    Console.WriteLine($"-> {nForeach} (Odd number).");
                    nOddNumber++;
                    nOdd += nForeach;

                }

                if (nForeach > nLargestNumber)
                {
                    nLargestNumber = nForeach;
                }
                if (nForeach < nSmallestNumber)
                {
                    nSmallestNumber = nForeach;
                }
                nSum += nForeach;
                Console.WriteLine("======================================");
            }
            //print the final result.
            Console.WriteLine("Results of adding even and odd numbers.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Sum of ( Even numbers ) ({nEvenNumber}) is = " + nEven);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Sum of ( Odd numbers ) ({nOddNumber}) is = " + nOdd);
            Console.WriteLine("======================================");
            Console.WriteLine("Result: Largest number and smallest number");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"The Largest Number is =  ({nLargestNumber})");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"The Smallest Number is = ({nSmallestNumber})");
            Console.WriteLine("======================================");
            Console.WriteLine("The result of adding all the numbers");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Net Algebraic Sum is  = ({nSum})");
            Console.WriteLine("======================================");
            
        }
    }
}
