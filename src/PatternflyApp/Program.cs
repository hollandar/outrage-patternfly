using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Outrage.Patternfly;
using PatternflyApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddPatternflyToaster();
builder.Services.AddPatternflyPagedModelFactory();
builder.Services.AddPatternflyBreadcrumb();

PatternflyDefaults.IconLibrary = Outrage.Patternfly.Components.Utilities.LibraryEnum.fontawesome_6;

await builder.Build().RunAsync();
