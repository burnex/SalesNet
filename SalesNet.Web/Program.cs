using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SalesNet.Web;
using SalesNet.Web.Auth;
using SalesNet.Web.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7213/") });
builder.Services.AddScoped<IRepository, Repository>();

//Scoped: Se usa cuando se crea una instancia de un objeto
//Transient: Solo cuando se requiere usar una vez
//Singleton: Se crea una instancia y se queda en memoria, consume memoria

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderTest>();


builder.Services.AddSweetAlert2();
await builder.Build().RunAsync();

