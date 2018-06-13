using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Estudio
    {
        public string Nombre;
        public string Direccion;
        public string FechaApertura;

        public Estudio(string nombre, string direccion, string fechaApertura)
        {
            Nombre = nombre;
            Direccion = direccion;
            FechaApertura = fechaApertura;
        }
    }
}
