using API.Models;
using API.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace API.Repositories
{
    public class SupplierRepository : ISuppliersRepository
    {
        DynamicParameters parameters = new DynamicParameters();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString); //my connection disamakan dengan nama yang di web config
        public int Create(Suppliers supplier)
        {
            //if (supplier == null || supplier.SupplierName == null)
            //{
            //    var response = new HttpResponseMessage(HttpStatusCode.NotFound)
            //    {
            //        Content = new StringContent("Employee doesn't exist", System.Text.Encoding.UTF8, "text/plain"),
            //        StatusCode = HttpStatusCode.NotFound
            //    };
            //    throw new HttpResponseException(response);
            //}
            var SP_Net = "SP_insertSupplier";
            parameters.Add("@SupplierName", supplier.SupplierName);
            var Create = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            if (Create == 0)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Employee doesn't exist", System.Text.Encoding.UTF8, "text/plain"),
                    StatusCode = HttpStatusCode.NotFound
                };
                throw new HttpResponseException(response);
            }
            return Create;
        }

        public int Delete(int id)
        {
            var SP_Net = "SP_deleteSupplier";
            parameters.Add("@ID", id);
            var Delete = connection.Execute(SP_Net,parameters, commandType: CommandType.StoredProcedure);
            return Delete;

        }

        public IEnumerable<Suppliers> GetAll()
        {

            var SP_Net = "SP_retrieveSupplier";
            var Get = connection.Query<Suppliers>(SP_Net, commandType: CommandType.StoredProcedure);
            return Get;
            //throw new NotImplementedException();

        }

        public async Task<IEnumerable<Suppliers>> Get(int id)
        {

            var SP_Net = "SP_retrieveSupplierById";
            parameters.Add("@ID", id);
            
            var Get = await connection.QueryAsync<Suppliers>(SP_Net,parameters, commandType: CommandType.StoredProcedure);
                


            return Get;
        }

        public int Update(Suppliers supplier, int id)
        {
            var SP_Net = "SP_updateSupplier";
            parameters.Add("@ID", id);
            parameters.Add("@SupplierName", supplier.SupplierName);
            var Update = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return Update;
           
        }
    }
}