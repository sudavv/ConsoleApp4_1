using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int num = 0;            

            Console.WriteLine("Введите положительное целое число");
            string str_num = Console.ReadLine();

            try
            {
                if (str_num[0] == '-')
                {
                    Console.WriteLine("Число не может начинаться с нуля");
                    Console.WriteLine("");
                    Run();
                    Environment.Exit(0);
                }
                num = (2*Convert.ToInt32(str_num)-1);
            }
            catch
            {
                Console.WriteLine("Неверный формат введённого значения");
                Console.WriteLine("");
                Run();
                Environment.Exit(0);
            }

            int sqr = 0;
            for (int i=1; i<=num; i+=2)
            {
                sqr += i;
                Console.WriteLine("Квадрат " + ((i/2)+1) + ": " + sqr);
            }
            Console.WriteLine("");
            Run();
            Environment.Exit(0);
        }
    }
}
