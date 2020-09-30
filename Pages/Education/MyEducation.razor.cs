using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages.Education
{
  public class MyEducationBase : PageBase
  {
    public List<TrainingEducation> Items { get; set; } = new List<TrainingEducation>();
    private List<string> educationKeys = new List<string> { "Ed01", "Ed02", "Ed03", "Ed04", "Ed05", "Ed06", "Ed07", "Ed08", "Ed09", "Ed10", "Ed11", "Ed12", "Ed13", "Ed14", "Ed15", "Ed16", };

    protected async Task<IEnumerable<TrainingEducation>> LoadTrainingAndEducationAsync()
    {
      foreach (var key in educationKeys)
      {
        Items.Add(new TrainingEducation
        {
          Subject = Loc.Keys[$"Education:{key}:Subject"],
          OrganizedBy = Loc.Keys[$"Education:{key}:OrganizedBy"],
          Location = Loc.Keys[$"Education:{key}:Location"],
          Duration = Loc.Keys[$"Education:{key}:Duration"],
          Url = Loc.Keys[$"Education:{key}:Url"]
        });
      }


      // _.Add(new TrainingEducation
      // {
      //   Subject = "Modern Web UI with Blazor WebAssembly",
      //   OrganizedBy = "NDC Oslo 2020, by Steve Sanderson",
      //   Location = "Online Talk",
      //   Duration = "8-12 June 2020, 1h",
      //   Url = "https://www.youtube.com/watch?v=kLhoRyLxwAE"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Blazor in more depth",
      //   OrganizedBy = "NDC London, by Ryan Nowak & Steve Sanderson",
      //   Location = "Online Talk",
      //   Duration = "27-30 January 2020, 1h",
      //   Url = "https://www.youtube.com/watch?v=QnBYmTpugz0"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Blazor, a new framework for browser-based .NET apps",
      //   OrganizedBy = "NDC London, by Steve Anderson",
      //   Location = "Online Talk",
      //   Duration = "27-30 January 2020, 1h",
      //   Url = "https://www.youtube.com/watch?v=Khn7sDUSEJM"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "BlazingPizza, Blazor workshop",
      //   OrganizedBy = ".NET foundation",
      //   Location = "Online Tutorial",
      //   Duration = "July 2020, 10 step-by-step tutorials",
      //   Url = "https://github.com/dotnet-presentations/blazor-workshop"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Blazor tutorial for beginners",
      //   OrganizedBy = "Pragim Technologies, by Kud Venkat",
      //   Location = "Online YouTube Training",
      //   Duration = "July 2020, 58 lessons, 7h",
      //   Url = "https://www.youtube.com/playlist?list=PL6n9fhu94yhVowClAs8-6nYnfsOTma14P"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Global DevOps Bootcamp 2019",
      //   OrganizedBy = "Global DevOps Bootcamp, by XPIRIT & SOLIDIFY, hosted by Ordina",
      //   Location = "Mechelen",
      //   Duration = "June 2019, 1 day"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Team Development with Azure DevOps",
      //   OrganizedBy = "U2U Training",
      //   Location = "Brussels",
      //   Duration = "May 2019, 3 days"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Angular 5 Tutorial",
      //   OrganizedBy = "Pragim Technologies, by Kud Venkat",
      //   Location = "Online YouTube Training",
      //   Duration = "October 2017, 71 lessons, 12h",
      //   Url = "https://www.youtube.com/watch?v=P1mlC8Ar0_k&ab_channel=kudvenkat"

      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Advanced TypeScript",
      //   OrganizedBy = "Pluralsight course, by Brice Wilson",
      //   Location = "Online",
      //   Duration = "October 2017, 2h 55m"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Global DevOps Bootcamp 2018",
      //   OrganizedBy = "Global DevOps Bootcamp, by XPIRIT & SOLIDIFY, hosted by Ordina",
      //   Location = "Mechelen",
      //   Duration = "June 2018, 1 day"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Deep Dive Xamarin.Forms Workshop",
      //   OrganizedBy = "BASTA2017, by Jörg Neumann",
      //   Location = "Mainz",
      //   Duration = "October 2017, 1 day"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = ".NET Best Practices: Architecture & Design Patterns",
      //   OrganizedBy = "U2U Training",
      //   Location = "Brussels",
      //   Duration = "January 2017, 5 days"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Developing cross-platform apps with C# using Xamarin",
      //   OrganizedBy = "Microsoft Innovation Center, by Gill Cleeren",
      //   Location = "Genk",
      //   Duration = "December 2016, 2 days"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Advanced OO Programming Techniques in .NET",
      //   OrganizedBy = "U2U Training",
      //   Location = "Brussels",
      //   Duration = "April 2017, 5 days"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Informatics Associate Degree",
      //   OrganizedBy = "UC Leuven-Limburg",
      //   Location = "Leuven",
      //   Duration = "2011-2014"
      // });

      // _.Add(new TrainingEducation
      // {
      //   Subject = "Bachelor in Agro & Biotechnology",
      //   OrganizedBy = "HILT",
      //   Location = "Melle",
      //   Duration = "1992-1995"
      // });

      return await Task.FromResult(Items.Take(16));
    }

  }
}