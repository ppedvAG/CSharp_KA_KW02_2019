using System;
using System.Collections.Generic;
using System.Text;


namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt");

            char buchstabe = 'b';
            string text = "Viel Text";

            byte einbyte = 255;
            sbyte byteMitVorzeichen = -128;

            short kleineZahl = -32000;
            ushort kleineZahlOhneVorzeichen = 65000;

            int zahl = 7437347;
            uint großerInt = 428843834;

            ulong großeZahl = 18446744073709551615;

            float kommaZahl = 1.45744f;

            double bessereKommaZahl = 1.484746262634;

            decimal besteKommaZahl = 1.37576473833435345m;

            bool einBool = !true | !!false;

            zahl = zahl + 6;
            zahl += 6;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Console.BackgroundColor.ToString());
            Console.WriteLine("Wert " + besteKommaZahl + " Einheit");
            Console.WriteLine(string.Format("Wert {0:C} Einheit {1}", besteKommaZahl, zahl));
            Console.WriteLine($"Wert {besteKommaZahl:C} Einheit {zahl}");

            double einDouble = zahl;
            einDouble = 2.5;
            int einfacheZahl = (int)einDouble; //explizites casting
            Console.WriteLine(einfacheZahl);

            Console.WriteLine("Gibt mir eine Zahl:");
            string eingabe = Console.ReadLine();
            //int eingabeAlsZahl = int.Parse(eingabe);

            if (int.TryParse(eingabe, out int eingabeAlsZahl))
            {
                Console.WriteLine($"Das doppelte ist: {eingabeAlsZahl * 2}");
            }
            else Console.WriteLine("Falsche eingabe");


            Console.WriteLine("Ende");
            Console.ReadLine();

        }
    }
}
