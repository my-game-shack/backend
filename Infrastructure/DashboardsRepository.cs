using Shack.Domain.Models;
using Shack.Domain.Repository;

namespace Shack.Infrastructure;

public class DashboardsRepository : IDashboardsRepository
{
  public Task<List<Dashboard>> GetAll()
  {
    var dashboardOne = new Dashboard(1, "https://image.url", "promo", "sub", "tit");
    var dashboardTwo = new Dashboard(2, "https://image.url", "promo_two", "subtwo", "titTat");
    var dashboards = new List<Dashboard> { dashboardOne, dashboardTwo };
    return Task.FromResult(dashboards);
  }

  public Task<Dashboard> GetById(int id)
  {

    var dashboard = new Dashboard(1, "https://image.url", "promo", "sub", "tit");
    return Task.FromResult(dashboard);
  }
}