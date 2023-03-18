using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public DateTime Time { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public PostComments PostComments { get; set; }
        public Comments Comments { get; set; }


    }
}
