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
          Url = (Loc.Keys[$"Education:{key}:Url"] == "Url") ? null : Loc.Keys[$"Education:{key}:Url"]
        });
      }
      return await Task.FromResult(Items.Take(16));
    }

  }
}