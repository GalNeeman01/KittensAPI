namespace AssafFinkelshtein;

public class Program
{
    public static void Main(string[] args)
    {
        // Create builder: 
        var builder = WebApplication.CreateBuilder(args);

        // Add controllers: 
        builder.Services.AddControllers();

        // Create app:
        var app = builder.Build();

        app.UseMiddleware<LoggerMiddleware>();

        // Map routes in the controller: 
        app.MapControllers();

        app.Run();
    }
}
