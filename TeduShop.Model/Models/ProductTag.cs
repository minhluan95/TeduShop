﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "varchar", Order = 2)]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("ProductID")]
        public virtual ProductCategory Product { set; get; }
    }
}