using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CRUD_ALTURA
{
    internal class ConectarBd
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public List<alturas> listaAltura=new List<alturas>();
        public ConectarBd()
        {
        }
        public List<alturas> consultar()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;Database=dam2023;user=root;password='';old guids=true";
            conn.Open();
            String consulta = "Select * From alturas";
            cmd = new MySqlCommand(consulta,conn);
            dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                alturas alt2 = new alturas();
                alt2.Provincia = dr.GetString(0);
                alt2.SituacionAltMaxima1 = dr.GetString(1);
                alt2.AlturaMaxima =Convert.ToInt16(dr.GetString(2));
                alt2.SituacionAltMinima1 = dr.GetString(3);
                alt2.AlturaMinima = Convert.ToInt16(dr.GetString(4));
                listaAltura.Add(alt2);
            }
            conn.Close(); 
            return listaAltura;
        }

        internal void insertarAltura(string provincia, string situMax, int latMax, string situMin, int latMin)
        {
            conn.Open();
            String consulta = "Insert into alturas VALUES (?prov,?situMax,?altMax,?sitMin,?altMin)";
            cmd = new MySqlCommand(consulta, conn);
            cmd.Parameters.AddWithValue("?prov",provincia);
            cmd.Parameters.AddWithValue("?situMax",situMax);
            cmd.Parameters.AddWithValue("?altMax",latMax);
            cmd.Parameters.AddWithValue("?sitMin", situMin);
            cmd.Parameters.AddWithValue("?altMin", latMin);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
