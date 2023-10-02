using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CRUD_EMPLEADO
{
    internal class ConectarBd
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        List<Empleados> listEmpleados=new List<Empleados>();

        public ConectarBd()
        {
            conn=new MySqlConnection();

            conn.ConnectionString = "server=db4free.net;Database=dam2024;" +
                "user=vituki;password=pilukina2024;old guids=true";

        }

        internal List<Empleados> conectar()
        {
            conn.Open();
            String consulto = "SELECT * FROM empleados";
            cmd = new MySqlCommand(consulto,conn);
            dr = cmd.ExecuteReader();
            while (dr.Read()){
                Empleados em= new Empleados();
                em.Dni = dr.GetString(0);
                em.Nomb=dr.GetString(1);
                em.Nivel=Convert.ToInt16(dr.GetString(2));
                em.Imagen = dr.GetString(3);
                listEmpleados.Add(em);

            }
            conn.Close();
            return listEmpleados;
        }

        internal void insertar(string dni, string nomb, short nive, string img)
        {
            conn.Open();
            String consulta = "Insert into empleados values (?dni,?nom,?niv,?img)";
            cmd = new MySqlCommand(consulta, conn);
            cmd.Parameters.AddWithValue("?dni", dni);
            cmd.Parameters.AddWithValue("?nom", nomb);
            cmd.Parameters.AddWithValue("?niv", nive);
            cmd.Parameters.AddWithValue("?img", img);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}
