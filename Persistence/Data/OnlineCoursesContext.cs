using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

public class OnlineCoursesContext : DbContext
{
  public OnlineCoursesContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<Comment> Comments { get; set; }
  public DbSet<Course> Courses { get; set; }
  public DbSet<CourseInstructor> CourseInstructors { get; set; }
  public DbSet<Instructor> Instructors { get; set; }
  public DbSet<Price> Prices { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<CourseInstructor>().HasKey(ci => new { ci.InstructorId, ci.CourseId });
  }
}