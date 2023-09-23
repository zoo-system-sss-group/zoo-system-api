namespace ZooManagementWebApi.Middlewares;

public class GlobalExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            // todo push notification & writing log
            Console.WriteLine("=============================");
            Console.WriteLine("GobalExceptionMiddleware");
            Console.WriteLine(ex.Message);
            Console.WriteLine("=============================");
            await context.Response.WriteAsync(ex.ToString());
        }
    }
}
