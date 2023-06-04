using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Features.Course.Queries.GetAllCourses;

public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, List<Domain.Entities.Course>>
{
  private readonly OnlineCoursesContext _context;

  public GetAllCoursesQueryHandler(OnlineCoursesContext context)
  {
    _context = context;
  }

  public async Task<List<Domain.Entities.Course>> Handle(GetAllCoursesQuery request,
    CancellationToken cancellationToken)
  {
    return await _context.Courses.ToListAsync();
  }
}