using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2_OCT6
{
    public partial class Form1 : Form
    {
        conectarBd cn = new conectarBd();
        List<Fruta> lisfrutas = new List<Fruta>();
        List<Fruta> lisfrutas2 = new List<Fruta>();
  
        double suma=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = false;
            btn_pagar.Visible = false;
            lbl_contador.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0;i<12;i++)
            {               
                Button btn = new Button();
                TextBox tb = new TextBox();
                lisfrutas = cn.listarFrutas();
                tb.Text =lisfrutas[i].Precio.ToString();
                MemoryStream ms = new MemoryStream(lisfrutas[i].Imagen);
                btn.Image = Image.FromStream(ms);
                btn.Size = new Size(80, 80);
                btn.Tag=i;
                tb.Enabled = false;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.AddRange(new Control[] { btn,tb });
               
            }
            button1.Visible = false;
            lbl_contador.Visible = true;
            flowLayoutPanel1.Visible = true;
            dataGridView1.Visible = true;
            btn_pagar.Visible = true;
            dataGridView1.DataSource = lisfrutas2;
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int num = Convert.ToInt16(btn.Tag);
            lisfrutas2.Add(lisfrutas[num]);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =lisfrutas2;
            suma += lisfrutas[num].Precio;
            lbl_contador.Text =suma.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_contador.Text = 0.ToString();
            lisfrutas2.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lisfrutas2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0 && fila < lisfrutas2.Count)
            {
                Fruta f = lisfrutas2[fila];
                lisfrutas2.Remove(f);
                suma -= f.Precio;
                lbl_contador.Text = suma.ToString();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lisfrutas2;
            }

            MessageBox.Show("alert");
        }
            
    }
}
