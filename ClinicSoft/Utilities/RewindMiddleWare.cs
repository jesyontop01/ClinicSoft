
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.Internal;
using System.Data.SqlClient;

namespace ClinicSoft.CommonTypes
{
    public class RewindMiddleWare
    {
        private readonly RequestDelegate _next;

        public RewindMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            // Enable buffering to allow multiple reads of the request body
            httpContext.Request.EnableBuffering();

            // Call the next middleware in the pipeline
            await _next(httpContext);
        }

        //public Task Invoke(HttpContext httpContext)
        //{
        //    httpContext.Request.EnableRewind();
        //    return _next(httpContext);
        //}
    }
}
