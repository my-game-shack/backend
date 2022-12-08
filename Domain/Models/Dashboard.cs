namespace Shack.Domain.Models;

public record Dashboard(
  int Id,
  string Image,
  string Title,
  string Subtitle,
  string PromotionText);