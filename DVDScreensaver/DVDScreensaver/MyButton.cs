using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public class MyButton : Button
    {
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                if (value == Color.Pink)
                {
                    MessageBox.Show("Pink ist verboten!");
                    return;
                }
                base.BackColor = value;
            }
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pevent.Graphics.FillEllipse(Brushes.CadetBlue, ClientRectangle);
            

        }
    }
}
