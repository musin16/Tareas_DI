using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Prueba2_OCT6
{
    class conectarBd
    {
        MySqlConnection conexion;
        MySqlCommand cmd;
        MySqlDataReader dr;
        List<Fruta> lisfru = new List<Fruta>();
        public conectarBd()
        {
            conexion = new MySqlConnection("server=db4free.net;Database=dam2020;user=camachin2020;pwd=pruden2020;old guids=true");
            
        }
        internal List<Fruta> listarFrutas()
        {
            List<Fruta> lisfru2 = new List<Fruta>();
            conexion.Open();
            cmd = new MySqlCommand("select * from frutas", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Fruta f = new Fruta();
                f.Id = Convert.ToInt16(dr.GetString(0));
                f.Nombre = dr.GetString(1);
                f.Imagen = (byte[])dr["imagen"];
                f.Precio = Convert.ToDouble(dr.GetString(2));
                lisfru2.Add(f);
            }
            conexion.Close();
            return lisfru2;
        }
    }
}
