using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EMPLEADO
{
    internal class Empleados
    {
        private string dni;
        private string nomb;
        private int nivel;
        private byte[] imagen;

        public Empleados()
        {
        }

        public Empleados(string dni, string nomb, int nivel, string imagen)
        {
            this.dni = dni;
            this.nomb = nomb;
            this.nivel = nivel;
            this.imagen = imagen;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nomb { get => nomb; set => nomb = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
