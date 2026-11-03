using LibraryManagementSystem.Models;
namespace LibraryManagementSystem.Interfaces
{
    internal interface IItemService
    {
        void AddItem(Item item);
        void RemoveItem(int id);
        Item GetItemById(int id);
    }
}
