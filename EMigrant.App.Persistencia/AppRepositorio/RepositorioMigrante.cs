using System.Net.Http;
using EMigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace EMigrant.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        //Se debe inicializar el AppContext() para trabjar desde el frontend
        private readonly AppContext _appContext = new AppContext();

            /*
          //Se utiliza cuando se trabaja con la .Consola
        
          private readonly AppContext _appContext;

          public RepositorioMigrante(AppContext appContext)
          {
              _appContext = appContext;
          }
        
        //######################################################
        */

        public Migrante AddMigrante(Migrante migrante)
        {
            var migranteAdicionado=_appContext.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }

        public IEnumerable<Migrante> GetAllMigrante()
        {
            return _appContext.Migrantes;
        }

        public Migrante GetMigrante(string idMigrante)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.NDocumento == idMigrante);
            return migranteEncontrado;
        }

        public Migrante UpdateMigrante(Migrante migrante)
        {
            var migranteEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.Id == migrante.Id);
            if (migranteEncontrado != null)
            {
                migranteEncontrado.Nombres = migrante.Nombres;
                migranteEncontrado.Apellidos = migrante.Apellidos;
                migranteEncontrado.TipoDocumento = migrante.TipoDocumento;
                migranteEncontrado.NDocumento = migrante.NDocumento;
                migranteEncontrado.PaisOrigen = migrante.PaisOrigen;
                migranteEncontrado.FechaNacimiento = migrante.FechaNacimiento;
                migranteEncontrado.Telefono = migrante.Telefono;
                migranteEncontrado.Correo = migrante.Correo;
                migranteEncontrado.DireccionActual = migrante.DireccionActual;
                migranteEncontrado.Ciudad = migrante.Ciudad;
                migranteEncontrado.SituacionLaboral = migrante.SituacionLaboral;

                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }
        
    }
}