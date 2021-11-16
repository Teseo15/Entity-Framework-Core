﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_Core.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public int ArtistaID { get; set; }
        //public Artista Artista { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public double Precio { get; set; }
        public int Anio { get; set; }
    }

}