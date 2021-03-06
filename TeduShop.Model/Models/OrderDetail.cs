﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual ProductCategory Product { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        public int Quantity { set; get; }
    }
}