using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.Entities
{
    public class Project : EntityBase
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

    }
}
