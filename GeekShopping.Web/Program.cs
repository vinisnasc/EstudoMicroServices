using GeekShopping.Web.Services;
using GeekShopping.Web.Services.IServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Injecao de dependencia
builder.Services.AddHttpClient<IProductService, ProductService>(c =>
c.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ProductApi"]));

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
