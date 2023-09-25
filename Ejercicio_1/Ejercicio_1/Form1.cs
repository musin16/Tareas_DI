using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Transferir_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    flowLayoutPanel2.Controls.Add(ctrl);
                }
                else if (ctrl is Label lb)
                {
                    flowLayoutPanel3.Controls.Add(ctrl);
                }
                else if (ctrl is TextBox tb)
                {
                    flowLayoutPanel4.Controls.Add(ctrl);
                }
                else if (ctrl is ComboBox cb)
                {
                    flowLayoutPanel5.Controls.Add(ctrl);
                }
                else
                {
                    flowLayoutPanel6.Controls.Add(ctrl);
                }

            }
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                flowLayoutPanel1.Controls.Clear();
            
            }
        }
    }
}
