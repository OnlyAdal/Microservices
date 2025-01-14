﻿using Microsoft.VisualBasic;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.api.Libreria.Core.Entities
{
    [BsonCollection("Libro")]
    public class LibroEntity : Document
    {
        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("precio")]
        public int Precio { get; set; }

        [BsonElement("fechaPublicacion")]
        public DateAndTime? FechaPublicacion { get; set; }

        [BsonElement("autor")]
        public AutorEntity Autor { get; set; }
    }
}
