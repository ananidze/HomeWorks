namespace Homework_7.Middlewares
{
    public class BookingMiddleware
    {
        readonly RequestDelegate _next;
        readonly IConfiguration _configuration;

        public BookingMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public Task Invoke(HttpContext httpContext)
        {
            bool appSwitch = Convert.ToBoolean(_configuration.GetSection("BookingNotAllowed").Value);
            if (appSwitch) return httpContext.Response.WriteAsync("Booking is not allowed");
            return _next(httpContext);
        }
    }
}

