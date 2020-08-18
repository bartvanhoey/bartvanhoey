using System;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Shared
{
    public class FooterBase : ComponentBase
    {
    public string CurrentYear { get; set; } = DateTime.Now.Year.ToString();
        
    }
}