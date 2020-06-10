using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Pages.Model
{
    public class PizzasModel : PageModel
    {
        private IRepository _repo;

        public PizzasModel(IRepository repo)
        {
            _repo = repo;
        }
        public List<Item> Pizzas { get; private set; }
        public void OnGet()
        {
            var items = _repo.GetItems(Item.ItemType.Pizza);
            Pizzas = items;
        }
    }
}
