using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.ViewModels
{
    public class BreadcrumbViewModel
    {
        public string MainPageTitle { get; set; }
        public List<Breadcrumb> BreadcrumbList { get; set; }
    }

    public class Breadcrumb
    {
        public string PageTitle { get; set; }
        public string PageUrl { get; set; }
        public bool isSelected { get; set; }
    }
}
