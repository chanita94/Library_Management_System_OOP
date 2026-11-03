using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    internal class ItemService : IItemService
    {
        private readonly List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            items.Add(item);
        }
        public void RemoveItem(int id)
        {
            if (id == 0)
                throw new ArgumentOutOfRangeException(nameof(id));
            items.RemoveAll(item=>item.ItemId==id);
        }
        public Item GetItemById(int id)
        {
            if (id == 0)
                throw new ArgumentOutOfRangeException(nameof(id));
            Item item = items.FirstOrDefault(item => item.ItemId == id);
            return item;
        }
    }
}
