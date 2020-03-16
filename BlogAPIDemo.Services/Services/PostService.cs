using System;
using System.Collections.Generic;
using System.Text;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Services
{
    public class PostService : IPostService
    {
        public bool Create(PostDto tDto)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PostDto DindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PostDto> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Update(PostDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
