using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ALTURA
{
    internal class alturas
    {
        private String provincia;
        private String SituacionAltMaxima;
        private int alturaMaxima;
        private String SituacionAltMinima;
        private int alturaMinima;

        public alturas()
        {
        }

        public alturas(int alturaMinima, int alturaMaxima, string provincia, string situacionAltMaxima, string situacionAltMinima)
        {
            this.alturaMinima = alturaMinima;
            this.alturaMaxima = alturaMaxima;
            this.provincia = provincia;
            SituacionAltMaxima = situacionAltMaxima;
            SituacionAltMinima = situacionAltMinima;
        }

        public int AlturaMinima { get => alturaMinima; set => alturaMinima = value; }
        public int AlturaMaxima { get => alturaMaxima; set => alturaMaxima = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string SituacionAltMaxima1 { get => SituacionAltMaxima; set => SituacionAltMaxima = value; }
        public string SituacionAltMinima1 { get => SituacionAltMinima; set => SituacionAltMinima = value; }
    }
}
