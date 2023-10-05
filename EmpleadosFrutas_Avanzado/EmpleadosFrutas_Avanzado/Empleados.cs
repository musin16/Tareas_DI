using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosFrutas_Avanzado
{
    internal class Empleados
    {
        String dni;
        string nombre;
        int nivel;
        string imagen;
        public Empleados()
        {
        }

        public Empleados(string dni, string nombre, int nivel, string imagen)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Imagen = imagen;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
