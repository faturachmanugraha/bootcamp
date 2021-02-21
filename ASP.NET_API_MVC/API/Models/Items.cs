using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Tb_M_Item")]
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        [Display(Name ="Supplier_Id")]
        public int SupplierId { get; set; }
       
        [ForeignKey("SupplierId")]
        public virtual Suppliers Supplier { get; set; }
    }
}