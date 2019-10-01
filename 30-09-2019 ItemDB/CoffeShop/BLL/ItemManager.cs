using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeShop.Repository;

namespace CoffeShop.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();

        public bool Add(string name, double Price)
        {
            return _itemRepository.Add(name,Price);
        }
        public bool CheckUniqueName(string name)
        {
            return _itemRepository.CheckUniqueName(name);
        }
        public DataTable showResult()
        {
            return _itemRepository.showResult();
        }
       
    }
}
