using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dale a la figura verde y aumentaras un punto y si fallas disminuyes un punto");
            timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int posX = r.Next(1,this.Width);
            int posY = r.Next(1, this.Height);
            Label btn = new Label();
            btn.Width = 50;
            btn.Height = 20;
            btn.BackColor = Color.Green;
            btn.Text = "Tocame";
            btn.Location = new Point(posX,posY);
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.Visible=false;
            cont++;
            label1.Text = cont.ToString();
       
            
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            cont--;
            label1.Text = cont.ToString();
        }
    }
}
