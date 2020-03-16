using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPIDemo.Domain.Entities
{
    public class PostTag
    {
        public PostTag()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Post Post { get; set; }

    }
}
