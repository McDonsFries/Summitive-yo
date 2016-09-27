using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Summitive_yo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Mikayla Racz, September 26, 2016
            //Summative Project

        }

        private void button1_Click(object sender, EventArgs e)
        {////

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Silver, 5);
            SolidBrush starBrush = new SolidBrush(Color.Gold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font newFont = new Font("Times New Roman", 8, FontStyle.Bold);

            startButton.Hide();

            formGraphics.Clear(Color.Black);

            formGraphics.DrawString("The Zodiac Cancer", drawFont, drawBrush, 25, 100);

            Thread.Sleep(2000);

            formGraphics.Clear(Color.Black);

            formGraphics.FillEllipse(drawBrush, 106, 19, 10, 10);

            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 113, 84, 10, 10);

            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 110, 113, 10, 10);

            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 80, 168, 10, 10);

            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 172, 192, 10, 10);

            Thread.Sleep(1000);

            formGraphics.DrawLine(drawPen, 110, 25, 117, 88);
           
            Thread.Sleep(1200);
            
            formGraphics.DrawLine(drawPen, 117, 88, 114, 115);

            Thread.Sleep(1200);
            
            formGraphics.DrawLine(drawPen, 114, 115, 84, 172);

            Thread.Sleep(1200);
            
            formGraphics.DrawLine(drawPen, 114, 115, 174, 194);

            Thread.Sleep(1200);

            formGraphics.Clear(Color.Black);

            formGraphics.DrawString("Cancer, the fourth sign of the zodiac, is all about home.", newFont, drawBrush, 0, 100);
            formGraphics.DrawString("Those born under this sign are 'roots' kinds of people,", newFont, drawBrush, 0, 110);
            formGraphics.DrawString("and take great pleasure in the comforts of home and family.", newFont, drawBrush, 0, 120);
            formGraphics.DrawString("Cancers are maternal, domestic and love to nurture others.", newFont, drawBrush, 0, 130);

            Thread.Sleep(5000);
            formGraphics.Clear(Color.Black);

        }
    }
}