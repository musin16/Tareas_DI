using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MotorGestorFinal
{

    internal class concectarBD
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader data;
        public static List<String> conectarse = new List<String>();

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

        internal void insertar(string consulta)
        {
            cn.Open();
            cn.Close();
        }

        internal List<string> listarBasesDeDatos(string consulta)
        {
          List<string> list = new List<string>();
            cn.Open();
            cmd=new MySqlCommand(consulta, cn);
            data= cmd.ExecuteReader();
            int numFila = data.VisibleFieldCount;
            list.Add(data.GetName(0) +"\t\t|");
            list.Add(" -----------------------------------------------");
            while (data.Read())
            {
                
                list.Add(data.GetString(0));
            }
            cn.Close(); 
            return list;
        }

        internal void modificar(string consulta)
        {
            cn.Open();
            cn.Close();
        }

        internal List<string> select(string consulta)
        {
            List<string> valores = new List<string>();
            cn.Open();
            cmd = new MySqlCommand("Select * from " + consulta,cn);
            int filas= data.VisibleFieldCount;
            data=cmd.ExecuteReader();
            while (data.Read())
            {
                valores.Add(data.GetString(0));
            }
            cn.Close();
            return valores;
        }

    }
}
