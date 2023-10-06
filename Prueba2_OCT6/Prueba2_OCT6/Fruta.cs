using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_OCT6
{
    class Fruta
    {

        int id;
        string nombre;
        double precio;
        byte[] imagen;

        public Fruta()
        {
        }

        public Fruta(int id, string nombre, double precio, byte[] imagen)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Imagen = imagen;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
