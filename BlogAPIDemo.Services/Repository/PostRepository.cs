using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Repository
{
    public class PostRepository : IRepository<Post>
    {
        public void Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Find(Expression<Func<Post, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> FindAll(Expression<Func<Post, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Post Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Post entityToUpdate, Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
