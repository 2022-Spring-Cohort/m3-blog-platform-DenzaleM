using System.Collections.Generic;

namespace template_csharp_blog.Models
{
    public class Author
    {
        public int Id {get;set;}

        public string Firstname { get;set;}

        public string Lastname { get;set;}

        
        public string Email { get;set;}

        public virtual List<Blog> Blogs { get; set; }
    }
}
