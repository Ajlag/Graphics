using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciCoveculjak
{
    
    public partial class Form1 : Form
    {
        Boolean glavaD = false;
        Boolean stomakD = false;
        Boolean jednaRuka = false;
        Boolean drugaRuka = false;
        Boolean jednaNoga = false;
        Boolean drugaNoga = false;
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 550;
            panel1.Width = 450;
            panel1.Height = 450;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.DarkGreen);
            Bitmap bitmap = new Bitmap(Properties.Resources.Green);
            g.DrawImage(bitmap, 60, 60, 350, 350);

            Brush brush1 = new SolidBrush(Color.White);
            g.FillRectangle(brush1, 100, 90, 10, 280);
            g.FillRectangle(brush1, 90, 100, 280, 10);
            g.FillRectangle(brush1, 320, 110, 10, 30);

            Pen pn = new Pen(Color.White, 5);
            Point p1 = new Point(105, 165);
            Point p2 = new Point(165, 105);
            g.DrawLine(pn, p1, p2);

            Pen pn2 = new Pen(Color.Orange, 10);
            g.DrawRectangle(pn2, 60, 60, 350, 350);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pn1 = new Pen(Color.White, 2);

            if (glavaD == false)
            {

                g.DrawArc(pn1, 290, 140, 70, 70, 0, 360);
                glavaD = true;
            }
            else {
                if (stomakD == false)
                {
                    g.DrawLine(pn1, 325, 210, 325, 300);
                    stomakD = true;
                }
                else {
                    if (jednaRuka == false)
                    {
                        g.DrawLine(pn1, 325, 240, 280, 260);
                        jednaRuka = true;

                    }
                    else {
                        if (drugaRuka == false)
                        {
                            g.DrawLine(pn1, 325, 240, 365, 260);
                            drugaRuka = true;
                        }
                        else {
                            if (jednaNoga == false)
                            {
                                g.DrawLine(pn1, 324, 299, 290, 345);
                                jednaNoga = true;
                            }
                            else
                            {
                                if (drugaNoga == false) {

                                    g.DrawLine(pn1, 325, 299, 355, 345);
                                    drugaNoga = true;

                                }
                                else
                                {

                                    MessageBox.Show("Zavrsili ste sa crtanjem");
                                } }

                        }

                    }

                }


            }
        }

    }
}
