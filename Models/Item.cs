using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Item
    {
        public enum ItemType
        {
            Pizza,
            Drink,
            All
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public ItemType Type { get; set; }
        public string Image { get; set; }
    }
}