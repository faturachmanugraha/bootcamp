using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Tb_M_Supplier")]
    public class Suppliers
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20,MinimumLength = 6,ErrorMessage ="Minimum 6 Char")]
        [RegularExpression("^[0-9a-zA-Z]+$", ErrorMessage = "Only Character and Number without Space")]
        public string SupplierName { get; set; }
    }
}