using WeatherApi_Core.Models;
using WeatherApi_Core.WeatherServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//=============BINDING VALUE OF USER SECRET TO OUR MODEL CONFIGURATION=================//
var weatherapiconfig = new WeatherApiConfiguration();
builder.Configuration.GetSection("WeatherApi").Bind(weatherapiconfig);
//====================ADDING INTERFACE TO THE DEPENDENCY==================================//
builder.Services.AddSingleton<IWeatherApiConfiguration>(weatherapiconfig);
builder.Services.AddScoped<GetWeatherService>();
builder.Services.AddHttpClient();
//====================================================================================//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
