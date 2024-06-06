using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SKstudioWeb.Data;
using SKstudioWeb.Models;
using System.Collections.Specialized;

var builder = WebApplication.CreateBuilder(args);

string StringConnection = builder.Configuration.GetConnectionString("LOCAL_DB");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(StringConnection));

builder.Services.AddDefaultIdentity<Clients>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.WebHost.UseStaticWebAssets();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});


app.Run();
