using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogAPIDemo.Domain.Context;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlogAPIDemo.Services.Repository
{
    public class PostRepository : IRepository<Post>
    {
        public BlogContext _blogContext;

        public PostRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void Add(Post entity)
        {
            _blogContext.Post.Add(entity);
            _blogContext.SaveChanges();
        }
        public void Update(Post entity)
        {
            _blogContext.Post.Update(entity);
            _blogContext.SaveChanges();
        }
        public void Delete(Post entity)
        {
            _blogContext.Post.Remove(entity);
            _blogContext.SaveChanges();
        }

        public Post Find(Expression<Func<Post, bool>> where)
            => _blogContext.Post.Where(where).FirstOrDefault();
        public IEnumerable<Post> FindAll(Expression<Func<Post, bool>> where)
            => _blogContext.Post.Where(where);

        public Post Get(long id)
           => _blogContext.Post.SingleOrDefault(b => b.Id == id);

        public IEnumerable<Post> GetAll()
           => _blogContext.Post.Include(comments => comments.Comments)
            .Include(tag => tag.Tag)
            .Include(cat => cat.Category).ToList();
    
    }
}
