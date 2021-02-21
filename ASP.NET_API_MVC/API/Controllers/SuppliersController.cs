using API.Models;
using API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class SuppliersController : ApiController
    {
        SupplierRepository supplierRepository = new SupplierRepository();
        public IHttpActionResult Post(Suppliers supplier)
        {
            var result = supplierRepository.Create(supplier);
            if (result == 0)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Terjadi Kesalahan", System.Text.Encoding.UTF8, "text/plain"),
                    StatusCode = HttpStatusCode.BadRequest
                };
                throw new HttpResponseException(response);
            }
           
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var result = supplierRepository.Delete(id);
            if (result == 0)
            {
                return Content(HttpStatusCode.NotFound, "Not Found");
            }
            return Ok();
        }
            
        public IHttpActionResult Put(Suppliers supplier, int id)
        {
            var result = supplierRepository.Update(supplier, id);
            if (result == 0)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Employee doesn't exist", System.Text.Encoding.UTF8, "text/plain"),
                    StatusCode = HttpStatusCode.NotFound
                };
                throw new HttpResponseException(response);
            }
            return Ok();
        }

        public IEnumerable<Suppliers> Get()
        {
            return supplierRepository.GetAll();
        }
            

        //public async Task<IEnumerable<Suppliers>> Get(int id)
        //{
        //    var result = await supplierRepository.Get(id);
        //    if (result != null)
        //    {
        //        if (result.Count() == 0)
        //        {
        //            var response = new HttpResponseMessage(HttpStatusCode.NotFound)
        //            {
        //                Content = new StringContent("Employee doesn't exist", System.Text.Encoding.UTF8, "text/plain"),
        //                StatusCode = HttpStatusCode.NotFound
        //            };
        //            throw new HttpResponseException(response);
        //        }
        //    return result;
        //    }
        //}

        public async Task<IHttpActionResult> Get(int id)
        {
            var result = await supplierRepository.Get(id);
            if (result != null)
            {
                if (result.Count() == 0)
                {
                    return Content(HttpStatusCode.NotFound, "Data Tidak Ditemukan");
                }
                return Ok(result);
            }
            return Content(HttpStatusCode.BadRequest, "Terjadi Kesalahan");
        }
    }
}
