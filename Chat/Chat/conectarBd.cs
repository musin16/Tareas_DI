using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Chat
{
    class conectarBd
    {
        MySqlConnection conexion;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public conectarBd()
        {
            conexion = new MySqlConnection("server=4dbfree.net;Database=chatfaimus;user=faimus;pwd=faimus1234;old guids=true");
            
        }

        internal void enviar(string mensaje,int numMe)
        {
            conexion.Open();
            cmd = new MySqlCommand("INSERT INTO mensaje VALUES(2,@mensaje,@numMensa)",conexion);
            cmd.Parameters.AddWithValue("@mensaje",mensaje);
            cmd.Parameters.AddWithValue("@numMensa",mensaje);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        internal void refrescar(int numM)
        {
            conexion.Open();
            string letra = "";
            cmd = new MySqlCommand("SELECT mensaje FROM id=1 and mensajeN= "+numM,conexion);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string letra = "";
            }
            conexion.Close();
        }
        internal int maximoNumMensaje()
        {
            conexion.Open();
            int num = 0;
            cmd = new MySqlCommand("SELECT MAX(mensajeN) FROM id=1",conexion);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 num = Convert.ToInt16(reader.GetString(0));
            }
            conexion.Close();
            return num;
        }
    }

}
