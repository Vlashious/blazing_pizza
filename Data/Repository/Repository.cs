using System.Collections.Generic;
using System.Linq;
using Models;

namespace Data
{
    public class Repository : IRepository
    {
        private AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public Item GetItem(int id)
        {
            var item = _context.Items.FirstOrDefault(item => item.Id == id);
            return item;
        }

        public List<Item> GetItems(Item.ItemType itemType)
        {
            var items = _context.Items.Where(item => item.Type == itemType).ToList();
            return items;
        }
    }
}