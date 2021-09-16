
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
namespace BlazorWebAssemblyTypeScript.Pages;

public partial class Index: ComponentBase
{
    [Inject]
    public IJSRuntime IJSRuntime { get; set; }

    public Index()
    {

    }

    protected async override void OnAfterRender(bool firstRender)
    {
      if (firstRender)
      {
          await IJSRuntime.InvokeAsync<string>("InitDiv");
      }
    }

}