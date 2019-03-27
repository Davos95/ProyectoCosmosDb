using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProyectoCosmosDb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCosmosDb.Repositories
{
    public class RepositoryCosmosDb
    {
        IConfiguration configuration;
        String bbdd;
        String collection;
        DocumentClient client;

        public RepositoryCosmosDb(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.bbdd = "PeliculasBBDD";
            this.collection = "PeliculasCollection";
            String endpoint = configuration["CosmosDb:endpoint"];
            String primarykey = configuration["CosmosDb:primarykey"];
            this.client = new DocumentClient(new Uri(endpoint), primarykey);
        }
        public async Task CrearBBDD()
        {
            Database bbdd = new Database() { Id = this.bbdd };
            await this.client.CreateDatabaseAsync(bbdd);
        }

        public async Task CrearColeccionPeliculas()
        {
            DocumentCollection collection = new DocumentCollection() { Id = this.collection };
            //Crea la URI de la base de datos para implementar la colleción
            await this.client.CreateDocumentCollectionAsync(UriFactory.CreateDatabaseUri(this.bbdd), collection);
        }

        public async Task InsertarPelicula(Pelicula peli)
        {
            await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection), peli);
        }

        public async Task ModificarPelicula(Pelicula peli)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, peli.Id);
            await this.client.ReplaceDocumentAsync(uri, peli);

        }

        public async Task EliminarPelicula(String idPelicula)
        {
            Uri uri = UriFactory.CreateDocumentUri(this.bbdd, this.collection, idPelicula);
            await this.client.DeleteDocumentAsync(uri);
        }

        public List<Pelicula> GetPeliculas()
        {
            //Indicamos el numero de documentos a recuperar
            FeedOptions options = new FeedOptions() { MaxItemCount = -1 }; //-1 te devuelven todos

            String sql = "SELECT * FROM c";

            Uri uri = UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection);
            IQueryable<Pelicula> consulta = this.client.CreateDocumentQuery<Pelicula>(uri, sql, options);
            return consulta.ToList();
        }

        public List<Pelicula> BuscarPeliculasGenero(String genero)
        {
            //Indicamos que nos devuelvan todos los datos
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };

            IQueryable<Pelicula> query = this.client.CreateDocumentQuery<Pelicula>(
                    UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection), queryOptions)
                    .Where(x => x.Genero == genero);
            return query.ToList();
        }

        public async Task<Pelicula> BuscarPeliculaAsync(String idPelicula)
        {
            Document document = await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(this.bbdd, this.collection, idPelicula));
            MemoryStream memory = new MemoryStream();
            using (var stream = new StreamReader(memory))
            {
                document.SaveTo(memory);
                memory.Position = 0;
                Pelicula pelicula = JsonConvert.DeserializeObject<Pelicula>(await stream.ReadToEndAsync());

                return pelicula;
            }
        }


        public List<Pelicula> CrearPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            Pelicula peli = new Pelicula
            {
                Id = "1",
                Titulo = "Regreso al futuro",
                TituloOriginal = "Back to the future",
                Genero = "Ciencia Ficcion",
                Sinopsis = "Una máquina del tiempo transporta a un adolescente a los años 50, cuando sus padres todavía estudiaban en la secundaria.",
                Imagen = "http://es.web.img3.acsta.net/c_215_290/pictures/14/03/11/10/30/351336.jpg"
            };
            peliculas.Add(peli);

            Pelicula peli2 = new Pelicula
            {
                Id = "2",
                Titulo = "Spider-man: Un nuevo universo",
                TituloOriginal = "Spider-man: into the spider-Verse",
                Genero = "Animacion",
                Sinopsis = "Luego de ser mordido por una araña radioactiva, el joven Miles Morales desarrolla misteriosos poderes que lo transforman en el Hombre Araña. Ahora deberá usar sus nuevas habilidades ante el malvado Kingpin, un enorme demente que puede abrir portales hacia otros universos.",
                Imagen = "http://t0.gstatic.com/images?q=tbn:ANd9GcQyfxXHWbpUJOUSgnBv2AyF0uL1Br9P3b_Erf1uB_gG8yZHUiv-"
            };
            peliculas.Add(peli2);

            Pelicula peli3 = new Pelicula
            {
                Id = "3",
                Titulo = "Origen",
                TituloOriginal = "Inception",
                Genero = "Ciencia Ficcion",
                Sinopsis = "Dom Cobb es un ladrón con una extraña habilidad para entrar a los sueños de la gente y robarles los secretos de sus subconscientes. Su habilidad lo ha vuelto muy popular en el mundo del espionaje corporativo, pero ha tenido un gran costo en la gente que ama. Cobb obtiene la oportunidad de redimirse cuando recibe una tarea imposible: plantar una idea en la mente de una persona. Si tiene éxito, será el crimen perfecto, pero un enemigo se anticipa a sus movimientos.",
                Imagen = "http://es.web.img3.acsta.net/c_215_290/medias/nmedia/18/72/41/74/20198901.jpg"
            };
            peliculas.Add(peli3);

            Pelicula peli4 = new Pelicula
            {
                Id = "4",
                Titulo = "Pesadilla antes de Navidad",
                TituloOriginal = "Nightmare Before Christmas",
                Genero = "Animacion",
                Sinopsis = "El rey de las calabazas en el pueblo de las brujas planea secuestrar a Santa Claus y al mismo tiempo llevar pánico en vez de alegría.",
                Imagen = "https://pics.filmaffinity.com/the_nightmare_before_christmas-136057718-large.jpg"
            };
            peliculas.Add(peli4);

            Pelicula peli5 = new Pelicula
            {
                Id = "5",
                Titulo = "Arrietty y el mundo de los diminutos",
                TituloOriginal = "Karigurashi no Arriety",
                Genero = "Animacion",
                Sinopsis = "Arrietty, una pequeña joven, vive con sus padres en una casa de los suburbios, a escondidas del dueño y la ama de casa. Como otros de su especie, Arrietty se mantiene oculta de sus anfitriones humanos, pero ocasionalmente se aventura más allá de los pisos en busca de azúcar y otros suministros. Una amistad secreta se forma cuando Shawn, de 12 años, conoce a Arrietty, pero su relación podría ser peligrosa para la familia de Arrietty.",
                Imagen = "http://es.web.img2.acsta.net/c_215_290/medias/nmedia/18/84/87/96/19769123.jpg"
            };
            peliculas.Add(peli5);

            return peliculas;
        }





    }
}
