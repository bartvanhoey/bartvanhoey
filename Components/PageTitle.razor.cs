using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Components
{
    public class PageTitleBase : ComponentBase
    {
        [Parameter] public string Title{ get; set; }
    }
}