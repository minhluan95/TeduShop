﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        public int? Warranty { set; get; }
        public decimal? PromotionPrice { set; get; }
        public decimal Price { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public int? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        //public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
        //public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}