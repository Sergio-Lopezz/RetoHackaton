using System;
namespace EMigrant.App.Dominio
{

    public class EntidadColaboradora
    
    {
    
        public int Id{ get;set; }

        public string RazonSocial { get; set; }

        public string Nit { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Telefono { get; set; }

        public string DireccionElectronica { get; set; }

        public string PaginaWeb { get; set; }

        public string Sector { get; set; }

        public TipoServicio TipoServicio{ get; set; }

    }
}