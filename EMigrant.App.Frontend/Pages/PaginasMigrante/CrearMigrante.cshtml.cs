using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Persistencia;
using EMigrant.App.Dominio;

namespace EMigrant.App.Frontend.Pages.PaginasMigrante
{
    public class CrearMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repoMigrante;

        public CrearMigranteModel(IRepositorioMigrante _repoMigrante)
        {
            this._repoMigrante=_repoMigrante;
        }    

        public Migrante migrante { get; set;}

        public void OnGet()
        {
            migrante=new Migrante();
        }

        public IActionResult OnPost(Migrante migrante)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var migranteAdicionado=_repoMigrante.AddMigrante(migrante);
            //return RedirectToPage("");
            return Page();
        }
        
    }
}
