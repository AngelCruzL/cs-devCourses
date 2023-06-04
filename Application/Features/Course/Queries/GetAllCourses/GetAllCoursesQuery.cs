using MediatR;

namespace Application.Features.Course.Queries.GetAllCourses;

public record GetAllCoursesQuery : IRequest<List<Domain.Entities.Course>>;