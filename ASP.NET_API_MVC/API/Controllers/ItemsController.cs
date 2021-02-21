using API.Models;
using API.Repositories;
using API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class ItemsController : ApiController
    {
        IItemsRepository itemsRepository = new ItemRepository();
        public IHttpActionResult Post(Items items)
        {
            var result = itemsRepository.Create(items);
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
            var result = itemsRepository.Delete(id);
            if (result == 0)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Not Found", System.Text.Encoding.UTF8, "text/plain"),
                    StatusCode = HttpStatusCode.NotFound
                };
                throw new HttpResponseException(response);
            }
            return Ok();
        }
        public IHttpActionResult Put(Items items, int id)
        {
            var result = itemsRepository.Update(items, id);
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

        public IEnumerable<ItemsVM> Get()
        {
            return itemsRepository.GetAll();
        }


        public async Task<IHttpActionResult> Get(int id)
        {
            var result = await itemsRepository.Get(id);
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
