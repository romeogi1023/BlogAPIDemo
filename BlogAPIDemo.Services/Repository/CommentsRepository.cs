using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Repository
{
    public class CommentsRepository : IRepository<Comments>
    {
        public void Add(Comments entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comments entity)
        {
            throw new NotImplementedException();
        }

        public Comments Find(Expression<Func<Comments, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> FindAll(Expression<Func<Comments, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Comments Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Comments entityToUpdate, Comments entity)
        {
            throw new NotImplementedException();
        }
    }
}
