using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Tags
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public Category Category { get; set; }

    }
}
