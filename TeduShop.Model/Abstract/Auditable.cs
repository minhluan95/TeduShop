using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        public bool Status { set; get; }

        public bool? HomeFlag { set; get; }
    }
}