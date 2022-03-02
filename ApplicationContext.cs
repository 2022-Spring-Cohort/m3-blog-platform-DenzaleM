using Microsoft.EntityFrameworkCore;

using template_csharp_blog.Models;

namespace template_csharp_blog
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Blog> Blogs{ get; set; }

        public DbSet<Author> Authors{ get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=Blog2022; Trusted_connection=True").UseLazyLoadingProxies();
           
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(new Author() { Id = 1, Firstname = "Denzale", Lastname = "McIntyre", Email = "MacAtack92" });
            builder.Entity<Author>().HasData(new Author() { Id = 2, Firstname = "Storm", Lastname = "Kendall", Email = "Stormyweather" });
            builder.Entity<Author>().HasData(new Author() { Id = 3, Firstname = "Chris", Lastname = "Cannon", Email = "FiremanCannon" });

            builder.Entity<Blog>().HasData(new Blog() {Id=1, Publishdate = "2-4-2020" , Title="Why Mirio is the G.O.A.T",Catergory="Sci-Fi",Content="Not only does he use his power for the need of others but he also inspires other as well", AuthorId=1});
            builder.Entity<Blog>().HasData(new Blog() {Id=2,  Publishdate = "9 - 18 - 2020", Title = "Why the steelers rule", Catergory = "Sports",Content="I just like Big Ben", AuthorId=2 });
            builder.Entity<Blog>().HasData(new Blog() {Id=3, Publishdate = "05 - 12 - 2020", Title = "Andrew was the best Spiderman", Catergory = "Movies",Content="Andrew played his role of Peter Parker AND Spider-Man better than all the other actors", AuthorId=3});

        }

       
    }

}