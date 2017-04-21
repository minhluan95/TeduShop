using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<SlideViewModel> Slide { set; get; }
        public IEnumerable<ProductViewModel> LastestProduct { set; get; }
        public IEnumerable<ProductViewModel> TopSeoProduct { set; get; }
    }
}