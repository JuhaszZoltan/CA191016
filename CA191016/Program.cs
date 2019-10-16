using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191016
{
    class Program
    {
        static Random rnd = new Random();
        static int[] tomb;
        static void Main(string[] args)
        {
            Feltolt();
            Kiir();

            for (int i = 0; i < 200; i++)
            {
                //RandomSzin();
                //RandomHelyreIr();
                //RandomCharIr();
            }

            for (int i = 0; i < 10; i++)
            {
                //JelszoGen();
            }

            Osszekever("Zoli");
            RandomSzinuKarakterek("INFORMATIKA");

            Console.ReadKey();
        }

        private static void RandomSzinuKarakterek(string szo)
        {
            for (int i = 0; i < szo.Length; i++)
            {
                RandomSzin();
                Console.Write(szo[i]);
            }
        }

        private static void Osszekever(string szo)
        {
            char[] ct = szo.ToCharArray();

            for (int i = 0; i < ct.Length / 2; i++)
            {
                int p1 = rnd.Next(ct.Length);
                int p2 = rnd.Next(ct.Length);

                char s = ct[p1];
                ct[p1] = ct[p2];
                ct[p2] = s;
            }

            string szoveg = new String(ct);
            Console.WriteLine(szoveg);
        }

        private static void JelszoGen()
        {
            Console.Write("\n");
            for (int i = 0; i < 6; i++)
            {
                RandomCharIr();
            }
        }
        private static void RandomCharIr()
        {
            Console.Write((char)rnd.Next(65, 91));
        }
        private static void RandomSzin()
        {
            ConsoleColor[] cols = 
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Blue,
                ConsoleColor.Magenta
            };

            Console.ForegroundColor = cols[rnd.Next(cols.Length)];
        }
        private static void RandomHelyreIr()
        {
            Console.SetCursorPosition(
                rnd.Next(Console.WindowWidth),
                rnd.Next(Console.WindowHeight));
            Console.Write("*");
        }
        private static void Kiir()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
        private static void Feltolt()
        {
            tomb = new int[100];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(10, 100);
            }
        }
    }
}
