using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Newtonsoft.Json;

namespace Pages.Model
{
    public class CartModel : PageModel
    {
        private IRepository _repo;

        public CartModel(IRepository repo)
        {
            _repo = repo;
        }
        public Dictionary<Item, int> CartItems { get; set; } = new Dictionary<Item, int>();
        public void OnGet()
        {
            var sessionCart = HttpContext.Session.Get<Dictionary<int, int>>("Cart");
            if (sessionCart != null)
            {
                foreach (var key in sessionCart.Keys)
                {
                    var item = _repo.GetItem(key);
                    CartItems[item] = sessionCart[key];
                }
            }
        }
    }
}
