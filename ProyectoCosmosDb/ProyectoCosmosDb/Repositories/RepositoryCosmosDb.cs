using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using ProyectoCosmosDb.Models;
using System;
using System.Collections.Generic;
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

        public List<Pelicula> BuscarPeliculasGenero(String genero)
        {
            //Indicamos que nos devuelvan todos los datos
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };

            IQueryable<Pelicula> query = this.client.CreateDocumentQuery<Pelicula>(
                    UriFactory.CreateDocumentCollectionUri(this.bbdd, this.collection), queryOptions)
                    .Where(x => x.Genero == genero);
            return query.ToList();
        }

    }
}
