using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            meinKaffee = new Kaffee(); //instanzierung
            ZeigeKaffee(meinKaffee);
            meinKaffee.Art = "Kaffee mit Milch";
            meinKaffee.Menge = 180;
            meinKaffee.HatKoffein = true;
            meinKaffee.SetTemperatur(55.3);

            Kaffee nochEinKaffee = new Kaffee();
            nochEinKaffee.Art = "Cappuccino";
            nochEinKaffee.Menge = 120;
            nochEinKaffee.SetTemperatur(70.9);
            nochEinKaffee.HatKoffein = true;

            ZeigeKaffee(meinKaffee);

            ZeigeKaffee(nochEinKaffee);
            nochEinKaffee.Abkühlen();
            ZeigeKaffee(nochEinKaffee);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

  

        static void ZeigeKaffee(Kaffee kaf)
        {
            if (kaf != null )
                Console.WriteLine($"{kaf.Art} {kaf.Menge}ml {kaf.GetTemperatur()}°C");
        }
    }
}
