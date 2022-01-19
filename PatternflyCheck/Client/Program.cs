using PatternflyCheck.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Outrage.EventBus;
using PatternflyCheck.Client.EventBus;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add event buses
builder.Services.AddSingleton<IRootEventBus, RootEventBus>();
builder.Services.AddScoped<IClientEventBus, UIEventBus>();

await builder.Build().RunAsync();
