using BlazorGenerator;
using BlazorGenerator.Services;
using Microsoft.JSInterop;
using TestShared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorGenerator();//.UseBlazorGeneratorAuthentication();

BlazorGeneratorSettings.Instance.ApplicationName = "BlazorGenerator Demo App";
BlazorGeneratorSettings.Instance.BaseColor = Microsoft.FluentUI.AspNetCore.Components.OfficeColor.Access;
BlazorGeneratorSettings.Instance.ShowHelpButton = true;

builder.Services.AddScoped<IHelpService, HelpService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
