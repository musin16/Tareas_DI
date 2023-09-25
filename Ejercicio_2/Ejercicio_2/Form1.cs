using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                comboBox2.Items.Add(i);
            }

                comboBox1.Items.Add("ComboBox");
                comboBox1.Items.Add("TextBox");
                comboBox1.Items.Add("Label");
                comboBox1.Items.Add("Button");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {
                for (int i = 0; i < Convert.ToInt32(comboBox2.Text); i++)
                {
                    if (comboBox1.Text== "ComboBox")
                    {
                        ComboBox cb = new ComboBox();
                        flowLayoutPanel1.Controls.Add(cb);
                        
                    }
                    else if (comboBox1.Text == "TextBox")
                    {
                        TextBox tb = new TextBox();
                        tb.BackColor = Color.Green;
                        flowLayoutPanel1.Controls.Add(tb);
                    }
                    else if (comboBox1.Text == "Label")
                    {
                        Label lb = new Label();
                        lb.Text = "Etiqueta";
                        flowLayoutPanel1.Controls.Add(lb);
                    }
                    else
                    {
                        Button btn = new Button();
                        btn.BackColor = Color.Red;
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                    
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                for (int i = 0; i < Convert.ToInt32(comboBox2.Text); i++)
                {
                    if (comboBox1.Text == "ComboBox")
                    {
                        ComboBox cb = new ComboBox();
                        flowLayoutPanel1.Controls.Add(cb);

                    }
                    else if (comboBox1.Text == "TextBox")
                    {
                        TextBox tb = new TextBox();
                        tb.BackColor = Color.Green;
                        flowLayoutPanel1.Controls.Add(tb);
                    }
                    else if (comboBox1.Text == "Label")
                    {
                        Label lb = new Label();
                        lb.Text = "Etiqueta";
                        flowLayoutPanel1.Controls.Add(lb);
                    }
                    else
                    {
                        Button btn = new Button();
                        btn.BackColor = Color.Red;
                        flowLayoutPanel1.Controls.Add(btn);
                    }

                }
            }
        }
    }
}
