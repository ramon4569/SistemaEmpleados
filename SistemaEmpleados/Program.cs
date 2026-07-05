var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();       // Necesario para que _Host.cshtml (@page) funcione
builder.Services.AddServerSideBlazor(); // Habilita Blazor Server

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();              // Habilita el enrutamiento de Razor Pages
app.MapBlazorHub();               // Ruta de Blazor
app.MapFallbackToPage("/_Host");  // Fallback a Blazor

app.Run();