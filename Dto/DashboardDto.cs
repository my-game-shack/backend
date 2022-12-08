namespace Shack.Dto;

public record DashboardDto(
  int Id,
  string Image,
  string Title,
  string Subtitle,
  string PromotionText);