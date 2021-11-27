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
        
    }
}