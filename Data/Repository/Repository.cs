using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);

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

        public async Task<bool> SaveChanges()
        {
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}