using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }

        DateTime UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        bool Status { set; get; }

        bool? HomeFlag { set; get; }
    }
}