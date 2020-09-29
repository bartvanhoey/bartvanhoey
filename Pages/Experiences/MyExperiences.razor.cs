using System.Collections.Generic;
using System.Threading.Tasks;
using bartvanhoey.Models;
using Microsoft.AspNetCore.Components;

namespace bartvanhoey.Pages
{
  public class ExperiencesBase : ComponentBase
  {
    public List<Experience> Experiences { get; set; } = new List<Experience>();


    protected async Task<IEnumerable<Experience>> LoadExperiencesAsync()
    {

      Experiences.Add(new Experience
      {
        Title = ".Net Developer",
        Company = "EurAm",
        City = "Leuven",
        Duration = "2015-may 2019",
        Description = @".Net development by making use of the latest software technologies and
    products, such as C#, ASP.NET Core, Aurelia, PWA,
    Marten, PostgreSQL, RavenDb, Selenium, SQL Server 2018, TypeScript, Visual
    Basic
    for Applications, Visual Studio 2019 Professional, Resharper Ultimate, Rider Fiddler,
    IdentityServer,
    SendGrid, EntityFramework, Dapper, Exact Online, MapBox, OpenStreetMaps, Docker
    Containers, Kubernetes, Azure,
    Micro
    Services Architecture, CQRS, xUnit, SourceTree, GitLab, Xamarin.Forms, ChartJS,
    RabbitMQ..."
      });

      Experiences.Add(new Experience
      {
        Title = "Acerta Service Help Desk Officer",
        Company = "SplendIT",
        City = "Leuven",
        Duration = "2013-2014",
        Description = @"Software support on Acerta HR software applications"
      });

      Experiences.Add(new Experience
      {
        Title = "Logistics Employee",
        Company = "Straumann",
        City = "Zaventem",
        Duration = "2011-2012",
        Description = @"Receive shipments and ensure both quality and quantity are correct. Interact with third
    party
    logistics
    service providers. Ensure accuracy
    of stock inventory. Order picking and create packaging lists and update shipment
    information."
      });

      Experiences.Add(new Experience
      {
        Title = "Maintenance Mechanic",
        Company = "Beaulieu Nylon",
        City = "Kruishoutem",
        Duration = "2008-2010",
        Description = @"General maintenance machinery of a nylon production plant, construction, pipe laying, welding, assembly and
    disassembly
    of motors and pumps."
      });

      Experiences.Add(new Experience
      {
        Title = "Logistics Employee",
        Company = "Autoliv Belgium",
        City = "Desteldonk",
        Duration = "2001-2007",
        Description = @"Inventory management, place orders, MRP-planning, control of invoices, production
    planning,
    forecasting, follow-up returned
    goods, logistics data management, administrative tasks."
      });

      Experiences.Add(new Experience
      {
        Title = "Warehouse Clerk",
        Company = "Floréac",
        City = "Lochristi",
        Duration = "1997-2000",
        Description = @" Reception and inspection of incoming deliveries, order picking, making up orders,
    loading
    and unloading trucks."
      });

      return await Task.FromResult(Experiences);
    }
  }
}