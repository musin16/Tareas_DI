using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        conectarBd conx = new conectarBd();
        int cont = 0,max=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            conx.enviar(textBox1.Text,cont+1);
        //    flowLayoutPanel1.Controls.Add();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            max = conx.maximoNumMensaje();
            conx.refrescar(max);
            flowLayoutPanel1.Controls.Add();
        }
    }
}
