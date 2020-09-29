using System;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace bartvanhoey.Pages.About
{
  public class MyAboutPageBase : ComponentBase
  {
    [Inject] public ILocalStorageService LocalStorage { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }
    protected string CultureCode { get; set; }

    protected override async Task OnParametersSetAsync() => await SetCultureCodeAsync();

    protected override void OnInitialized() => NavigationManager.LocationChanged += OnLocationChanged;

    private void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
      base.InvokeAsync(async () =>
        {
          await Task.Delay(1);  // wait for blazor to populate route parameters
          await SetCultureCodeAsync();              
          StateHasChanged();
        });
    }

    private async Task SetCultureCodeAsync() => CultureCode = await LocalStorage.GetItemAsync<string>("bartvanhoey_culturecode") ?? "en-US";

    public void Dispose() => NavigationManager.LocationChanged -= OnLocationChanged;
  }
}