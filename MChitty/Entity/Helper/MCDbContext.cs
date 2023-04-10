using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MChitty.Entity.Helper
{
    public class MCDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MCDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("MCDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChittyMember>()
                    .HasOne(e => e.Chitty)
                    .WithMany(e => e.ChittyMembers)
                    .HasPrincipalKey(e=>e.Id)
                    .HasForeignKey(e => e.ChittyId)
                    .IsRequired();
            modelBuilder.Entity<ChittyMember>()
                    .HasOne(e => e.Member)
                    .WithMany(e => e.ChittyMembers)
                    .HasPrincipalKey(e => e.Id)
                    .HasForeignKey(e => e.MemberId)
                    .IsRequired();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chitty> Chittys { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ChittyMember> ChittyMembers { get; set; }
    }
}
