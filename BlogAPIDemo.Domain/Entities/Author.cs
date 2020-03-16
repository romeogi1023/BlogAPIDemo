using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogAPIDemo.Domain.Entities
{
    public class Author
    {
        public Author()
        {
            PostAuthors = new HashSet<PostAuthors>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PostAuthors> PostAuthors { get; set; }

    }
}
