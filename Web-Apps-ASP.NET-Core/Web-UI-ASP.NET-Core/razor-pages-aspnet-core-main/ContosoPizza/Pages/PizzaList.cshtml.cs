using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Services;
using ContosoPizza.Models;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        private readonly PizzaService _pizzaService;
        public IList<Pizza> PizzaList { get; set; } = default!;

        public PizzaListModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public void OnGet()
        {
            PizzaList = _pizzaService.GetPizzas();
        }

        [BindProperty]
        public Pizza NewPizza { get; set; } = default!;

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid || NewPizza == null)
            {
                return Page();
            }

            _pizzaService.AddPizza(NewPizza);

            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            _pizzaService.DeletePizza(id);

            return RedirectToAction("Get");
        }
    }
}
