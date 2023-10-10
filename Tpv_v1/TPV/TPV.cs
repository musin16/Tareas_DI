using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using System.IO;
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using Image = System.Drawing.Image;

namespace TPV
{
    public partial class TPV : Form
    {
        claseAccesoBD conexion = new claseAccesoBD();
        List<claseFruta> listaFrutas = new List<claseFruta>();
        List<claseCesta> listaCesta = new List<claseCesta>();
        List<String> ProductosBajoMinimo = new List<String>();
        List<claseFruta> frutaEncontrada = new List<claseFruta>();

        int contadorProductos = 0;
        double total = 0;

        public TPV()
        {
            InitializeComponent();
        }

        private void TPV_Load(object sender, EventArgs e)
        {
            gbInfo.Visible = false;
            listaFrutas = conexion.listarFrutas();
            int i=0;
            foreach (claseFruta cf in listaFrutas)
            {
                Button btn = new Button();
                btn.Name = cf.Nombre;

                btn.Width = 120;
                btn.Height = 120;

                MemoryStream ms = new System.IO.MemoryStream(cf.Imagen);
                System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = imagen;
                btn.Tag = i;
                i++;
                btn.Click += Btn_Click;
                btn.MouseHover += Btn_MouseHover;

                flpFrutas.Controls.Add(btn);

            }
            dgv1.DataSource = listaCesta;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            int pos = Convert.ToInt16(btn.Tag);
            //hay que coregir el error
            lblPrecio.Text = listaFrutas[pos].Precio.ToString();
            lblExistencias.Text = listaFrutas[pos].Stock.ToString();
            lblNombre.Text = listaFrutas[pos].Nombre;            
            gbInfo.Visible = true;

        }

        private void Btn_Click(object sender, EventArgs e) // Botones de frutas
        {
            Button btnx = (Button)sender;

            foreach (claseFruta cf in listaFrutas)
            {
                if (cf.Nombre == btnx.Name)
                {
                    if (cf.Stock <= 0)
                    {
                        MessageBox.Show("No hay existencias de este producto.");
                    }
                    else
                    {

                        MessageBox.Show("Has seleccionado " + cf.Nombre + ". Existencias: " + cf.Stock, "TPV Frutería Vero");
                        String peso = Interaction.InputBox("Introduce peso en kgs", "TPV Frutería Vero");

                        if (peso == "" || Convert.ToDouble(peso) <= 0)
                        {
                            MessageBox.Show("Cantidad errónea.");
                        }
                        else
                        {
                            contadorProductos++;
                            claseCesta producto = new claseCesta();
                            producto.Articulo = contadorProductos;
                            producto.Nombre = cf.Nombre;
                            producto.Peso = Convert.ToDouble(peso);
                            producto.PrecioUnitario = Math.Round(Convert.ToDouble(cf.Precio), 2);
                            producto.PrecioParcial = Math.Round(producto.Peso * producto.PrecioUnitario, 2);

                            total += producto.PrecioParcial;

                            lblTotal.Text = Convert.ToString(total);

                            listaCesta.Add(producto);
                            cf.Stock -= Convert.ToInt32(peso);

                            dgv1.DataSource = null;
                            dgv1.DataSource = listaCesta;
                        }
                    }
                }
            }
            gbInfo.Visible = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = 0.ToString();
            conexion.modificarStock(listaCesta,listaFrutas);
            listaCesta.Clear();
            dgv1.DataSource= null;
            dgv1.DataSource = listaCesta;
        }

        private String imprimirTicket()
        {
            return null;
        }

        private void mandarMail(String archivo, String mail)
        {


        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            btnEmpezar.Visible = false;
            flpFrutas.Visible = true;
            btnPagar.Visible = true;
            lblTotal.Visible = true;
            dgv1.Visible = true;
            label1.Visible = true;
            txtMail.Visible = true;
            btnAdministrar.Visible = true;
            labelEuro.Visible = true;
            labelTotal.Visible = true;
            lblBusca.Visible = true;
            txtBuscar.Visible = true;
            gbInfo.Visible = false;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.ShowDialog();
            this.Hide();
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            flpFrutas.Controls.Clear();
            for (int i=0;i<listaFrutas.Count;i++)
            {
                Button btn = new Button();
                btn.Size = new Size(120,120);
                btn.Name = listaFrutas[i].Nombre;
                btn.Tag = listaFrutas[i].Id;
                btn.Click += Btn_Click; ;
                MemoryStream ms = new MemoryStream(listaFrutas[i].Imagen);
                if (listaFrutas[i].Nombre.StartsWith(txtBuscar.Text) && txtBuscar.Text!="")
                {
                    btn.BackgroundImage = Image.FromStream(ms);
                    flpFrutas.Controls.Add(btn);
                    frutaEncontrada.Add(listaFrutas[i]);
                    dgv1.DataSource = null;
                    dgv1.DataSource = frutaEncontrada;
                }
                if (txtBuscar.Text=="")
                {
                    frutaEncontrada.Clear();
                    btn.BackgroundImage = Image.FromStream(ms);
                    flpFrutas.Controls.Add(btn);
                    dgv1.DataSource = null;
                    dgv1.DataSource = frutaEncontrada;
                }
            }


        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult r = MessageBox.Show("¿Quieres eliminar la fruta?","Opcion",MessageBoxButtons.OKCancel);
            if (r==DialogResult.OK)
            {
                conexion.eliminarFruta(Convert.ToInt16(btn.Tag));
                flpFrutas.Controls.Clear();
                conexion.listarFrutas();
                MessageBox.Show("Fruta eliminada correctamente");

            }
            else
            {
                MessageBox.Show("FRUTA NO SE HA ELIMINADO");
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbInfo.Visible = false;
            DialogResult confirmarEliminar = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Frutería Vero", MessageBoxButtons.YesNo);
            if (confirmarEliminar == DialogResult.Yes)
            {
                int filaSeleccionada = dgv1.CurrentCell.RowIndex;
                double precioRestar = listaCesta.ElementAt(filaSeleccionada).PrecioParcial;

                listaCesta.RemoveAt(filaSeleccionada);

                dgv1.DataSource = null;
                dgv1.DataSource = listaCesta;
                total -= precioRestar;
                lblTotal.Text = Convert.ToString(total);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}


