using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Context
{
    public class NotionWebAppContext : DbContext
    {

        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateData> TemplateDatas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


    }
}
