using System;
using System.ComponentModel.DataAnnotations;

namespace EMigrant.App.Dominio
{
    
    public class Migrante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio"), StringLength(15)]
        public string Nombres { get; set;}

        [Required(ErrorMessage = "El Apellido es Obligatorio"), StringLength(15)]
        public string Apellidos { get; set;}

        [Required(ErrorMessage = "El Tipo de Documento es Obligatorio"), StringLength(15)]
        public string TipoDocumento { get; set;}

        [Required(ErrorMessage = "El Numero de Documento es Obligatorio"), StringLength(15)] 
        public string NDocumento { get; set;}
        
        [Required(ErrorMessage = "El Pais de origen es Obligatorio"), StringLength(15)]
        public string PaisOrigen { get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Fecha De Nacimiento")]
        [Required(ErrorMessage="Fecha de Nacimiento Obligatoria")]
        public string FechaNacimiento { get; set;}

        public string Telefono { get; set;}
        public string Correo { get; set;}
        public string DireccionActual { get; set;}
        public string Ciudad { get; set;}
        public string SituacionLaboral { get; set;}

    }
}