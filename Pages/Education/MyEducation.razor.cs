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