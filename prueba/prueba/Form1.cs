using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaSebastian1;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LibreriaSebastian1.Punto p1 = new LibreriaSebastian1.Punto();
            MessageBox.Show("(" + p1.X + "," + p1.Y + ")");

            if (p1.AbscisaIgualOrdenada())
            {
                MessageBox.Show("Coordenadas Iguales");
            }
            else
            {
                MessageBox.Show("Coordenadas Diferentes");
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LibreriaSebastian1.Punto p2 = new LibreriaSebastian1.Punto(-2,0);
            MessageBox.Show("(" + p2.X + "," + p2.Y + ")");

            if (p2.SobreEje())
            {
                MessageBox.Show("Esta sobre el eje X");
            }
            else
            {
                MessageBox.Show("Esta sobre el eje Y");
            }
            
           

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LibreriaSebastian1.Punto
                
            p3 = new LibreriaSebastian1.Punto(-4,5);

            int x = p3.Cuadrante();

            MessageBox.Show("(" + p3.X + "," + p3.Y + ")") ;
            MessageBox.Show("Cuadrante: " + x);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LibreriaSebastian1.Punto p4 = new LibreriaSebastian1.Punto();
            p4.X = -4;
            p4.Y =  5;
            LibreriaSebastian1.Punto p5 = new LibreriaSebastian1.Punto();
            p5.X =  5;
            p5.Y =  6;
            MessageBox.Show("(" + p4.X + "," + p4.Y + ")" + "(" + p5.X + "," + p5.Y + ")") ;
            if (p4.PuntosIguales(p5))
            {
                MessageBox.Show("Iguales");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }
    }
}
