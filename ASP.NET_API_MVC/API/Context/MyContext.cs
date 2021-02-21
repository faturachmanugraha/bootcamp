using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base ("ASP.NET_API_MVC") //define nama database
        {

        }

        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<Items> items { get; set; }

        public System.Data.Entity.DbSet<API.Models.ItemsVM> ItemsVMs { get; set; }
    }
}