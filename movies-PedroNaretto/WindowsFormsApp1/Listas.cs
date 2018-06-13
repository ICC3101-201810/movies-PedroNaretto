using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Listas : Form
    {
        BaseDatos baseDatos = new BaseDatos();
        string tipo;
        string text;
        public Listas(string tipo, string text)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.text = text;
        }

        private void Listas_Load(object sender, EventArgs e)
        {
            if (tipo == "Peliculas")
            {
                List<Pelicula> listapel = baseDatos.DesPeliculas().Where(x => x.Nombre.Contains(text) || x.Descripción.Contains(text)).ToList();
                foreach (Pelicula pelicula in listapel)
                {
                    listBox1.Items.Add("Pelicula: " + pelicula.Nombre + ", Descripcion: " + pelicula.Descripción);
                }
            }
            List<Persona> listaper = baseDatos.DesPersonas().Where(x => x is Actor && x.Nombre.Contains(text) || x.Apellido.Contains(text)).ToList();
            if (tipo == "Actores")
            {
                foreach (Actor actor in listaper)
                {
                    listBox1.Items.Add("Actor: " + actor.Nombre +" " + actor.Apellido);
                }
            }

            if (tipo == "Directores")
            {
                foreach (Director actor in listaper)
                {
                    listBox1.Items.Add("Director: " + actor.Nombre + " " + actor.Apellido);
                }
            }

            if (tipo == "Productor")
            {
                foreach (Productor actor in listaper)
                {
                    listBox1.Items.Add("Productor: " + actor.Nombre + " " + actor.Apellido);
                }
            }

            if (tipo == "Estudios")
            {
                List<Estudio> listaest = baseDatos.DesEstudios().Where(x => x.Nombre.Contains(text) || x.Direccion.Contains(text)).ToList();
                foreach (Estudio estudio in listaest)
                {
                    listBox1.Items.Add("Estudio: " + estudio.Nombre + ", Direccion: " + estudio.Direccion);
                }
            }
        }
    }
}
