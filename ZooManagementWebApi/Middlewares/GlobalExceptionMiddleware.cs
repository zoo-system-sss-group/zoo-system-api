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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=============================");
            Console.WriteLine("~~ GobalExceptionMiddleware ~~");
            Console.WriteLine($"Error Message: {ex.Message}");
            Console.WriteLine($"Exception: {ex}");            
            Console.WriteLine("=============================");
            Console.ResetColor();            
            await context.Response.WriteAsync(ex.ToString());
        }
    }
}
