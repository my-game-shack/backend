namespace Shack.Dto;

public record DashboardDto
{
  public required int id;
  public required string image;
  public required string title;
  public required string subtitle;
  public required string promotionText;
}