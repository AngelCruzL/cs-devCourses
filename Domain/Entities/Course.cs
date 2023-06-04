namespace Domain.Entities;

public class Course : BaseEntity
{
  public string Title { get; set; }
  public string Description { get; set; }
  public DateTime PublishDate { get; set; }
  public byte[] BannerPicture { get; set; }
  public Price discountPrice { get; set; }
  public ICollection<Comment> Comments { get; set; }
  public ICollection<CourseInstructor> InstructorsLinks { get; set; }
}