using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EMigrant.App.Dominio.Entidades
{
    public class Servicios
    {
        [Required(ErrorMessage = "El Campo es Requerido"), StringLength(15)]
        public int Id { get; set;}

        [Required(ErrorMessage = "El Nombre de Servicio es requerido"), StringLength(15)]
        public string Servicio { get; set;}
        
    }
}