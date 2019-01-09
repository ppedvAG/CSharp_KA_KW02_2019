using System;
using System.Diagnostics;

namespace HalloMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Zeige("Start");

            SagHallo();
            string msg = "Lecker Schnitzel!";
            Zeige(msg);
            Zeige(Verdoppeln(Verdoppeln(Verdoppeln(Verdoppeln(698)))));

            long zahl = GiveMeFive();

            Console.WriteLine();
            Console.ReadKey();
        }

        static void SagHallo()
        {
            Zeige("Hallo");
        }

        static void Zeige(string txt)
        {
            Console.WriteLine($"[{DateTime.Now}]{txt}");
            Debug.WriteLine($"DEBUG {txt}");
        }

        static void Zeige(int zahl)
        {
            Console.WriteLine($"Zahl: {zahl}");
        }
        static void Zeige(int zahl1, int zahl2)
        {
            Console.WriteLine($"Zahlen: {zahl1} & {zahl2} ");
            return;
            Console.WriteLine("rekjng");
        }

        static long GiveMeFive()
        {
            return 5;
            Console.WriteLine("krejngjk");
        }

        static int Verdoppeln(int zahl)
        {
            return zahl * 2;
        }
    }
}
