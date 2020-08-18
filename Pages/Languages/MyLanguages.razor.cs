using System.Collections.Generic;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages.Languages
{
  public class MyLanguagesBase : ComponentBase
  {
    protected List<LanguageSkill> Languages = new List<LanguageSkill>();

    protected override void OnInitialized()
    {
      Languages.Add(new LanguageSkill
      {
        PathToFlag = @"\img\dutch.png",
        AltTextFlag = "Dutch",
        Speaking = "Native speaker",
        Writing = "Native speaker",
        Reading = "Native speaker"
      });

      Languages.Add(new LanguageSkill
      {
        PathToFlag = @"\img\french.png",
        AltTextFlag = "French",
        Speaking = "Very good command",
        Writing = "Excellent Command",
        Reading = "Excellent Command"
      });

      Languages.Add(new LanguageSkill
      {
        PathToFlag = @"\img\english.png",
        AltTextFlag = "English",
        Speaking = "Very good command",
        Writing = "Excellent command",
        Reading = "Excellent command"
      });

      Languages.Add(new LanguageSkill
      {
        PathToFlag = @"\img\german.png",
        AltTextFlag = "German",
        Speaking = "Good command",
        Writing = "Very good command",
        Reading = "very good command"
      });

      Languages.Add(new LanguageSkill
      {
        PathToFlag = @"\img\spanish.png",
        AltTextFlag = "Spanish",
        Speaking = "Good command",
        Writing = "Very good command",
        Reading = "very good command"
      });
    }
  }
}