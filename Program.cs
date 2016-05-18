using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', (n - (2 + (i * 2))) / 2));
                    Console.Write('*');
                    Console.Write(new string('-', (i * 2)));
                    Console.Write('*');
                    Console.Write(new string('-', (n - (2 + (i * 2))) / 2));
                    Console.WriteLine();
                }
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.Write(new string('-', ((2 + (i * 2))) / 2));
                    Console.Write('*');
                    Console.Write(new string('-', (n - (i * 2) - 4)));
                    Console.Write('*');
                    Console.Write(new string('-', ((2 + (i * 2))) / 2));
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', (n - (1 + (i * 2))) / 2));
                    if (i > 0)
                    {
                        Console.Write('*');
                        Console.Write(new string('-', i + (i - 1)));
                    }
                    Console.Write('*');
                    Console.Write(new string('-', (n - (1 + (i * 2))) / 2));
                    Console.WriteLine();
                }
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', i + 1));
                    Console.Write('*');
                    if (i < (((n - 1) / 2) - 1))
                    {
                        Console.Write(new string('-', (n - (i * 2) - 4)));
                        Console.Write('*');
                    }
                    Console.Write(new string('-', i + 1));
                    Console.WriteLine();
                }
            }
			
			Console.WriteLine("Change1");
			Console.WriteLine("Change online");
        }
    }
}
