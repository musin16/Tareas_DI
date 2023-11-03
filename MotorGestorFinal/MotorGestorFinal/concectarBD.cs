using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MotorGestorFinal
{

    internal class concectarBD : MySqlBackup
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader data;
        public static List<String> conectarse = new List<String>();
        String origen = "C:\\Seguridad\\baseDatosCopia.sql";

        public concectarBD()
        {
        }

        public concectarBD(String server,String bd,String user,String pwd) {
            conectarse.Add(server);
            conectarse.Add(bd);
            conectarse.Add(user);
            conectarse.Add(pwd);
             cn = new MySqlConnection("Server=" + server + ";Database=" + bd + ";user=" + user + ";pwd=" + pwd+";old guids=true") ;
            
        }

        internal List<string> listarBasesDeDatos(string consulta)
        {
          List<string> list = new List<string>();
            cn.Open();
            cmd=new MySqlCommand(consulta, cn);
            data= cmd.ExecuteReader();
            int numFila = data.VisibleFieldCount;
            while (data.Read())
            {
                list.Add(data.GetString(0));
            }
            cn.Close(); 
            return list;
        }


        internal List<string> select(string consulta)
        {
            List<string> valores = new List<string>();
            cn.Open();
            cmd = new MySqlCommand("Select * from " + consulta,cn);
            data=cmd.ExecuteReader();
            int filas = data.VisibleFieldCount;
            while (data.Read())
            {
                String linea = "";
                for (int i=0;i<filas;i++)
                {
                    linea+= data.GetString(i)+";";
                }
                valores.Add(linea);
            }
            cn.Close();
            return valores;
        }

        internal void executarInserModiMucho(string consulta)
        {
            cn.Open();
            cmd=new MySqlCommand(consulta,cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        internal List<String> listarRas(string consulta)
        {
            List<String> n = new List<string>();
            cn.Open();
            cmd = new MySqlCommand("select * from " + consulta, cn);
            data=cmd.ExecuteReader();
            data.Read();
            int pos = data.VisibleFieldCount;
            for (int i = 0; i < pos; i++)
            {
                n.Add(data.GetName(i)); 
            }
            cn.Close();
            return n;
        }

        internal void importar(string nombre)
        {
            cn.Open();
            cmd=new MySqlCommand();
            cmd.Connection = cn;
            MySqlBackup mysql = new MySqlBackup(cmd);
            mysql.ImportFromFile(nombre);
            cn.Close();
          
        }
        internal void exportar(string nombre)
        {
            cn.Open();
                cmd =new MySqlCommand();
                cmd.Connection=cn;
                MySqlBackup mysql = new MySqlBackup(cmd);
                mysql.ExportInfo.AddCreateDatabase = true;
                mysql.ExportToFile(nombre);
                escribirFichero(nombre);
                File.Delete(nombre);
            cn.Close();
        }


        private void escribirFichero(string nombreGeneral)
        {
         
           File.WriteAllText("C:\\Seguridad\\baseDatosCompleta2",File.ReadAllText(("C:\\Seguridad\\baseDatosCompleta2") + File.ReadAllText(nombreGeneral));
            StreamWriter streamWriter = new StreamWriter("C:\\Seguridad\\baseDatosCompleta", true);
            StreamReader streamReader = new StreamReader(nombreGeneral);
            String linea = "";
            while((linea=streamReader.ReadLine())!=null)
            {
                streamWriter.WriteLine(linea);
            }
            streamReader.Close();
            streamWriter.Close();
        }
        private void insertar(String nombre)
        {
            cn.Open();
            cmd=new MySqlCommand();
            cn.Close();
            String letra = "";
            letra.Replace(";", ",");
        }
    }
}
