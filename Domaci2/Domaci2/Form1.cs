using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci2
{
    public partial class Form1 : Form
    {
        Boolean glavaDodata = false;
        Boolean stomakDodaj = false;
        Boolean rukeDodaj = false;
        Boolean kolenaDodaj = false;
        Boolean noga1 = false;
        Boolean noga2 = false;

        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;

        }

        private void Crtaj_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            if (glavaDodata == false)
            {

                Bitmap bitmap = new Bitmap(Properties.Resources.gargamel);
                g.DrawImage(bitmap, 70, 180, 150, 80);
                glavaDodata = true;

            }
            else
            {
                if (stomakDodaj == false)
                {
                    Bitmap bitmap1 = new Bitmap(Properties.Resources.Stomak);
                    g.DrawImage(bitmap1, 145, 260, 100, 80);
                    stomakDodaj = true;
                }
                else
                {
                    if (rukeDodaj == false)
                    {
                        Bitmap bitmap2 = new Bitmap(Properties.Resources.ruke);
                        g.DrawImage(bitmap2, 65, 260, 90, 80);
                        rukeDodaj = true;
                    }
                    else
                    {
                        if (kolenaDodaj == false)
                        {
                            Bitmap bitmap3 = new Bitmap(Properties.Resources.Kolena);
                            g.DrawImage(bitmap3, 92, 340, 175, 80);
                            kolenaDodaj = true;
                        }
                        else
                        {
                            if (noga1 == false)
                            {

                                Bitmap bitmap4 = new Bitmap(Properties.Resources.noga1);
                                g.DrawImage(bitmap4, 160, 420, 100, 80);
                                noga1 = true;
                            }
                            else
                            {
                                if (noga2 == false)
                                {
                                    Bitmap bitmap5 = new Bitmap(Properties.Resources.noga2);
                                    g.DrawImage(bitmap5, 75, 418, 90, 70);
                                    noga2 = true;
                                }
                                else
                                {
                                    MessageBox.Show("Obesili ste Gargamela");
                                }
                            }
                        }
                    }
                }

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
