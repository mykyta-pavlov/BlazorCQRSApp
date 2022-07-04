using Core.Models;
using MediatR;

namespace Core.Queries;

public record GetPostByIdQuery(int id): IRequest<Post>;
