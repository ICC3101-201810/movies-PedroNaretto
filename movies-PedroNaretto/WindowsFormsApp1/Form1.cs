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
    public partial class Form1 : Form
    {
        BaseDatos baseDatos;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)     
                try
                {
                    listBox1.Items.Clear();
                    List<Pelicula> listapel = baseDatos.DesPeliculas().Where(x => x.Nombre.Contains(textBox1.Text) || x.Descripción.Contains(textBox1.Text)).ToList();
                    List<Persona> listaper = baseDatos.DesPersonas().Where(x => x.Nombre.Contains(textBox1.Text) || x.Apellido.Contains(textBox1.Text)).ToList();
                    List<Estudio> listaest = baseDatos.DesEstudios().Where(x => x.Nombre.Contains(textBox1.Text) || x.Direccion.Contains(textBox1.Text)).ToList();

                    int c = 0;
                    while (c < 50 || listBox1.Items.Count <= 50)
                    {
                        if (listapel.Count() > c && listBox1.Items.Count <= 50)
                            listBox1.Items.Add("Pelicula: " + listapel[c].Nombre + ", Descripcion: " + listapel[c].Descripción);
                        if (listaper.Count() > c && listBox1.Items.Count <= 50)
                            listBox1.Items.Add(listaper[c].rol +": " + listaper[c].Nombre + listaper[c].Apellido);
                        if (listaest.Count() > c && listBox1.Items.Count <= 50)
                            listBox1.Items.Add("Estudio: " + listaest[c].Nombre + ", Direccion: " + listaest[c].Direccion);
                        c += 1;
                    }

                }
                catch { }
        }

        private void PeliculasBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listas ListaPeliculas = new Listas("Peliculas", textBox1.Text);
            ListaPeliculas.ShowDialog();
        }
    }
}
