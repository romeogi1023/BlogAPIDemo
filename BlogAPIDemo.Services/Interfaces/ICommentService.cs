using System;
using System.Collections.Generic;
using System.Text;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Domain.Entities;
namespace BlogAPIDemo.Services.Interfaces
{
    public interface ICommentService:IBaseService<Comments,CommentsDto>
    {

    }
}
