using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redditview.Models
{
    public class UserInfo
    {
        public DateTimeOffset CreatedDate { get; set; }
       public string Name { get; set; }
        public List<Comment> Comments { get; set; }
    }
}