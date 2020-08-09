using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LaureanoNews.Model
{
    public  class Noticie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} no puede estar vacio")]
        public string Titular { get; set; }
        [Required(ErrorMessage = "El Campo {0} no puede estar vacio")]
        public string Portada { get; set; }
        [Required(ErrorMessage = "El Campo {0} no puede estar vacio")]
        public string Contenido { get; set; }
        [Required(ErrorMessage = "El Campo {0} no puede estar vacio")]
        public string Resumen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public bool Publicado { get; set; }
        public string Creador { get; set; }
        public int Categoria { get; set; }
    }
}
