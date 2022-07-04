using Core.Models;
using MediatR;

namespace Core.Queries
{
    public record GetPostListQuery() : IRequest<List<Post>>;
}
