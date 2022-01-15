using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countClient, countWay;
            countClient = 3;
            countWay = Factorial(countClient);
            Console.WriteLine(countWay);
            Console.ReadLine();
        }
        static int Factorial(int num)
        {
            if (num == 0) return 1;
            else return num * Factorial(--num);
        }
    }
}
