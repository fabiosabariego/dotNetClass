using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {

        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDBContext _context;

        public OrdersModel(ApplicationDBContext context)
        {
            this._context = context;
        }

        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
