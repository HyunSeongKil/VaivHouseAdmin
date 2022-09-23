using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VaivHouseAdmin;
using VaivHouseAdmin.Service;
using VaivHouseAdmin.Service.Impl;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPropertyService, PropertyService>();
builder.Services.AddScoped<IDstrcService, DstrcService>();
builder.Services.AddScoped<IApiGatewayService, ApiGatewayService>();

await builder.Build().RunAsync();