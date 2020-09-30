using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AKSoftware.Localization.MultiLanguages;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Shared
{
    public class NavMenuBase : ComponentBase
    {
        [Inject] public ILocalStorageService LocalStorage { get; set; }
        [Inject] public ILanguageContainerService LanguageContainer { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        public List<LocalisationLanguage> Languages = new List<LocalisationLanguage>();
        public string SelectedLanguage { get; set; }
        protected bool collapseNavMenu = true;
        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected override void OnInitialized()
        {
            LoadLanguages();
        }

        protected async Task ChangeLanguageAsync(string cultureCode)
        {
            var navigationManagerUri = NavigationManager.Uri;
            SelectedLanguage = GetDisplayLanguageFromCultureCode(cultureCode);
            await LocalStorage.SetItemAsync("bartvanhoey_culturecode", cultureCode);
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
            NavigationManager.NavigateTo(navigationManagerUri, true);
        }

        private string GetDisplayLanguageFromCultureCode(string cultureCode)
        {
            return Languages.FirstOrDefault(l => l.CultureCode == cultureCode).Display;
        }

        protected override async Task OnParametersSetAsync()
        {
            var cultureCode = await LocalStorage.GetItemAsync<string>("bartvanhoey_culturecode") ?? "en-US";
            SelectedLanguage = string.IsNullOrWhiteSpace(cultureCode) ? "English" : GetDisplayLanguageFromCultureCode(cultureCode);
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(cultureCode));
        }


        private void LoadLanguages()
        {
            Languages.Add(new LocalisationLanguage { CultureCode = "en-US", Display = "English" });
            // Languages.Add(new LocalisationLanguage { CultureCode = "es-ES", Display = "Español" });
            // Languages.Add(new LocalisationLanguage { CultureCode = "fr-FR", Display = "Français" });
            Languages.Add(new LocalisationLanguage { CultureCode = "de-DE", Display = "Deutsch" });
            // Languages.Add(new LocalisationLanguage { CultureCode = "nl-NL", Display = "Nederlands" });
        }

        protected void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}