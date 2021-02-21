using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repositories.Interfaces
{
    interface IItemsRepository 
    {
        IEnumerable<ItemsVM> GetAll();
        Task<IEnumerable<Items>> Get(int id);
        int Create(Items items);
        int Update(Items items,int id);
        int Delete(int id);

    }
}
