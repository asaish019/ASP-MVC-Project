﻿using System.Web;
using System.Web.Mvc;

namespace Application_MVC_Form
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
