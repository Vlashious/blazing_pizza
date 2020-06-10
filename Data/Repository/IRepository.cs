using System.Collections.Generic;
using Models;

namespace Data
{
    public interface IRepository
    {
        public Item GetItem(int id);
        public List<Item> GetItems(Item.ItemType itemType);
    }
}