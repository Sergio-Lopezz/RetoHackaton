using System;
using System.ComponentModel.DataAnnotations;

namespace EMigrant.App.Dominio
{

    public class EntidadColaboradora
    
    {
    
        public int Id{ get;set; }

        [Required(ErrorMessage = "La razon social es obligatoria"), StringLength(100)]
        public string RazonSocial { get; set; }
        
        [Required(ErrorMessage = "El NIT es obligatorio"), StringLength(15)]
        public string Nit { get; set; }

        [Required(ErrorMessage = "La direcion es obligatoria"), StringLength(150)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria"), StringLength(30)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio"), StringLength(15)]
        public string Telefono { get; set; }

        public string DireccionElectronica { get; set; }

        public string PaginaWeb { get; set; }

        [Required(ErrorMessage = "El sector es obligatorio"), StringLength(50)]
        public string Sector { get; set; }

        public  TipoServicio TipoServicio{ get; set; }

    }
}