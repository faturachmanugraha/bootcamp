using API.Models;
using API.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace API.Repositories
{
    public class ItemRepository : IItemsRepository
    {
        DynamicParameters parameters = new DynamicParameters();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
        public int Create(Items items)
        {
            var SP_Net = "SP_insertItem";
            parameters.Add("@Name", items.Name);
            parameters.Add("@quantity", items.Quantity);
            parameters.Add("@price", items.Price);
            parameters.Add("@supplierId", items.SupplierId);
            var Create = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return Create;
        }

        public int Delete(int id)
        {
            var SP_Net = "SP_deleteItem";
            parameters.Add("@id", id);
            var Delete = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return Delete;
        }

        public async Task<IEnumerable<Items>> Get(int id)
        {
            var SP_Net = "SP_retrieveItemById";
            parameters.Add("@id", id);
            var GetbyId = await connection.QueryAsync<Items>(SP_Net,parameters, commandType: CommandType.StoredProcedure);
            return GetbyId ;
        }

        public IEnumerable<ItemsVM> GetAll()
        {
            var SP_Net = "SP_retrieveItem";
            var Get = connection.Query<ItemsVM>(SP_Net, commandType: CommandType.StoredProcedure);
            return Get;
        }

        public int Update(Items items, int id)
        {
            var SP_Net = "SP_updateItem";
            parameters.Add("@ID", id);
            parameters.Add("@Name", items.Name);
            parameters.Add("@quantity", items.Quantity);
            parameters.Add("@price", items.Price);
            parameters.Add("@supplierId", items.SupplierId);
            var Update = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return Update;
        }
    }
}