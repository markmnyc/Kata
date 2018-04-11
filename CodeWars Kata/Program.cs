using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BinaryArray = { 1, 0, 0, 1 };
            double num1 = (BinaryArray[0] * Math.Pow(2, 3));
            double num2 = (BinaryArray[1] * Math.Pow(2, 2));
            double num3 = (BinaryArray[2] * Math.Pow(2, 1));
            double num4 = (BinaryArray[3] * Math.Pow(2, 0));

            int amount = Convert.ToInt32(num1) + Convert.ToInt32(num2) + Convert.ToInt32(num3) + Convert.ToInt32(num4);

            Console.WriteLine(amount.ToString());
            Console.ReadLine();
        }
    }
}
