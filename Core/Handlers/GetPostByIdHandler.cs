using Core.DataAccess;
using Core.Models;
using Core.Queries;
using MediatR;

namespace Core.Handlers;

public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, Post>
{
    private readonly BloggingContext _context;

    public GetPostByIdHandler(BloggingContext context)
    {
        _context = context;
    }

    public async Task<Post> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
    {

        return _context.Posts.FirstOrDefault(x => x.PostId == request.id);
    }
}
