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
using System.Media;

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
        {

            Graphics formGraphics = this.CreateGraphics(); //this block shows that the pens, brushes and text are made
            Pen drawPen = new Pen(Color.Silver, 5);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush wordBrush = new SolidBrush(Color.Black);
            SolidBrush starBrush = new SolidBrush(Color.Gold);
            Font drawFont = new Font("Arial", 20, FontStyle.Bold);
            Font newFont = new Font("Times New Roman", 8, FontStyle.Bold);

            startButton.Hide();
            nameLabel.Hide();
            dateLabel.Hide();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Navy);
            formGraphics.DrawString("The Zodiac Cancer", drawFont, drawBrush, 25, 100);
            Thread.Sleep(2000);

            formGraphics.Clear(Color.SlateGray); //The 'stars' are created and sounds are made as the stars are created
            formGraphics.FillEllipse(drawBrush, 106, 19, 10, 10);
            SoundPlayer player = new SoundPlayer(Properties.Resources.beep); //Yes i know this isnt how to thread audio but too bad it works
            player.Play();
            Thread.Sleep(1000);
            player.Stop();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 113, 84, 10, 10);
            SoundPlayer playe = new SoundPlayer(Properties.Resources.beep);
            player.Play();
            Thread.Sleep(1000);
            player.Stop();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 110, 113, 10, 10);
            SoundPlayer players = new SoundPlayer(Properties.Resources.beep);
            player.Play();
            Thread.Sleep(1000);
            player.Stop();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 80, 168, 10, 10);
            SoundPlayer play = new SoundPlayer(Properties.Resources.beep);
            player.Play();
            Thread.Sleep(1000);
            player.Stop();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 172, 192, 10, 10);
            SoundPlayer playr = new SoundPlayer(Properties.Resources.beep);
            player.Play();
            Thread.Sleep(1000);
            player.Stop();

            Thread.Sleep(1000); //The lines alligning the 'stars' are made
            formGraphics.DrawLine(drawPen, 110, 25, 117, 88);
            Thread.Sleep(1200);
            formGraphics.DrawLine(drawPen, 117, 88, 114, 115);
            Thread.Sleep(1200);
            formGraphics.DrawLine(drawPen, 114, 115, 84, 172);
            Thread.Sleep(1200);
            formGraphics.DrawLine(drawPen, 114, 115, 174, 194);
            Thread.Sleep(1200);

            formGraphics.Clear(Color.Silver); //Info about this specific zodiac sign
            formGraphics.FillEllipse(starBrush, 106, 19, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(starBrush, 113, 84, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(starBrush, 110, 113, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(starBrush, 80, 168, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(starBrush, 172, 192, 10, 10);
            SoundPlayer plyer = new SoundPlayer(Properties.Resources.rain);
            player.Play();
            Thread.Sleep(1500);
            player.Stop();

            //Info about the zodiac sign
            formGraphics.DrawString("Cancer, the fourth sign of the zodiac, is all about home.", newFont, wordBrush, 0, 100);
            formGraphics.DrawString("Those born under this sign are 'roots' kinds of people,", newFont, wordBrush, 0, 110);
            formGraphics.DrawString("and take great pleasure in the comforts of home and family.", newFont, wordBrush, 0, 120);
            formGraphics.DrawString("Cancers are maternal, domestic and love to nurture others.", newFont, wordBrush, 0, 130);

            Thread.Sleep(5000);
            formGraphics.Clear(Color.Purple);

        }
    }
}