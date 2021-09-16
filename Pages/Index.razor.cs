
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

}