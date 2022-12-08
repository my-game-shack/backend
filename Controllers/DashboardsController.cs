using Microsoft.AspNetCore.Mvc;
using Shack.Dto;

namespace Shack.Controllers;

[ApiController]
[Route("dashboards")]
public class DashboardsController : ControllerBase
{
  [HttpGet]
  public ActionResult<DashboardDto> Get()
  {
    var dashboardOne = new DashboardDto(1, "https://image.url", "promo", "sub", "tit");
    var dashboardTwo = new DashboardDto(2, "https://image.url", "promo_two", "subtwo", "titTat");
    var response = new List<DashboardDto> { dashboardOne, dashboardTwo };
    return Ok(response);
  }

  [HttpGet("one")]
  public ActionResult<IEnumerable<DashboardDto>> GetOne()
  {
    var dashboardOne = new DashboardDto(1, "https://image.url", "promo", "sub", "tit");
    return Ok(dashboardOne);
  }
}
