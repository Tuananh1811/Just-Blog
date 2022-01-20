using FA.JustBlog.Core.BaseEntities;
using FA.JustBlog.Core.Enums;
using FA.JustBlog.Core.Models;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FA.JustBlog.Core
{
    public class JustBlogContext : DbContext
    {
        public JustBlogContext():base("name = connectionString")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
                        .Property(p => p.ShortDescription)
                        .HasMaxLength(500);

            modelBuilder.Entity<Post>()
                        .Property(p => p.PostContent)
                        .IsRequired();

            //modelBuilder.Entity<Post>()
            //            .HasMany<Tag>(p => p.Tags)
            //            .WithMany(t => t.Posts)
            //            .Map(pt =>
            //            {
            //                pt.MapLeftKey("PostId");
            //                pt.MapRightKey("TagId");
            //                pt.ToTable("PostTagMap");
            //            });

            modelBuilder.Entity<Comment>()
                        .HasRequired<Post>(c => c.Post)
                        .WithMany(p => p.Comments)
                        .HasForeignKey<int>(c => c.PostId);
        }

        public override int SaveChanges()
        {
            BeforeSaveChanges();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            BeforeSaveChanges();
            return base.SaveChangesAsync();
        }

        public void BeforeSaveChanges()
        {
            var entities = ChangeTracker.Entries();
            var now = DateTime.Now;

            foreach (var entity in entities)
            {
                if(entity is IBaseEntity BaseEntity)
                {
                    switch (entity.State)
                    {
                        case EntityState.Added:
                            BaseEntity.CreatedOn = now;
                            BaseEntity.UpdatedOn = now;
                            //BaseEntity.Status = Status.Active;
                            break;
                        case EntityState.Modified:
                            BaseEntity.UpdatedOn = now;
                            break;
                    }
                }
            }
        }
    }
}
