using AliceScript;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using tryalice.wsoft.ws;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


try
{
    AliceScript.Runtime.InitBasicAPI();
    AliceScript.NameSpaces.Alice_Math.Init();
    AliceScript.NameSpaces.Alice_Reflection.Init();
    AliceScript.NameSpaces.Alice_Random.Init();
    AliceScript.NameSpaces.Alice_Regex.Init();
    AliceScript.NameSpaces.Alice_Security.Init();
    AliceScript.NameSpaces.Alice_Diagnostics.Init();
    AliceScript.NameSpaces.Alice_Environment.Init();

}
catch { }

await builder.Build().RunAsync();

