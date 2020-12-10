using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101220_ExceptionHandelingOefening
{
    public class Numbers
    {
        private static int vorigeInput { get; set; }

        static Numbers()
        {
            vorigeInput = -1;
        }
        //public static int Deel(int deeltal, int deler)
        //{
        //    if (deler == 0)
        //        throw new System.DivideByZeroException("Kan niet door 0 gedeeld worden");
        //    int result = deler / deeltal;
        //    return result;
        //}
        //public static double Wortel(double getal)
        //{
        //    if (getal < 0)

        //        throw new System.ArgumentOutOfRangeException("Vierkantswortel van negatief getal kan niet");

        //    return Math.Sqrt(getal);
        //}

        public static int ReadNumber( int start, int end)
        {
            Console.WriteLine($"Geef 10 getallen tussen de grenzen: {start}-{end}  en oplopend"); 
            int input = 0;

            if (!Int32.TryParse(Console.ReadLine(), out input))

                throw new System.ArgumentException($"Input is not valid INT");

            if ((input < start || input > end))
                throw new System.ArgumentException($"Ligt niet binnen grenzen {start}-{end}");

            if (input <= vorigeInput)
            {
                throw new System.ArgumentException($"Input {input} moet groter zijn dan vorige input {vorigeInput}");
            }
            vorigeInput = input;
            return input;   
        }
    }
}

