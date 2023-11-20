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
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Security.Cryptography;
using Image = System.Drawing.Image;

namespace TPV
{
    public partial class backEnd : Form
    {
        claseAccesoBD conexion = new claseAccesoBD();
        List<claseFruta> listaFrutas = new List<claseFruta>();
        List<String> productosBajoMinimo = new List<String>();
        String nombreImagen = "";
        public backEnd()
        {
            InitializeComponent();
            
        }
        private void backEnd_Load(object sender, EventArgs e)
        {
         
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            TPV tpv = new TPV();
            tpv.ShowDialog();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            flpFrutas.Controls.Clear();
            int cant = conexion.listarFrutas().Count;
            listaFrutas = conexion.listarFrutas();
            for (int i=0;i<cant;i++)
            {
                Button btn=new Button();
                btn.Text = listaFrutas[i].Nombre;
                btn.Tag = listaFrutas[i].Id;
                btn.Click += BotonS_Click;
                flpFrutas.Controls.Add(btn);
            }    
            flpFrutas.Visible = true;
        }

        private void BotonS_Click(object sender, EventArgs e) // Para añadir stock
        {
            Button bt=(Button)sender;
            int num = Convert.ToInt16(bt.Tag);
            String stock = Interaction.InputBox("Introduce la cantidad de stock que quieres introducir");
             conexion.insertarStock(Convert.ToDouble(stock),num);
        }

        private void btnInsertarFruta_Click(object sender, EventArgs e)
        {
            flpFrutas.Visible = false;
            gbInsertar.Visible = true;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nombreImagen = ofd.FileName;
                pbImagenCargada.BackgroundImage=Image.FromFile(ofd.FileName);
                pbImagenCargada.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(nombreImagen, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] bt = br.ReadBytes((int)fs.Length);
            conexion.insertarFruta(obtenerUltimoId(), txtNombre.Text, txtPrecio.Text, bt, txtStock.Text);

        }

        private int obtenerUltimoId()
        {
            
            return conexion.listarFrutas().Count+1;
      
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            flpFrutas.Visible = false;
            gbInsertar.Visible = true;

        }

        private void BotonM_Click(object sender, EventArgs e) // para modificar la fruta
        {
           

        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
          txtStock.Text=Interaction.InputBox("Introduce el stock que quieras: ");
         
        }

        private void btnEliminarFruta_Click(object sender, EventArgs e)
        {
            gbInsertar.Visible = false;
            flpFrutas.Controls.Clear();
            int cant = conexion.listarFrutas().Count;
            listaFrutas = conexion.listarFrutas();
            for (int i = 0; i < cant; i++)
            {
                Button btn = new Button();
                btn.Text = listaFrutas[i].Nombre;
                btn.Tag = listaFrutas[i].Id;
                btn.Click += BotonE_Click;
                flpFrutas.Controls.Add(btn);
            }
            flpFrutas.Visible = true;
        }

        private void BotonE_Click(object sender, EventArgs e) // para eliminar frutas
        {
            Button btn = (Button)sender;
            int num = Convert.ToInt32(btn.Tag);
            //int id2 = Convert.ToInt32(Interaction.InputBox("Introduce el id de la fruta que queires eliminar:"));
            conexion.eliminarFruta(num);
        }

        private void btnExclamacion_Click_1(object sender, EventArgs e)
        {
       
        }

        private String hacerPedido()
        {
           return "hola";
        }

        private void mandarMailPedido(String archivo)
        {
         
        }
    }
}
