using Microsoft.AspNetCore.Mvc;
using Shack.Application.Dto;
using Shack.Application.UseCasese;

namespace Shack.Controllers;

[ApiController]
[Route("dashboards")]
public class DashboardsController : ControllerBase
{
  public readonly GetAllDashboardsUseCase _getAllDashboardsUseCase;
  public readonly GetDashboardByIdUseCase _getDashboardByIdUseCase;
  public DashboardsController()
  {
    // TODO use DI instead
    _getAllDashboardsUseCase = new GetAllDashboardsUseCase(null);
    _getDashboardByIdUseCase = new GetDashboardByIdUseCase(null);

  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<DashboardDto>>> GetOne()
  {
    var result = await _getAllDashboardsUseCase.ExecuteAsync();
    return Ok(result);
  }

  [HttpGet("one")]
  public async Task<ActionResult<DashboardDto>> Get()
  {
    var result = await _getDashboardByIdUseCase.ExecuteAsync(1);
    return result;
  }
}
