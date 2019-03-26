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
           

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(String accion)
        {
            if(accion == "CREAR")
            {
                await this.repo.CrearBBDD();
                ViewData["MENSAJE"] = "Base de datos creada";
                await this.repo.CrearColeccionPeliculas();
                ViewData["MENSAJE1"] = "Coleccion creada";
                List<Pelicula> peliculas = this.repo.CrearPeliculas();
                foreach (Pelicula peli in peliculas)
                {
                    await this.repo.InsertarPelicula(peli);
                }
                ViewData["MENSAJE2"] = "Peliculas insertadas";
            }
            
            return View();
        }

        public IActionResult VerPeliculas()
        {
            List<Pelicula> peliculas = this.repo.GetPeliculas();
            return View(peliculas);
        }

        public async Task<IActionResult> DetallesPeliculas(String idPelicula)
        {
            Pelicula pelicula = await this.repo.BuscarPeliculaAsync(idPelicula);
            return View(pelicula);
        }

        public async Task<IActionResult> EditPeliculas(String idPelicula)
        {
            Pelicula pelicula = await this.repo.BuscarPeliculaAsync(idPelicula);
            return View(pelicula);
        }

        [HttpPost]
        public async Task<IActionResult> EditPeliculas(Pelicula pelicula)
        {
            await this.repo.ModificarPelicula(pelicula);
            return RedirectToAction("VerPeliculas");
        }


    }
}