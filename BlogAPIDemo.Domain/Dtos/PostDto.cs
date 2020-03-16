using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPIDemo.Domain.Dtos
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public int CategoryId { get; set; }

        public Guid postguid { get; set; } = Guid.NewGuid();

        public List<CommentsDto> CommentsList { get; set; }
        public List<PostTagDto> Tag { get; set; }
        public CategoryDto Category { get; set; }

    }
}
