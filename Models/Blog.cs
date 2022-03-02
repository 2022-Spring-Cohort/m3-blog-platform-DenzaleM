using System;




namespace template_csharp_blog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        
                 
        public string Publishdate { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

      public string Content { get; set; }

        public string Catergory { get; set; }

        public virtual Author Author { get; set; } 

       
        
    }
}
