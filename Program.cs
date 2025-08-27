using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScriptApp;
using ScriptApp.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Главный компонент приложения
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient (можно использовать для API-запросов, пока оставим)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Наш сервис для хранения сценариев и блоков
builder.Services.AddSingleton<ScriptService>();

// Запуск приложения
await builder.Build().RunAsync();
