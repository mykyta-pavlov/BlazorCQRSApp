using Core.DataAccess;
using Core.Models;
using Core.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core.Handlers
{
    public class GetPostListHandler : IRequestHandler<GetPostListQuery, List<Post>>
    {
        private readonly BloggingContext _context;

        public GetPostListHandler(BloggingContext context)
        {
            _context = context;
        }

        public Task<List<Post>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_context.Posts.ToList());            
        }
    }
}
