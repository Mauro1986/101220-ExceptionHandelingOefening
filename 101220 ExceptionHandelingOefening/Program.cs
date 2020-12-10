using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101220_ExceptionHandelingOefening
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] input = new int[10];

            try
            {
                //Console.WriteLine("\nGeef getal om Vierkantswortel te berekenen: ");
                //int getalC = Convert.ToInt32(Console.ReadLine());
                //Numbers.Wortel(getalC);

                //Console.WriteLine("Geef deeltal: ");
                //int getalA = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Geef deler: ");
                //int getalB = Convert.ToInt32(Console.ReadLine());
                //Numbers.Deel(getalA, getalB);
                //Console.WriteLine(Numbers.Deel(getalA, getalB));

                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Numbers.ReadNumber(0, 100);
                }
            }

            //catch (ArgumentOutOfRangeException ExCannotBeZero)
            //{
            //    Console.Error.WriteLine("Error: " + ExCannotBeZero.Message);
            //    throw;
            //}
            //catch (DivideByZeroException ExNotDividedByZero)
            //{
            //    Console.Error.WriteLine("Error:" + ExNotDividedByZero.Message);
            //    throw;
            //}
            catch (ArgumentException)
            {
                throw;
            }
            finally
            {
                foreach (var item in input)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}



