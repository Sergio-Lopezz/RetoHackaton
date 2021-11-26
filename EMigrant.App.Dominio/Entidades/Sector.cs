using System;
using System.ComponentModel.DataAnnotations;

namespace EMigrant.App.Dominio.Entidades
{
    public class Sector
    {
        [Required(ErrorMessage = "El Campo es Requerido"), StringLength(15)]
        public int Id { get; set;}

        [Required(ErrorMessage = "El Nombre del Sector es requerido"), StringLength(15)]
        public string Servicio { get; set;}
    }
}