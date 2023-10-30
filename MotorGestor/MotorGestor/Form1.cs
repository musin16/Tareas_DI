using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MotorGestor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtContra.Text = Interaction.InputBox("");
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            txtServidor.Text = Interaction.InputBox("");
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            txtBaseDatos.Text = Interaction.InputBox("");
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Interaction.InputBox("");
        }
    }
}
