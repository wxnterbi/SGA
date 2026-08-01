using SGA.Web.Interfaces.Pago;
using SGA.Web.Services.Pago;
using SGA.Web.Services.TicketMensual;
using SGA.Web.Interfaces.TicketMensual;
using SGA.Web.Interfaces.TarjetaRecargable;
using SGA.Web.Services.TarjetaRecargable;
using SGA.Web.Interfaces.RegistroAcceso;
using SGA.Web.Services.RegistroAcceso;
using SGA.Web.Interfaces.Notificacion;
using SGA.Web.Services.Notificacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configuración de HttpClient para consumir la API

builder.Services.AddHttpClient<IPagoApiService, PagoApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]!);
});

builder.Services.AddHttpClient<ITicketMensualApiService, TicketMensualApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]!);
});

builder.Services.AddHttpClient<ITarjetaRecargableApiService, TarjetaRecargableApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]!);
});

builder.Services.AddHttpClient<IRegistroAccesoApiService, RegistroAccesoApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]!);
});

builder.Services.AddHttpClient<INotificacionApiService, NotificacionApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseUrl"]!);
});

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

app.Run();
