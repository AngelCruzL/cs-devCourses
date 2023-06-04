namespace Domain.Entities;

public class Comment : BaseEntity
{
  public string Student { get; set; }
  public int Score { get; set; }
  public string TextComment { get; set; }
  public int CourseId { get; set; }
}