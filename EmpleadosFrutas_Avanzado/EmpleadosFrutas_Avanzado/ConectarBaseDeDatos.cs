using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmpleadosFrutas_Avanzado
{
    internal class ConectarBaseDeDatos
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;
        List<Frutas> listF=new List<Frutas>();
        List<Empleados> listE= new List<Empleados>();
        public ConectarBaseDeDatos()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString= "server=localhost;Database=dam2023;user=root;password='';old guids=true";
        }

        internal List<Frutas> examinar()
        {
            conexion.Open();
            comando= new MySqlCommand("Select * From frutas",conexion);
            datos=comando.ExecuteReader();
            while (datos.Read())
            {
                Frutas f=new Frutas();
                f.Id = Convert.ToInt16(datos.GetString(0));
                f.Nombre=datos.GetString(1);
                f.Precio=Convert.ToDouble(datos.GetString(2));
                f.Imagen = (byte[]) datos["imagen"]; 
                listF.Add(f);
            }
            conexion.Close();
            return listF;
        }
        internal List<Empleados> examinarEMP()
        {
            conexion.Open();
            comando = new MySqlCommand("Select * From empleados", conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Empleados f = new Empleados();
                f.Dni =datos.GetString(0);
                f.Nombre = datos.GetString(1);
                f.Nivel = Convert.ToInt16(datos.GetString(2));
                f.Imagen = datos.GetString(3);
                listE.Add(f);
            }
            conexion.Close();
            return listE;
        }

        internal void insertar(string name, double prex, byte[] image)
        {
            conexion.Open();
            comando = new MySqlCommand("INSERT INTO frutas VALUES(null,?nom,?pre,?img,1)",conexion);
            comando.Parameters.AddWithValue("?nom",name);
            comando.Parameters.AddWithValue("?pre",prex);
            comando.Parameters.AddWithValue("?img",image);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        internal void modificar(string name, double preci, int id)
        {
            conexion.Open();
            comando = new MySqlCommand("UPDATE frutas SET nombre=@nom,precio=@pre WHERE id=@id",conexion);
            comando.Parameters.AddWithValue("@nom",name);
            comando.Parameters.AddWithValue("@pre",preci);
            comando.Parameters.AddWithValue("@id",id);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
