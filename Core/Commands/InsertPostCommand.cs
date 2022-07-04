using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public record InsertPostCommand(string Title, string Content, int BlogId) : IRequest<Post>;
}
