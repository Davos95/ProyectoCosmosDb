using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoCosmosDb.Models;
using ProyectoCosmosDb.Repositories;

namespace ProyectoCosmosDb.Controllers
{
    public class PeliculasController : Controller
    {
        RepositoryCosmosDb repo;
        public PeliculasController(RepositoryCosmosDb repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Pelicula> peliculas = this.repo.GetPeliculas();

            return View();
        }
    }
}