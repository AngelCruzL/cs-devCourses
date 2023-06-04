namespace Domain.Entities;

public class Price : BaseEntity
{
  public decimal CurrentPrice { get; set; }
  public decimal Discount { get; set; }
  public int CourseId { get; set; }
  public Course Course { get; set; }
}