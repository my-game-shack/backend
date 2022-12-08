using Shack.Application.Dto;
using Shack.Domain.Repository;
using Shack.Infrastructure;

namespace Shack.Application.UseCasese;

public class GetAllDashboardsUseCase
{
  private readonly IDashboardsRepository _dashboardsRepository;
  public GetAllDashboardsUseCase(IDashboardsRepository dashboardsRepository)
  {
    _dashboardsRepository = dashboardsRepository;
  }

  public async Task<IEnumerable<DashboardDto>> ExecuteAsync()
  {
    var dashboards = await _dashboardsRepository.GetAll();
    return dashboards.Select(d => new DashboardDto(d.Id, d.Image, d.Title, d.Subtitle, d.PromotionText));
  }

}