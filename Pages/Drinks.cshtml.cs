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
    public class DrinksModel : PageModel
    {
        private IRepository _repository;

        public DrinksModel(IRepository repo)
        {
            _repository = repo;
        }
        public List<Item> Drinks { get; set; }
        public void OnGet()
        {
            Drinks = _repository.GetItems(Item.ItemType.Drink);
        }
    }
}
