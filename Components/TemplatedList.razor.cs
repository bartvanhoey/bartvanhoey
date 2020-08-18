using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Components
{
  public class TemplatedListBase<TItem> : ComponentBase
  {
    protected IEnumerable<TItem> items;

    [Parameter] public Func<Task<IEnumerable<TItem>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TItem> Item { get; set; }
    [Parameter] public string ListGroupClass { get; set; }

    protected override async Task OnParametersSetAsync()
    {
      items = await Loader();
    }
  }
}