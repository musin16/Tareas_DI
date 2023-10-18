using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV
{
    internal class Facturacion
    {
        int indice;
        string mail;
        string cadenaPro;
        DateTime fecha;
        float total;
        public Facturacion() { }

        public Facturacion(int indice, string mail, string cadenaPro, DateTime fecha, float total)
        {
            this.Indice = indice;
            this.Mail = mail;
            this.CadenaPro = cadenaPro;
            this.Fecha = fecha;
            this.Total = total;
        }

        public int Indice { get => indice; set => indice = value; }
        public string Mail { get => mail; set => mail = value; }
        public string CadenaPro { get => cadenaPro; set => cadenaPro = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Total { get => total; set => total = value; }
    }
}
