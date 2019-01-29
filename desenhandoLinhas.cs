using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{

    
    public partial class Form1 : Form
    {

        bool isPassivelDesenho = false;

        List<Point> lista = new List<Point>();
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            
    


            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (lista.Count > 1)
            {
                for (int i = 1; i < lista.Count; i++)
                {

                    e.Graphics.DrawLine(new Pen(Color.Blue, 10), lista[i], lista[i - 1]);




                }
            }


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {



            p1.X = e.X;
            p1.Y = e.Y;
            lista.Add(p1);

            this.Invalidate(this.Region);
            p2.X = e.X;
            p2.Y = e.Y;



        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) 
        {

        }
    }
}
