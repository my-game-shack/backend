using Shack.Application.Dto;
using Shack.Domain.Repository;
using Shack.Infrastructure;

namespace Shack.Application.UseCasese;

public class GetDashboardByIdUseCase
{
  private readonly IDashboardsRepository _dashboardsRepository;
  public GetDashboardByIdUseCase(IDashboardsRepository dashboardsRepository)
  {
    _dashboardsRepository = dashboardsRepository;
  }

  public async Task<DashboardDto> ExecuteAsync(int id)
  {
    var d = await _dashboardsRepository.GetById(id);
    // TODO add mapper;
    return new DashboardDto(d.Id, d.Image, d.Title, d.Subtitle, d.PromotionText);
  }

}