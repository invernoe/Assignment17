namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/mahmoud", async context => await context.Response.WriteAsync("Hello Mahmoud"));
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}");

            app.Run();
        }
    }
}
