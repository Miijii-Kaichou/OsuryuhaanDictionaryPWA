global using OsuryuhaanDictionaryPWAProj.Client.Data;
global using OsuryuhaanDictionaryPWAProj.Client.Services.DictionaryService;
global using OsuryuhaanDictionaryPWAProj.Client.Services.PreferenceService;
global using OsuryuhaanDictionaryPWAProj.Client.Services.NotesService;

global using OsuryuhaanDictionaryPWAProj.Server.Entities;

global using OsuryuhaanDictionaryPWAProj.Client.Models.Notes;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OsuryuhaanDictionaryPWAProj.Client;
using BlazorBootstrap;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IWordService, WordService>();
builder.Services.AddScoped<IAppPreferencesService, AppPreferencesService>();
builder.Services.AddScoped<INotesService, NotesService>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddSingleton<AppState>();

var app = builder.Build();

await builder.Build().RunAsync();