using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pelicula
    {
        public string Nombre;
        public string Director;
        public string FechaDeEstreno;
        public string Descripción;
        public string Presupuesto;
        public string Estudio;

        public Pelicula(string nombre, string director, string fechaDeEstreno, string descripción, string presupuesto, string estudio)
        {
            Nombre = nombre;
            Director = director;
            FechaDeEstreno = fechaDeEstreno;
            Descripción = descripción;
            Presupuesto = presupuesto;
            Estudio = estudio;
        }
    }
}
