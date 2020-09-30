using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages
{
  public class ExperiencesBase : PageBase
  {
    public List<Experience> Experiences { get; set; } = new List<Experience>();
    private List<string> experienceKeys = new List<string> {"Exp01", "Exp02", "Exp03", "Exp04", "Exp05", "Exp06"};

    protected async Task<IEnumerable<Experience>> LoadExperiencesAsync()
    {
      foreach (var key in experienceKeys)
      {
        Experiences.Add(new Experience
        {
          Title = Loc.Keys[$"Experience:{key}:Title"],
          Company = Loc.Keys[$"Experience:{key}:Company"],
          City = Loc.Keys[$"Experience:{key}:City"],
          Duration = Loc.Keys[$"Experience:{key}:Duration"],
          Description = Loc.Keys[$"Experience:{key}:Description"]
        });    
      }
      return await Task.FromResult(Experiences.Take(experienceKeys.Count));
    }
  }
}