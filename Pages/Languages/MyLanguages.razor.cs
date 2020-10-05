using System.Collections.Generic;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages.Languages
{
  public class MyLanguagesBase : PageBase
  {
    protected List<LanguageSkill> Languages = new List<LanguageSkill>();
    private List<string> languageKeys = new List<string> { "Nl", "Fr","En","De","Es" };

    protected override void OnInitialized()
    {
      foreach (var key in languageKeys)
      {
           Languages.Add(new LanguageSkill
           {
             PathToFlag = L[$"Languages:{key}:PathToFlag"],
             AltTextFlag = L[$"Languages:{key}:AltTextFlag"],
             Speaking = L[$"Languages:{key}:Speaking"],
             Writing = L[$"Languages:{key}:Writing"],
             Reading = L[$"Languages:{key}:Reading"]
           });
      }
    }
  }
}