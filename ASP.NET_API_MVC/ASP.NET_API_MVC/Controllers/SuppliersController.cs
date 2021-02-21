using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_API_MVC.Controllers
{
    public class SuppliersController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44393/API/")
        };
        // GET: Suppliers
        public ActionResult Index()
        {
            IEnumerable<Suppliers> suppliers = null;
            var responTask = client.GetAsync("Suppliers");
            responTask.Wait();
            var result = responTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Suppliers>>();
                readTask.Wait();
                suppliers = readTask.Result;
            }
            return View(suppliers);
        }



        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Suppliers suppliers)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("Suppliers", suppliers).Result;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            //IEnumerable<Suppliers> suppliers = null;
            //var responseTask = client.GetAsync("Suppliers?id=" + id.ToString());
            //responseTask.Wait();
            //var result = responseTask.Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var readTask = result.Content.ReadAsAsync<IList<Suppliers>>();
            //    readTask.Wait();
            //    suppliers = readTask.Result;
            //}
            //return View(suppliers);
            return View();
        }   

        [HttpPost]
        public ActionResult Edit(Suppliers suppliers)
        {
            HttpResponseMessage response= client.PutAsJsonAsync("Suppliers/" + suppliers.ID, suppliers).Result;
            //put.Wait();
            return RedirectToAction("Index");
            
            //HttpResponseMessage response = client.PutAsJsonAsync("Suppliers", suppliers).Result;
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            
            var delete = client.DeleteAsync("Suppliers/" + id.ToString());
            delete.Wait();
            var result = delete.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            IEnumerable<Suppliers> suppliers = null;
            var responseTask = client.GetAsync("Suppliers/" + id.ToString());
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Suppliers>>();
                readTask.Wait();
                suppliers = readTask.Result;
            }
             return View(suppliers.FirstOrDefault(s=> s.ID == id));
        }

    }
}