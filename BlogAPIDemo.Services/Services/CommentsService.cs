using System;
using System.Collections.Generic;
using System.Text;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Services
{
    public class CommentsService : ICommentService
    {
        public bool Create(CommentsDto tDto)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CommentsDto DindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CommentsDto> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Update(CommentsDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
