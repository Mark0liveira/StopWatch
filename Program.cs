using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Digite sua unidade de medida:");
            Console.WriteLine("Use 's' para segundo => 30s");
            Console.WriteLine("Use 'm' para minuto => 2m");

            string value = Console.ReadLine().ToLower();

            int time = int.Parse(value.Substring(0, value.Length - 1));
            char unidade = char.Parse(value.Substring(value.Length - 1, 1));

            int multiple = 1;

            if (unidade == 'm')
            {
                multiple = 60;
            }

            PreStart(time * multiple);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("PREPARAR");
            Thread.Sleep(1000);
            Console.WriteLine("APONTAR");
            Thread.Sleep(1000);
            Console.WriteLine("ATIRAR");
            Thread.Sleep(1000);

            Count(time);
        }

        static void Count(int time)
        {
            Console.Clear();
            var count = 0;

            // Increment
            while (count != time)
            {
                count++;
                Console.WriteLine(count);
                Thread.Sleep(1000);
            }

            // Decrement
            // while (time != count)
            // {
            //     Console.WriteLine(time);
            //     time--;
            //     Thread.Sleep(1000);
            // }

            Console.WriteLine("STOP!");
            Thread.Sleep(1000);
            Sair();
        }

        static void Sair()
        {
            System.Environment.Exit(0);
        }
    }
}
