using Shack.Domain.Models;

namespace Shack.Domain.Repository;

public interface IDashboardsRepository
{
  public Task<Dashboard> GetById(int id);
  public Task<List<Dashboard>> GetAll();
}