using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_API_MVC.Controllers
{
    public class ItemsController : Controller
    {
        private MyContext myContext = new MyContext();
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44393/API/")
        };
        // GET: Items
        public ActionResult Index()
        {
            IEnumerable<ItemsVM> items = null;
            var responTask = client.GetAsync("Items");
            responTask.Wait();
            var result = responTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<ItemsVM>>();
                readTask.Wait();
                items = readTask.Result;
            }
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Items items)
        {
            //List<Suppliers> list = myContext.suppliers.ToList();
            //ViewBag.SuppliersList = new SelectList(list, "supplierName");
            HttpResponseMessage response = client.PostAsJsonAsync("Items", items).Result;
            return RedirectToAction("Index");
        }
    }
}