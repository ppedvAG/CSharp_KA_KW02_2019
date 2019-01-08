﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        int speedX = 3;
        int speedY = 3;
        Random rng = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Text = count.ToString();

            button1.Left += speedX;
            button1.Top += speedY;


            if (button1.Right >= ClientRectangle.Right || button1.Left <= 0)
            {
                speedX *= -1;
                Task.Run(() => Console.Beep());
                this.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));
                button1.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));

            }

            if (button1.Bottom >= ClientRectangle.Bottom || button1.Top <= 0)
            {
                speedY *= -1;
                Task.Run(() => Console.Beep());
                this.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));
                button1.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));

            }
        }
  
    }
}
