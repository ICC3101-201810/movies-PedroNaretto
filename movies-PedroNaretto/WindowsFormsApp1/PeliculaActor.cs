﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PeliculaActor
    {
        public Pelicula pelicula;
        public Actor actor;

        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
