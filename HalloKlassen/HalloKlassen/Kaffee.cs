using System;

namespace HalloKlassen
{
    public class Kaffee : Object
    {
        public Kaffee()//default konstruktor
        {
            temperatur = 80;
        }

        public Kaffee(int temp)
        {
            temperatur = temp;
        }

        private double temperatur;
        //setter methode
        public void SetTemperatur(double temp)
        {
            temperatur = temp;
        }

        //getter function
        public double GetTemperatur()
        {
            return temperatur;
        }

        private int menge; //backing field
        public int Menge //full property
        {
            get { return menge; }
            internal set { menge = value; }
        }


        public bool HatKoffein { get; internal set; } = true;//auto property

        public string Art { get; set; }

        public virtual void Abkühlen()
        {
            temperatur -= 5;
            Console.WriteLine($"{Art} hat nun die Temperatur {temperatur}°C");
        }

    }

    public class Cappuccino : Kaffee
    {
        public bool Schokoflocken { get; set; }
        public int MilchSchaumMenge { get; set; }

        public override void Abkühlen()
        {
            SetTemperatur(GetTemperatur() - 7);
            Abkühlen();
        }
    }
}
