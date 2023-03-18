using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public string Feedback { get; set; }
        public int PostId { get; set; }
    }
}
