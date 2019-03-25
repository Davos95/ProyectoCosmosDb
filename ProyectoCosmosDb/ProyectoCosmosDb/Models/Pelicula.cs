using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCosmosDb.Models
{
    public class Pelicula
    {
        [JsonProperty(PropertyName = "id")]
        public String Id { get; set; }
        public String Titulo { get; set; }
        public String TituloOriginal { get; set; }
        public String Sinopsis { get; set; }
        public String Genero { get; set; }
        public String Imagen { get; set; }

    }
}
