using Autos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Autos.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            bindingSource1.DataSource = new List<Moped>();
            dataGridView1.DataSource = bindingSource1;
            listBox1.DataSource = bindingSource1;
            listBox1.DisplayMember = "Hersteller";
            textBox1.DataBindings.Add("Text", bindingSource1, nameof(Moped.Hersteller), true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", bindingSource1, nameof(Moped.Modell), true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", bindingSource1, nameof(Moped.Farbe), true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", bindingSource1, nameof(Moped.Baujahr), true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Value", bindingSource1, nameof(Moped.Leistung), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Moped einMoped = new Moped()
                {
                    Hersteller = "Garelli",
                    Farbe = "Rot",
                    Leistung = 39,
                    Modell = $"SR 50-{i:00}",
                    Baujahr = new DateTime(2018, 11, 11),
                    AuspuffEingetragen = false
                };
                bindingSource1.Add(einMoped);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
        }

        string t = "🍔";
        string fileName = "🏍.txt";
        private void button3_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter(fileName))
            {
                foreach (var m in (IEnumerable<Moped>)bindingSource1.DataSource)
                {
                    sw.Write(m.Hersteller);
                    sw.Write(t);
                    sw.Write(m.Modell);
                    sw.Write(t);
                    sw.Write(m.Farbe);
                    sw.Write(t);
                    sw.Write(m.Baujahr);
                    sw.Write(t);
                    sw.Write(m.Leistung);
                    sw.Write(t);
                    sw.Write(m.AuspuffEingetragen);

                    sw.WriteLine();
                }
            }//   sw.Dispose();  --->   sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            using (var sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var chunks = line.Split(t.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var m = new Moped()
                    {
                        Hersteller = chunks[0],
                        Modell = chunks[1],
                        Farbe = chunks[2],
                        Baujahr = DateTime.Parse(chunks[3]),
                        Leistung = int.Parse(chunks[4]),
                        AuspuffEingetragen = bool.Parse(chunks[5])
                    };
                    bindingSource1.Add(m);
                }
            }
        }
    }
}