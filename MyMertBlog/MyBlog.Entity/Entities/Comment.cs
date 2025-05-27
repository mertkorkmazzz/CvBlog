using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.Entities
{
    public class Comment : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Description { get; set; }

      
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid UserId { get; set; }  
        public AppUser User { get; set; } 
    }
}
