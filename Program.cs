

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
    //routes.MapRoute("Customer", "{controller=Customer}/{action=Index}");
});
app.Run(async (context) => {
    await context.Response.WriteAsync("Failed to Find Route");
});
app.Run();
