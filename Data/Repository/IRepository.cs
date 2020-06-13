using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public interface IRepository
    {
        public Item GetItem(int id);
        public List<Item> GetItems(Item.ItemType itemType);
        public void AddCustomer(Customer newCustomer);
        public Task<bool> SaveChanges();
    }
}