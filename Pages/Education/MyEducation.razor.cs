using System.Collections.Generic;
using System.Threading.Tasks;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages.Education
{
  public class MyEducationBase : ComponentBase
  {
    public List<TrainingEducation> _ { get; set; } = new List<TrainingEducation>();

    protected async Task<IEnumerable<TrainingEducation>> LoadTrainingAndEducationAsync()
    {
      _.Add(new TrainingEducation
      {
        Subject = "Modern Web UI with Blazor WebAssembly",
        OrganizedBy = "NDC Oslo 2020, by Steve Sanderson",
        Location = "Online Talk",
        Duration = "8-12 June 2020, 1h",
        Url = "https://www.youtube.com/watch?v=kLhoRyLxwAE"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Blazor in more depth",
        OrganizedBy = "NDC London, by Ryan Nowak & Steve Sanderson",
        Location = "Online Talk",
        Duration = "27-30 January 2020, 1h",
        Url = "https://www.youtube.com/watch?v=QnBYmTpugz0"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Blazor, a new framework for browser-based .NET apps",
        OrganizedBy = "NDC London, by Steve Anderson",
        Location = "Online Talk",
        Duration = "27-30 January 2020, 1h",
        Url = "https://www.youtube.com/watch?v=Khn7sDUSEJM"
      });

      _.Add(new TrainingEducation
      {
        Subject = "BlazingPizza, Blazor workshop",
        OrganizedBy = ".NET foundation",
        Location = "Online tutorial",
        Duration = "July 2020, 10 step-by-step tutorials",
        Url = "https://github.com/dotnet-presentations/blazor-workshop"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Blazor tutorial for beginners",
        OrganizedBy = "Pragim Technologies, by Kud Venkat",
        Location = "Online YouTube Training",
        Duration = "July 2020, 58 lessons, 7h"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Global DevOps Bootcamp 2019",
        OrganizedBy = "Global DevOps Bootcamp, by XPIRIT & SOLIDIFY, hosted by Ordina",
        Location = "Mechelen",
        Duration = "June 2019, 1 day"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Team Development with Azure DevOps",
        OrganizedBy = "U2U Training",
        Location = "Brussels",
        Duration = "May 2019, 3 days"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Angular CRUD Tutorial",
        OrganizedBy = "Pragim Technologies, by Kud Venkat",
        Location = "Online YouTube Training",
        Duration = "October 2017, 71 lessons, 12h"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Advanced TypeScript",
        OrganizedBy = "Pluralsight course, by Brice Wilson",
        Location = "Online",
        Duration = "October 2017, 2h 55m"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Global DevOps Bootcamp 2018",
        OrganizedBy = "Global DevOps Bootcamp, by XPIRIT & SOLIDIFY, hosted by Ordina",
        Location = "Mechelen",
        Duration = "June 2018, 1 day"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Deep Dive Xamarin.Forms Workshop",
        OrganizedBy = "BASTA2017, by Jörg Neumann",
        Location = "Mainz",
        Duration = "October 2017, 1 day"
      });

      _.Add(new TrainingEducation
      {
        Subject = ".NET Best Practices: Architecture & Design Patterns",
        OrganizedBy = "U2U Training",
        Location = "Brussels",
        Duration = "January 2017, 5 days"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Developing cross-platform apps with C# using Xamarin",
        OrganizedBy = "Microsoft Innovation Center, by Gill Cleeren",
        Location = "Genk",
        Duration = "December 2016, 2 days"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Advanced OO Programming Techniques in .NET",
        OrganizedBy = "U2U Training",
        Location = "Brussels",
        Duration = "April 2017, 5 days"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Informatics Associate Degree",
        OrganizedBy = "UC Leuven-Limburg",
        Location = "Leuven",
        Duration = "2011-2014"
      });

      _.Add(new TrainingEducation
      {
        Subject = "Bachelor in Agro & Biotechnology",
        OrganizedBy = "HILT",
        Location = "Melle",
        Duration = "1992-1995"
      });

      return await Task.FromResult(_);
    }

  }
}