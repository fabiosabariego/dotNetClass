using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
using System.Security.Cryptography.X509Certificates;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]      // Este Bing permite que a gente consiga acessar os dados daqui na nossa Pag CustomPizza.cshtml (Onde criamos todo Front da pagina)
        public PizzasModel Pizza { get; set; }

        public void OnGet()
        {

        }
    }
}
