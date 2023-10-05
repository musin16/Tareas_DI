using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosFrutas_Avanzado
{
    internal class Frutas
    {
        private int id;
        private string nombre;
        private double precio;
        private byte[] imagen;

        public Frutas()
        {
        }

        public Frutas(int id, string nombre, double precio, byte[] imagen)
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
