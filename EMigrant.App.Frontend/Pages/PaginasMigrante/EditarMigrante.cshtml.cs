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
    public class EditarMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _repoMigrante;

        public EditarMigranteModel(IRepositorioMigrante _repoMigrante)
        {
            this._repoMigrante=_repoMigrante;
        } 
        
        [BindProperty]
        public Migrante Migrante { get; set;}

        public IActionResult OnGet(int migranteId)
        {
            Migrante =_repoMigrante.GetMigrante(migranteId);
            if (Migrante == null)
            { 
                return RedirectToPage("./NotFound");
            }
            else
            { 
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            { 
                Migrante = _repoMigrante.UpdateMigrante(Migrante);
            }
            //return RedirectToPage("../Migrante1/Migrante/");
            return Page();
        }
        
    }
}