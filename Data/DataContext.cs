using Microsoft.EntityFrameworkCore;
using ReviewApp.Models;

namespace ReviewApp.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountCategory> AccountCategories { get; set; }
        public DbSet<AccountOwner> AccountOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCategory>()
                .HasKey(pc => new { pc.AccountId, pc.CategoryId });
            modelBuilder.Entity<AccountCategory>()
                .HasOne(p => p.Account)
                .WithMany(pc => pc.AccountCategories)
                .HasForeignKey(p => p.AccountId);
            modelBuilder.Entity<AccountCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.AccountCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<AccountOwner>()
               .HasKey(po => new { po.AccountId, po.OwnerId });
            modelBuilder.Entity<AccountOwner>()
                .HasOne(p => p.Account)
                .WithMany(pc => pc.AccountOwners)
                .HasForeignKey(p => p.AccountId);
            modelBuilder.Entity<AccountOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.AccountOwners)
                .HasForeignKey(c => c.OwnerId);
        }


    }
}
