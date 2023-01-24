namespace Lab10_Misyuro.Kirill_FirstASP.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (x) =>
            {
                var info = new Info(x.Request, app);
                await x.Response.WriteAsync(info.GetInfo());
            });
            app.Run();
        }
    }
}