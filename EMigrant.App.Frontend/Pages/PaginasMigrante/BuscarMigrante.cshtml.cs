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
    public class BuscarMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repoMigrante;

        public BuscarMigranteModel(IRepositorioMigrante _repoMigrante)
        {
            this._repoMigrante=_repoMigrante;
        } 
        
        [BindProperty]
        public Migrante Migrante { get; set;}

        public IActionResult OnGet(int migranteId)
        {
            Migrante =_repoMigrante.GetMigrante(migranteId.ToString());
            if (Migrante == null)
            { 
                //ViewBag.Message =" no encontrado"  ; 
                            
                return RedirectToPage("/Index");
                
            }
            else
            { 
                return Page();
            }
        }
    }
}