using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Parking_VIP.Data;
using parkingvip.Data;
using parkingvip.Data.Entities;
using parkingvip.Helper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentity<User, IdentityRole>(cfg =>
{
    cfg.User.RequireUniqueEmail = true;
    cfg.Password.RequireDigit = true;//digitos
    cfg.Password.RequiredUniqueChars = 0;//caracteres especiales
    cfg.Password.RequireLowercase = false;//minusculas
    cfg.Password.RequireNonAlphanumeric = false;//alfanumerico
    cfg.Password.RequireUppercase = false;//mayuscula
}).AddEntityFrameworkStores<DataContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/NotAutorized";
    options.AccessDeniedPath = "/Account/NotAutorized";
});


builder.Services.AddControllersWithViews();
builder.Services.AddTransient<SeedDb>();
builder.Services.AddScoped<IUserHelper, UserHelper>();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddDbContext<DataContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("cadenaconexion")); //este datacontext utiliza sqlserver, configuracion de inyeccion de dependencias
});


var app = builder.Build();

SeedDdata();

void SeedDdata()
{
    IServiceScopeFactory? scopeFactory = app.Services.GetService<IServiceScopeFactory>();
    using (IServiceScope? scope = scopeFactory.CreateScope())
    {
        SeedDb? service = scope.ServiceProvider.GetService<SeedDb>();
        service.SeedAsync().Wait();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/error/{0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
//este programa hace falta terminar unas cosillas
