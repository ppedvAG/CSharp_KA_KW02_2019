using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Model
{
    public class Fahrzeug
    {
        public string Hersteller { get; set; }
        public string Modell { get; set; }
        public string Farbe { get; set; }
        public DateTime Baujahr { get; set; }
        public int Leistung { get; set; }
    }
}
