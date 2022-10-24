using BackEnd_E1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_E1.Services
{
    public class PeliculasService
    {
      public List<Pelicula> ObtenerPeli()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 150,
                Pais = "USA",
                Publicacion = new DateTime(2012, 12, 11)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "SpiderMan",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2015, 05, 02)
            };
            return new List<Pelicula> { pelicula1, pelicula2 };
        }
      
    }
}