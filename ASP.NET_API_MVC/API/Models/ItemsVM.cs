using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ItemsVM
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SupplierID { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Minimum 6 Char")]
        [RegularExpression("^[0-9a-zA-Z]+$", ErrorMessage = "Only Character and Number without Space")]
        public string SupplierName { get; set; }

    }
}