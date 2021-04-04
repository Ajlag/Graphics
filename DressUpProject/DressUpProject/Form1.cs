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

namespace DressUpProject
{
    public partial class Form1 : Form
    {   Bitmap p3 = new Bitmap(Properties.Resources.p3);
        Bitmap p1 = new Bitmap(Properties.Resources.p1);
        Bitmap p2 = new Bitmap(Properties.Resources.p2);
        Rectangle rectp3 = new Rectangle(0, 80, 300, 500);
        Rectangle rectp2 = new Rectangle(220, 30, 300, 500);
        Rectangle rectp1 = new Rectangle(400, 80, 300, 500);
        public Form1()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 700; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bit = new Bitmap(Properties.Resources.pozzz);
            g.DrawImage(bit,0,0,700,700);

          
            g.DrawImage(p3, rectp3);

           
            g.DrawImage(p1, rectp1);


           
            g.DrawImage(p2,rectp2);

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dress d = new Dress();
            d.ShowDialog();
            
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
        
            Pen myPen = new Pen(Color.Purple);

            SolidBrush mySolidBrush = new SolidBrush(Color.Pink);
            GraphicsPath myGraphicsPath = new GraphicsPath();
           
            FontFamily myFontFamily = new FontFamily("Algerian");
            PointF myPointF = new PointF(10, 10);
            StringFormat myStringFormat = new StringFormat();
           
           
            myGraphicsPath.AddString("Dress up", myFontFamily,
            0, 24, myPointF, myStringFormat);
            myGraphics.FillPath(mySolidBrush, myGraphicsPath);

            myGraphics.DrawPath(myPen, myGraphicsPath);


          

        }
    }
}
