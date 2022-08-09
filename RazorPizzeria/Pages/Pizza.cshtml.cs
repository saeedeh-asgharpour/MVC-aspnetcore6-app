using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle="Bolognese" ,
                PizzaName = "Bolognese",
                BasePrise=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4 },
                new PizzasModel() { ImageTitle="Carbonara" ,
                PizzaName = "Carbonara",
                BasePrise=4,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4 },
                new PizzasModel() { ImageTitle="Create" ,
                PizzaName = "Create",
                BasePrise=5,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=8 },
                new PizzasModel() { ImageTitle="Margerita" ,
                PizzaName = "Margerita",
                BasePrise=3,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5 },
                new PizzasModel() { ImageTitle="MeatFeast" ,
                PizzaName = "MeatFeast",
                BasePrise=6,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4 },
                new PizzasModel() { ImageTitle="Mushroom" ,
                PizzaName = "Mushroom",
                BasePrise=7,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=10 },
                new PizzasModel() { ImageTitle="order" ,
                PizzaName = "order",
                BasePrise=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4 },
                new PizzasModel() { ImageTitle="Seafood" ,
                PizzaName = "Seafood",
                BasePrise=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=7 }

        };
        public void OnGet()
        {
        }
    }
}
