﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }

        [Required(ErrorMessage ="Tên danh mục bắt buộc nhập")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Tiêu đề SEO bắt buộc nhập")]
        public string Alias { set; get; }

        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        [Required(ErrorMessage = "Trạng thái bắt buộc chọn")]
        public bool Status { set; get; }
    }
}