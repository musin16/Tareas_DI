using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class Inicio : Form
    {
        String password = "12345";
        List<String> ProductosBajoMinimo = new List<string>();
        public Inicio()
        {
            InitializeComponent();
        }

        private void txtContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContrasena.Text.Equals(password))
                {
                    backEnd be = new backEnd();
                    be.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Constraseña incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public int mandarMensaje()
        {
            Random aleatorioPwd = new Random();
            int numero = aleatorioPwd.Next(1000000);
            try
            {
                string email = "augustobrigaprofe@gmail.com";
                string password = "rckpclnnjftzafbz";
                var loginInfo = new NetworkCredential(email, password);
                var msg = new MailMessage();
                var smtpClient = new SmtpClient("smtp.gmail.com", 25);
                msg.From = new MailAddress("melmouhcine03@educarex.es");
                msg.To.Add(new MailAddress("melmouhcine03@educarex.es"));
                msg.Subject = "Contraseña";

                msg.Body = "Se adjunta nueva contraseña: " + numero;
               
                msg.IsBodyHtml = true;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = loginInfo;
                smtpClient.Send(msg);
                smtpClient.Dispose();

                MessageBox.Show("Mensaje enviado");

                return numero;
            }
            catch (Exception)
            {
                MessageBox.Show("Mensaje no enviado");
                return -1;
            }
        }

        private void btnRecordar_Click(object sender, EventArgs e)
        {
            password = Convert.ToString(mandarMensaje());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
