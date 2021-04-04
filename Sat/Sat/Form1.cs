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

namespace Sat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 550;
            this.Height = 550;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            
            Bitmap bitmap = new Bitmap(Properties.Resources.Drvo);
            TextureBrush tBrush = new TextureBrush(bitmap);
            Pen p = new Pen(tBrush,250);
            e.Graphics.DrawEllipse(p, 130, 130, 250, 250);

            Bitmap drvo = new Bitmap(Properties.Resources.Drvo1);
            TextureBrush tBrush1 = new TextureBrush(drvo);
            Pen p1 = new Pen(tBrush1, 220);
            e.Graphics.DrawEllipse(p1, 147, 147, 220, 220);

            Pen krug = new Pen(Color.Black, 2);
            g.DrawArc(krug, 62, 62, 390, 390, 0, 360);
            g.DrawArc(krug, 82, 82, 350, 350, 0, 360);

            Pen sati = new Pen(Color.Black, 10);
            //g.DrawLine(sati, 260,62,260,82);
            Font font = new Font("Times New Roman", 20);
            Brush brash = new SolidBrush(Color.Red);
            g.DrawString("12", font, brash,245,85);
            //g.DrawLine(sati, 260, 452, 260, 432);
            g.DrawString("6", font, brash, 245, 400);

            //g.DrawLine(sati, 62, 260, 82, 260);
            g.DrawString("9", font, brash, 85, 250);

            //g.DrawLine(sati, 452, 260, 432, 260);
            g.DrawString("3", font, brash, 410, 245);

            Pen centar = new Pen(Color.Red, 3);
            g.DrawArc(centar, 245, 245, 20, 20, 0, 360);



            g.DrawString("Wall Clock", new Font("Brush Script MT", 28), brash, 190, 290);

            //g.DrawLine(sati, 363, 93, 353, 112);
            g.DrawString("1", font, brash, 340, 110);

            //g.DrawLine(sati, 433, 170, 415, 180);
            g.DrawString("2", font, brash, 390, 170);

            //g.DrawLine(sati, 428, 350, 410, 340);
            g.DrawString("4", font, brash, 390, 320);

            //g.DrawLine(sati, 363, 420, 353, 402);
            g.DrawString("5", font, brash, 335, 380);


            //g.DrawLine(sati, 155, 90, 165, 107);
            g.DrawString("11", font, brash, 165, 110);



            //g.DrawLine(sati, 88, 160, 106, 170);
            g.DrawString("10", font, brash, 106, 172);


            //g.DrawLine(sati, 85, 350, 105, 340);
            g.DrawString("8", font, brash, 110, 320);


            //g.DrawLine(sati, 160, 428, 172, 410);
            g.DrawString("7", font, brash, 175, 380);


            Pen kaz = new Pen(Color.Black, 2);
            g.DrawLine(kaz,247,247,200,200);



            g.DrawLine(kaz, 266, 252, 350, 200);

            Brush br = new SolidBrush(Color.LightGray);
            g.FillRectangle(br, 195, 140, 130, 40);

            g.FillEllipse(br, 230, 130, 60, 60);

            g.DrawString("Royal", new Font("Brush Script MT", 20), brash, 230,140);


            Brush pn = new SolidBrush(Color.Black);
            Point[] points= {new Point(365,192), new Point(340,200), new Point(350,210) };
            Point[] points1 = { new Point(188, 188), new Point(210, 200), new Point(200, 210) };

            g.FillPolygon(pn, points);
            g.FillPolygon(pn, points1);


            GraphicsPath gp = new GraphicsPath();
            int midX = 255;
            int midY = 255;
            Rectangle rect = new Rectangle(midX,62,5,20);
            Pen pnm = new Pen(Color.Black, 1);
            Graphics gee = e.Graphics;
            gp.AddRectangle(rect);
            gee.DrawPath(pnm, gp);
            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(30, new PointF(midX, midY));

            for (int i = 0; i < 11; i++)
            {

                //myMatrix.Scale(1, 2, MatrixOrder.Append);
                //myMatrix.Translate(5, 0, MatrixOrder.Append);


                gp.Transform(myMatrix);
                gee.DrawPath(pnm, gp);
            }


        }
    }
}
