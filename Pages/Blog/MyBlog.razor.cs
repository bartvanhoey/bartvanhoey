using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bartvanhoey.Pages.Blog
{
    public class MyBlogBase  : PageBase
    {
        
    }

    protected async Task<IEnumerable<BlogPost>> LoadBlogPostsAsync()
    {
      foreach (var key in educationKeys)
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
