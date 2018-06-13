using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Persona
    {
        public string rol;
        public string Nombre;
        public string Apellido;
        public string FechaDeNacimiento;
        public string Biografia;

        public Persona(string nombre, string apellido, string fechaDeNacimiento, string biografia)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            Biografia = biografia;
        }
    }

    class Actor : Persona
    {
        string rol = "Actor";
        public Actor(string nombre, string apellido, string fechaDeNacimiento, string biografia) : base(nombre, apellido, fechaDeNacimiento, biografia)
        {
        }
    }

    class Director : Persona
    {
        string rol = "Director";
        public Director(string nombre, string apellido, string fechaDeNacimiento, string biografia) : base(nombre, apellido, fechaDeNacimiento, biografia)
        {
        }
    }

    class Productor : Persona
    {
        string rol = "Productor";
        public Productor(string nombre, string apellido, string fechaDeNacimiento, string biografia) : base(nombre, apellido, fechaDeNacimiento, biografia)
        {
        }
    }
}
