using System;
using System.ComponentModel.DataAnnotations;

namespace EMigrant.App.Dominio
{
    public class Migrante
    {

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

        [Required(ErrorMessage = "La Fecha de Nacimiento es Obligatoria"), StringLength(15)]
        public string FechaNacimiento { get; set;}
        
        public string Telefono { get; set;}
        public string Correo { get; set;}
        public string DireccionActual { get; set;}
        public string Ciudad { get; set;}
        public string SituacionLaboral { get; set;}

    }
}