using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosFrutas_Avanzado
{
    public partial class FormInsertar : Form
    {
        ConectarBaseDeDatos conectar = new ConectarBaseDeDatos();
        List<Frutas> lisFrut2 = new List<Frutas>();
        String nombreFichero;
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(nombreFichero,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] bt=br.ReadBytes((int)fs.Length);
            conectar.insertar(txb_nombre.Text,Convert.ToDouble(txb_precio.Text),bt);
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
           // ofd.Filter = "Imagenes|*.jpg;*.png";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                nombreFichero = ofd.FileName;
                pictureBox1.Image = Image.FromFile(nombreFichero);
                DialogResult r = MessageBox.Show("Imagen seleccionada","informacion",MessageBoxButtons.YesNo);
                if (r==DialogResult.Yes)

                {
                    MessageBox.Show("Lo hiciste");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            byte[] bt = wb.DownloadData("https://th.bing.com/th/id/R.11655472cbc0539ab348d78d9afd45b8?rik=RQ8lXl1Kd9%2fU4A&pid=ImgRaw&r=0");
            MemoryStream ms=new MemoryStream(bt);
            System.Drawing.Image im= System.Drawing.Image.FromStream(ms);
            button2.BackgroundImage=im;
        }
    }
}
