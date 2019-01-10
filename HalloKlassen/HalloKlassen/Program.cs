using System;

namespace HalloKlassen
{


    class Program
    {

        static void ÄndereZahl(ref int zahl)
        {
            zahl += 5;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Klassen");

#if DEBUG
            Console.WriteLine("DEBUG");
#endif
            int zahl = 2;
            Console.WriteLine(zahl);
            ÄndereZahl(ref zahl);
            Console.WriteLine(zahl);


            decimal gehalt;

            Kaffee meinKaffee = null; //deklaration
            meinKaffee = new Kaffee() //instanzierung
            {
                Art = "Kaffee mit Milch",
                Menge = 180,
                HatKoffein = true
            };
            meinKaffee.SetTemperatur(55.3);

            Cappuccino nochEinKaffee = new Cappuccino();
            nochEinKaffee.Art = "Cappuccino";
            nochEinKaffee.MilchSchaumMenge = 90;
            nochEinKaffee.Schokoflocken = true;
            nochEinKaffee.Menge = 30;
            nochEinKaffee.HatKoffein = true;
            nochEinKaffee.SetTemperatur(70.9);

            ZeigeKaffee(meinKaffee);

            ZeigeKaffee(nochEinKaffee);

            meinKaffee.Abkühlen();
            nochEinKaffee.Abkühlen();

            Console.WriteLine(meinKaffee);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }



        static void ZeigeKaffee(Kaffee kaf)
        {
            kaf.Abkühlen();

            if (kaf != null)
                Console.WriteLine($"{kaf.Art} {kaf.Menge}ml {kaf.GetTemperatur()}°C");

            //#0
            if (kaf is Cappuccino)//typprüfung
            {
                Cappuccino cap = (Cappuccino)kaf; //casting
                Console.WriteLine($"\tMilchSchaumMenge: {cap.MilchSchaumMenge}ml");
            }

            //#1 boxing
            Cappuccino capp = kaf as Cappuccino;
            if (capp != null)
            {
                if (capp.Schokoflocken)
                    Console.WriteLine($"\tmit Schoko");
                else
                    Console.WriteLine($"\tohne Schoko");
            }

            //#2 pattern matching 
            if (kaf is Cappuccino cappp)
            {
             
                Console.WriteLine($"\tJop, des isn' Cappo {capp.HatKoffein}");
            }

        }
    }
}
