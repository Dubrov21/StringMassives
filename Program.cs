using System;

namespace StringMassives
{
    static class Program
    {
        static string[] array(string[] stringMassive)
        {
            for(int i=0; i < stringMassive.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of massive");
                stringMassive[i] = Console.ReadLine();
            }
            return stringMassive;
        }

        static string[] symbol(string[] symbolsMassive)
        {
            int p = 0;
            for(int i = 0; i < symbolsMassive.Length; i++)
            {
                if (symbolsMassive[i].Length <= 3)
                    p++;
            }
            string[] rezult = new string[p];
            int a = 0;
            for (int i = 0; i < symbolsMassive.Length; i++)
            {
                if (symbolsMassive[i].Length <= 3)
                {
                    rezult[a] = symbolsMassive[i];
                    a++;
                }
            }
            return rezult;
        }

        static void printMassive(string[] stringMassive)
        {
            Console.Write("[");
            for(int i = 0; i < stringMassive.Length; i++)
            {
                Console.Write($"'{stringMassive[i]}'");
            }
            Console.Write("]");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter massive elements number");
            int elements = Convert.ToInt32(Console.ReadLine());
            string[] stringMassive = new string[elements];
            string[] Massive = array(stringMassive);
            printMassive(symbol(Massive));
        }
    }
}
