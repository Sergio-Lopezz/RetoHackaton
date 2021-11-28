using System.Collections.Generic;
using EMigrant.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EMigrant.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        Migrante AddMigrante(Migrante migrante);
        Migrante UpdateMigrante(Migrante migrante);
        Migrante GetMigrante(string idMigrante);
         
    }
}