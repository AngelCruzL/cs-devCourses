namespace Domain.Entities;

public class Instructor : BaseEntity
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Degree { get; set; }
  public byte[] ProfilePicture { get; set; }
}