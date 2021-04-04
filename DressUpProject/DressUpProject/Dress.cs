using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressUpProject
{
    public partial class Dress : Form
    {
      
        Bitmap lutka = new Bitmap(Properties.Resources.glutk2);

        public Dress()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 700;
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap room = new Bitmap(Properties.Resources.room);
            g.DrawImage(room, 0, 0, 700, 700);

          
               g.DrawImage(lutka, 165, 110, 300, 500);
            Pen pen = new Pen(Color.Red, 1);
            g.DrawLine(pen, 100, 30, 110, 20);
            g.DrawLine(pen, 100, 20, 110, 30);
            g.DrawLine(pen, 105, 20, 105, 30);
            g.DrawLine(pen, 100, 25, 110, 25);

            g.DrawLine(pen, 600, 30, 610, 20);
            g.DrawLine(pen, 600, 20, 610, 30);
            g.DrawLine(pen, 605, 20, 605, 30);
            g.DrawLine(pen, 600, 25, 610, 25);

            g.DrawLine(pen, 500, 70, 510, 60);
            g.DrawLine(pen, 500, 60, 510, 70);
            g.DrawLine(pen, 505, 60, 505, 70);
            g.DrawLine(pen, 500, 65, 510, 65);


            g.DrawLine(pen, 200, 70, 210, 60);
            g.DrawLine(pen, 200, 60, 210, 70);
            g.DrawLine(pen, 205, 60, 205, 70);
            g.DrawLine(pen, 200, 65, 210, 65);

        }



        private void haljina_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap haljina = new Bitmap(Properties.Resources.haljina);

            g.DrawImage(haljina, 7, 7, 30, 30);
        }

        private void majica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap majica = new Bitmap(Properties.Resources.majica);

            g.DrawImage(majica, 7, 7, 30, 30);
        }

        private void pant_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pant = new Bitmap(Properties.Resources.pant);

            g.DrawImage(pant, 4, 4, 40, 40);
        }

        private void cipele_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap shoe = new Bitmap(Properties.Resources.shoe);

            g.DrawImage(shoe, 5, 5, 35, 35);
        }

      

        private void Dress_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(30, 0, 0, 0);

        }

        private void haljina_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 0)
            {   panel1.Width = 100;
                panel3.Width = 0;
                panel4.Width = 0;
                panel6.Width = 0;
               
            }
            else
            {

                panel1.Width = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Graphics g = panel2.CreateGraphics();
        
                Bitmap haljina11 = new Bitmap(Properties.Resources.haljina1);
                g.DrawImage(haljina11, 120, 110, 375, 500);
             
            
            
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
          
                Graphics g = e.Graphics;
                Bitmap haljina1 = new Bitmap(Properties.Resources.haljina1);
                g.DrawImage(haljina1, 5, 0, 55, 70);


            

        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap haljina1 = new Bitmap(Properties.Resources.drugahaljina);
            g.DrawImage(haljina1, 5, 0, 55, 70);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap haljina1 = new Bitmap(Properties.Resources.haljina3);
            g.DrawImage(haljina1, 5, 0, 55, 70);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
           
          

                Bitmap haljina22 = new Bitmap(Properties.Resources.drugahaljina);
                g.DrawImage(haljina22, 118, 102, 400, 520);
               


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();

            

                Bitmap haljina33 = new Bitmap(Properties.Resources.trecahaljina);
                g.DrawImage(haljina33, 68, 113, 460, 500);



            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void majica_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 0)
            {   panel3.Width = 100;
                panel1.Width = 0;
                panel4.Width = 0;
                panel6.Width = 0;
                
            }
            else
            {

                panel3.Width = 0;
            }
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap majica1 = new Bitmap(Properties.Resources.majica1);
            g.DrawImage(majica1, 5, 20, 55, 50);
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap majica2 = new Bitmap(Properties.Resources.majica2);
            g.DrawImage(majica2, 5, 20, 55, 50);
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap majica3 = new Bitmap(Properties.Resources.majica4);
            g.DrawImage(majica3, 5, 20, 55, 50);
        }

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pant1 = new Bitmap(Properties.Resources.pant1);
            g.DrawImage(pant1, 5, 20, 55, 50);
        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pant2 = new Bitmap(Properties.Resources.pant2);
            g.DrawImage(pant2, 5, 20, 55, 50);
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pant3 = new Bitmap(Properties.Resources.pant3);
            g.DrawImage(pant3, 5, 20, 55, 50);
        }

        private void pant_Click(object sender, EventArgs e)
        {

            if (panel4.Width == 0)
            {
                panel4.Width = 100;
                panel3.Width = 0;
                panel1.Width = 0;
                panel6.Width = 0;

            }
            else
            {

                panel4.Width = 0;
            }
        }

 

        private void cipele_Click(object sender, EventArgs e)
        {

            if (panel6.Width == 0)
            {
                panel6.Width = 100;
                panel3.Width = 0;
                panel1.Width = 0;
                panel4.Width = 0;

            }
            else
            {

                panel6.Width = 0;
            }
        }

        private void button15_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap cipele1 = new Bitmap(Properties.Resources.cipele1);
            g.DrawImage(cipele1, 5, 20, 55, 50);
        }

        private void button13_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap cipele2 = new Bitmap(Properties.Resources.cipele2);
            g.DrawImage(cipele2, 5, 20, 55, 50);
        }

        private void button14_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap cipele3 = new Bitmap(Properties.Resources.cipele3);
            g.DrawImage(cipele3, 5, 20, 55, 50);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
                 Bitmap majica1 = new Bitmap(Properties.Resources.majica1);
                g.DrawImage(majica1, 240, 220, 135, 110);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap majica2 = new Bitmap(Properties.Resources.majica2);
            g.DrawImage(majica2, 220, 212, 190, 130);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap majica4 = new Bitmap(Properties.Resources.majica4);
            g.DrawImage(majica4, 75, 210, 300, 200);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap cipele1 = new Bitmap(Properties.Resources.cipele1);
            g.DrawImage(cipele1, 182, 510, 168, 80);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap cipele2 = new Bitmap(Properties.Resources.cipele2);
            g.DrawImage(cipele2, 183, 470, 182, 120);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap cipele3 = new Bitmap(Properties.Resources.cipele3);
            g.DrawImage(cipele3, 185, 510, 167, 80);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap pant1 = new Bitmap(Properties.Resources.newpant1);
            g.DrawImage(pant1, 255, 290, 120, 90);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap pant2 = new Bitmap(Properties.Resources.newpant2);
            g.DrawImage(pant2, 248, 295, 128, 90);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Bitmap pant3 = new Bitmap(Properties.Resources.pant3);
            g.DrawImage(pant3, 225, 295, 165, 90);
        }
    }
}
