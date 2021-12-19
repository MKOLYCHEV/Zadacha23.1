using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadacha23._1
{
    class Program
    {
        static int num = 0;
        static int factorialNum = 1;

        static void Main(string[] args)
        {
            Console.Write("Введите число для определения факториала: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (num <= 0)
            {
                Console.WriteLine("Ошибка! Число должно быть больше нуля.");
                Console.ReadKey();
                return;
            }
            else
            {
                FactorialAsync();
            }

            Console.WriteLine("Метод Main закончил работу.");
            Console.ReadKey();
        }
        static async Task FactorialAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= num; i++)
                {
                    factorialNum *= i;
                    Console.WriteLine($"Факториал числа {i} равен {factorialNum}.");
                    Thread.Sleep(100);
                }
            });
        }
    }
}
