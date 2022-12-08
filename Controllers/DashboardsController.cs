using Microsoft.AspNetCore.Mvc;
using Shack.Dto;

namespace Shack.Controllers;

[ApiController]
[Route("dashboards")]
public class DashboardsController : ControllerBase
{
  [HttpGet]
  public IEnumerable<DashboardDto> Get()
  {
    var dashboardOne = new DashboardDto { id = 1, image = "https://image.url", promotionText = "promo", subtitle = "sub", title = "tit" };
    var dashboardTwo = new DashboardDto { id = 2, image = "https://image.url", promotionText = "promo_two", subtitle = "subtwo", title = "titTat" };
    var response = new List<DashboardDto> { dashboardOne, dashboardTwo };
    return response;
  }

  [HttpGet("one")]
  public DashboardDto GetOne()
  {
    var dashboardOne = new DashboardDto { id = 1, image = "https://image.url", promotionText = "promo", subtitle = "sub", title = "tit" };
    return dashboardOne;
  }
}
