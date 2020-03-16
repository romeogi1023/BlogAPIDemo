using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPIDemo.Domain.Dtos
{
    public class CommentsDto
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
