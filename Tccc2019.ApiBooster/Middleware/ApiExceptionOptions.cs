using System;
using Microsoft.AspNetCore.Http;


namespace Tccc2019.ApiBooster.Middleware
{
    public class ApiExceptionOptions
    {       
        public Action<HttpContext, Exception, ApiError> AddResponseDetails { get; set; }        
    }
}
