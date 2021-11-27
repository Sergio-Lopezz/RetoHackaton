using System;
using EMigrant.App.Dominio;
using EMigrant.App.Persistencia;

namespace EMigrant.App.Consola
{
    class Program
    {
        private static IRepositorioMigrante _repoMigrante=new RepositorioMigrante(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddMigrante();
        }

        private static void AddMigrante(){
            var migrante=new Migrante{
                Nombres="Prueba",
                Apellidos="Prueba",
                TipoDocumento="Pasaporte",
                NDocumento="12345",
                PaisOrigen="Venezuela",
                FechaNacimiento="12/05/1980",
                Telefono="8789076",
                Correo="Prueba@",
                DireccionActual="Calle25",
                Ciudad="Manizales",
                SituacionLaboral="Desempleado"
            };
            var migranteAdicionado=_repoMigrante.AddMigrante(migrante);
        }
    }
}
