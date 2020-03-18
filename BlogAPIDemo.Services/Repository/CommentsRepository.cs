using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogAPIDemo.Domain.Context;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Repository
{
    public class CommentsRepository : IRepository<Comments>
    {
        public BlogContext _blogContext;

        public CommentsRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void Add(Comments entity)
        {
            _blogContext.Comments.Add(entity);
            _blogContext.SaveChanges();
        }
        public void Update (Comments entity)
        {
            _blogContext.Comments.Update(entity);
            _blogContext.SaveChanges();
        }

        public void Delete(Comments entity)
        {
            _blogContext.Comments.Remove(entity);
            _blogContext.SaveChanges();
        }

        public Comments Find(Expression<Func<Comments, bool>> where)
          => _blogContext.Comments.Where(where).FirstOrDefault();
        public IEnumerable<Comments> FindAll(Expression<Func<Comments, bool>> where)
          => _blogContext.Comments.Where(where);
        public Comments Get(long id)
            => _blogContext.Comments.SingleOrDefault(b => b.Id == id);
        public IEnumerable<Comments> GetAll()
            => _blogContext.Comments.ToList();

      
    }
}
