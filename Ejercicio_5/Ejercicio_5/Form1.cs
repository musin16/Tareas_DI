using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int cont=0;
        int mayor = 0;
        int menor=0;
        int sumar=0;
        int media=0;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int numAle = r.Next(1,1000000);
            label2.Text = numAle.ToString();
            if (cont==0)
            {
                menor = numAle;
                lbl_menor.Text = menor.ToString();
            }
            if (numAle>mayor)
            {
                mayor = numAle;
                lbl_mayor.Text = mayor.ToString();
            }
            if (numAle < menor)
            {
                menor = numAle;
                lbl_menor.Text = menor.ToString();
            }
            sumar += numAle;
            cont++;
            media = sumar / cont;
            label5.Text = media.ToString();
            label1.Text = cont.ToString();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyCode)
            {
                timer1.Start();
            }
            else if (Keys.Space == e.KeyCode)
            {
                timer1.Stop();
            }
            else if (Keys.Escape == e.KeyCode)
            {
                Close();
            }

        }
    }
}
