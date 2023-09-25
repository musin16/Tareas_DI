using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_3
{
   
    
    public partial class Form1 : Form
    {
        Random r2 = new Random();
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            iniciar();
            label1.Size = new Size(20, 20);
            button1.Enabled = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iniciar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iniciar()
        {

            int numAle = 0;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 25; i++)
            {
                numAle = r2.Next(1, 26);
                Button btn = new Button();
                btn.Text = numAle.ToString();
                btn.Size = new Size(50, 50);
                btn.Tag = i.ToString();
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
            numAle = r2.Next(1, 26);
            label1.Text = numAle.ToString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn2 = (Button)sender;
            if (label1.Text==btn2.Text)
            {
                cont++;
                btn2.Enabled = false;
                label2.Text = cont.ToString();

            }
            else
            {
                    cont--;
                btn2.Enabled = false;
                label2.Text = cont.ToString();

            }
        }
    }
}
