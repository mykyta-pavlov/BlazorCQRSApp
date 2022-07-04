using Core.Commands;
using Core.DataAccess;
using Core.Models;
using MediatR;

namespace Core.Handlers
{
    public class InsertPostHandler : IRequestHandler<InsertPostCommand, Post>
    {
        private readonly BloggingContext _context;

        public InsertPostHandler(BloggingContext context)
        {
            _context = context;
        }

        public async Task<Post> Handle(InsertPostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post
            {
                Title = request.Title,
                Content = request.Content,
                BlogId = request.BlogId
            };
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }
    }
}
