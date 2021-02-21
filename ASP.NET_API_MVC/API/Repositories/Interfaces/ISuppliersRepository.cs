using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repositories.Interfaces
{
    interface ISuppliersRepository
    {
        IEnumerable<Suppliers> GetAll();
        Task<IEnumerable<Suppliers>> Get(int id);
        int Create(Suppliers suppliers);
        int Update(Suppliers suppliers,int id);
        int Delete(int id);


    }
}
