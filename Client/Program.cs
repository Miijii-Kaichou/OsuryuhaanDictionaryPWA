using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OsuryuhaanDictionaryBlazorApp.Client;
using BlazorBootstrap;
using OsuryuhaanDictionaryBlazorApp.Client.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorBootstrap();
builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();
