using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
//
using BlogAPIDemo.Domain.Context;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlogAPIDemo.Services.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public readonly BlogContext _blogContext;

        public CategoryRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void Add(Category entity)
        {
            _blogContext.Category.Add(entity);
            _blogContext.SaveChanges();
        }
        public void Update (Category entity)
        {
            _blogContext.Category.Update(entity);
            _blogContext.SaveChanges();
        }
        public void Delete(Category entity)
        {
            _blogContext.Category.Remove(entity);
            _blogContext.SaveChanges();
        }

        public Category Find(Expression<Func<Category, bool>> where) => _blogContext.Category.Where(where).FirstOrDefault();
      
        public IEnumerable<Category> FindAll(Expression<Func<Category, bool>> where) => _blogContext.Category.Where(where);
        public Category Get(long id) => _blogContext.Category.SingleOrDefault(b => b.Id == id);

        public IEnumerable<Category> GetAll() => _blogContext.Category.Include(author => author.Post).ToList();
    
    }
}
