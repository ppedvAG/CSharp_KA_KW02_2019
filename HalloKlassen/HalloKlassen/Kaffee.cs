namespace HalloKlassen
{
    public class Kaffee
    {

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


        public bool HatKoffein { get; internal set; }//auto property

        public string Art { get; set; }

        public void Abkühlen()
        {
            temperatur -= 5;
        }

    }
}
