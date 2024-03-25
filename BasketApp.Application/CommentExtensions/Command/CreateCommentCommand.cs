using BasketApp.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Application.CommentExtensions.Command
{
    public class CreateCommentCommand : CommentDto, IRequest
    {
    }
}
