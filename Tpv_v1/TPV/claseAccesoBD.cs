using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TPV
{
    class claseAccesoBD
    {
        List<claseFruta> listaFrutas = new List<claseFruta>();

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;

        public claseAccesoBD ()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;Database=dam2023;user=root;pwd='';old guids=true";
        }

        public List<claseFruta> listarFrutas()
        {
           List<claseFruta> listFrut = new List<claseFruta>();
           conexion.Open();
           comando=new MySqlCommand("Select * from frutas where activo=1",conexion);
           datos=comando.ExecuteReader();
            while (datos.Read())
            {
                claseFruta ft=new claseFruta(); 
                ft.Id =Convert.ToInt16(datos.GetString(0));
                ft.Nombre = datos.GetString(1);
                ft.Precio =(float)datos["precio"];
                ft.Imagen = (byte[])datos["imagen"];
                ft.Stock = Convert.ToInt64(datos.GetString(4));
                listFrut.Add(ft);
            }
           conexion.Close();
            return listFrut;   
        }

        internal void modificarStock(List<claseCesta> listaCesta, List<claseFruta> listaFrutas) //Cambiar stock al pagar
        {
            conexion.Open();

           for(int i = 0;i< listaCesta.Count;i++) { 
                comando = new MySqlCommand("Update frutas SET stock=stock-@listCes where nombre=@lisFru", conexion);
                comando.Parameters.AddWithValue("@listCes", listaCesta[i].Peso);
                comando.Parameters.AddWithValue("@lisFru", listaCesta[i].Nombre);
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }

        internal void insertarStock(double stock, int id) // Añadir stock a  la fruta
        {
            conexion.Open();
            comando=new MySqlCommand("Update frutas SET stock=stock+@stok where id=@id",conexion);
            comando.Parameters.AddWithValue("@stok",stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.Close() ;
        }

        internal void insertarFruta(int id, string nombre, string precio, byte[] imagen, string stock)
        {
            conexion.Open();
            comando = new MySqlCommand("Insert into frutas values(@id,@nom,@pre,@img,@stok,1)", conexion);
            float num = float.Parse(precio);
            int sto = Convert.ToInt16(stock);
            comando.Parameters.AddWithValue("@id",id);
            comando.Parameters.AddWithValue("@nom",nombre);
            comando.Parameters.AddWithValue("@pre",num);
            comando.Parameters.AddWithValue("@img",imagen);
            comando.Parameters.AddWithValue("@stok",sto);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        internal void eliminarFruta(int id)
        {
            conexion.Open();
            comando = new MySqlCommand("Update frutas SET activo=0 where id=@id", conexion);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery() ;
            conexion.Close();
        }

        internal void modificarFruta(string id, string nombre, string precio, byte[] imagen, string procedencia, string stock)
        {
          
        }
    }
}
