using BlazorCQRS.Data;
using MediatR;
using Core.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<BloggingContext>(x => x.UseSqlServer(@"Data Source=DESKTOP-O0BROJ1;Initial Catalog=TestDB;Persist Security Info=True;MultipleActiveResultSets=True;Integrated Security=SSPI"));
builder.Services.AddMediatR(typeof(BloggingContext).Assembly);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
