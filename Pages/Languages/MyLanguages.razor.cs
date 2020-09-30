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
             PathToFlag = Loc.Keys[$"Languages:{key}:PathToFlag"],
             AltTextFlag = Loc.Keys[$"Languages:{key}:AltTextFlag"],
             Speaking = Loc.Keys[$"Languages:{key}:Speaking"],
             Writing = Loc.Keys[$"Languages:{key}:Writing"],
             Reading = Loc.Keys[$"Languages:{key}:Reading"]
           });
      }
    }
  }
}