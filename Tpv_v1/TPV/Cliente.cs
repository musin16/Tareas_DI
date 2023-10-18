using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV
{
    internal class Cliente
    {
        string dni;
        string nombre;
        string email;
        int puntos;

        public Cliente() { }
        public Cliente(string dni, string nombre, string email, int puntos)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Email = email;
            this.Puntos = puntos;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
