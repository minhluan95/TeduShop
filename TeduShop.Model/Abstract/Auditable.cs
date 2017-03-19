using System;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }

        public DateTime UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }

        public bool Status { set; get; }

        public bool? HomeFlag { set; get; }
    }
}