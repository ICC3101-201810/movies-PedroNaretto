using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    class BaseDatos
    {
        public List<Pelicula> peliculas;
        List<Persona> personas;
        List<Estudio> estudios;
        List<PeliculaActor> peliculaActor;
        List<PeliculaProductor> peliculaProductor;

        public List<Pelicula> DesPeliculas()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPeliculas.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    peliculas = (List<Pelicula>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return peliculas;
        }

        public void SerPeliculas(List<Pelicula> peliculas)
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPeliculas.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, peliculas);
                }
            }
            catch (IOException)
            {
            }
        }

        public List<Persona> DesPersonas ()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPersonas.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    personas = (List<Persona>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return personas;
        }

        public void SerPersonas(List<Persona> personas)
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosPersonas.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, personas);
                }
            }
            catch (IOException)
            {
            }
        }

        public List<Estudio> DesEstudios()
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosEstudios.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    estudios = (List<Estudio>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }
            return estudios;
        }

        public void SerEstudios(List<Estudio> estudios)
        {
            try
            {
                using (Stream stream = File.Open("../../ArchivosData/DatosEstudios.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, estudios);
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
