using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void Calculate(double num1, double num2, double num3) 
        {
            foreach (double item in new double[3] { num1, num2, num3 })
            {
                Console.WriteLine(item/5);
            }
        }
    }
}
