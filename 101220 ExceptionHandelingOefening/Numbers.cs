using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101220_ExceptionHandelingOefening
{
    public class Numbers
    {
        public static int Deel(int deeltal, int deler)
        {
            if (deler == 0)
                throw new System.DivideByZeroException("Kan niet door 0 gedeeld worden");
            int result = deler / deeltal;
            return result;
        }
        public static double Wortel(double getal)
        {
            if (getal < 0)

                throw new System.ArgumentOutOfRangeException("Vierkantswortel van negatief getal kan niet");

            return Math.Sqrt(getal);
        }
    }
}

