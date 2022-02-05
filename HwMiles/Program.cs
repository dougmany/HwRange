using HwMiles;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.fueleconomy.gov") });

builder.Services.AddHttpClient<EPAService>(client =>
{
    client.BaseAddress = new Uri("https://www.fueleconomy.gov");
    client.DefaultRequestHeaders.Add("accept", "application/json ");
});

builder.Services.AddHttpClient<HWMilesService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

await builder.Build().RunAsync();
