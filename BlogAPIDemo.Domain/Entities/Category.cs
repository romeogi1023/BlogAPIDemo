using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogAPIDemo.Domain.Entities
{
   public class Category
    {
        public Category()
        {
            Post = new HashSet<Post>();
        }
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Post> Post { get; set; }

    }
}
