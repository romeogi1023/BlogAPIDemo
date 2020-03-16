using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Find(Expression<Func<Category, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FindAll(Expression<Func<Category, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Category Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entityToUpdate, Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
