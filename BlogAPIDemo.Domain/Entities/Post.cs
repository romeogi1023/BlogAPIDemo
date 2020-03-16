using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogAPIDemo.Domain.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comments>();
            Tag = new HashSet<PostTag>();
        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public Guid PostGuid { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<PostTag> Tag { get; set; }

    }
}
