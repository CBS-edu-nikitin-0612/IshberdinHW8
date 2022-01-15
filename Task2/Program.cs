using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountPayments;
            Console.WriteLine("Введите сумму платежей: ");
            amountPayments = Convert.ToDouble(Console.ReadLine());
            ShowInfoCredit(amountPayments);
            Console.ReadLine();

            static void ShowInfoCredit(double amountPayments)
            {
                int countPayments = 7;
                double montlyPayment = 100, sumCredit, balace;
                sumCredit = countPayments * montlyPayment;
                balace =  amountPayments- sumCredit;
                Console.WriteLine($"Сумма задолженности: {(balace < 0 ? -balace : "задолженость отсутсвует")}\n" +
                    $"Сумма переплаты: {(balace > 0 ? balace : "переплата отсутсвует")}\n" +
                    $"{(balace < 0 ? "Есть долг" : "Долг отсутсвует")}");
            }
        }
    }
}
