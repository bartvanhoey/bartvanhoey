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
    
    protected async Task<IEnumerable<TrainingEducation>> LoadTrainingAndEducationAsync()
    {
      foreach (var key in Enumerable.Range(1, 17).Select(x => $"Ed{x}" ).ToArray().Reverse().ToList())
      {
        Items.Add(new TrainingEducation
        {
          Subject = L[$"Education:{key}:Subject"],
          OrganizedBy = L[$"Education:{key}:OrganizedBy"],
          Location = L[$"Education:{key}:Location"],
          Duration = L[$"Education:{key}:Duration"],
          Url = (L[$"Education:{key}:Url"] == "Url") ? null : L[$"Education:{key}:Url"]
        });
      }
      return await Task.FromResult(Items.Take(17));
    }

  }
}