﻿using System.Web;
using System.Web.Mvc;

namespace Web_API_WorkOut_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
