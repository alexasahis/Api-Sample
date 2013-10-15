﻿using ApiSample.UI.WebSite.ActionFilters;
using ApiSample.Utility.Extensions.ExceptionHandling;
using System.Web;
using System.Web.Mvc;

namespace ApiSample.UI.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ApiErrorHandleAttribute());
            filters.Add(new ExceptionHandlingAttribute());
            filters.Add(new ApiResultAttribute());
        }
    }
}