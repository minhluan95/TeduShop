using System;

namespace TeduShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }

        public bool Status { set; get; }

        public bool? HomeFlag { set; get; }
    }
}