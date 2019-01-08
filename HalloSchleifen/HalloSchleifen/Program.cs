using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Schleifen");

            List<int> zahlen = new List<int>();
            zahlen.Add(5);
            zahlen.Add(-165);
            zahlen.Add(465);
            zahlen.Add(222165);
            zahlen.Insert(3, 8695);
            zahlen.RemoveAt(1);


            foreach (int item in zahlen)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(zahlen.Average());
            Console.WriteLine("-------------------------------------------");

            HalloArray();

            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tage.txt");
            //SchreibeTage(fileName);
            LeseDatei(fileName);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void HalloArray()
        {
            int[] zahl = new int[3];
            zahl[0] = 5;
            zahl[1] = -90;
            zahl[2] = 288;

            for (int i = 0; i < zahl.Length; i++)
            {
                Console.WriteLine(zahl[i]);
            }
        }

        private static void LeseDatei(string fileName)
        {
            int z = 1;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine($"{z++}: {line}");
            }
            sr.Close();
        }

        private static void SchreibeTage(string dateiname)
        {
            StreamWriter sw = new StreamWriter(dateiname);
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine($"{DateTime.Now.AddDays(i):D}");
                sw.WriteLine(DateTime.Now.AddDays(i));
            }
            sw.Close();
        }
    }
}
