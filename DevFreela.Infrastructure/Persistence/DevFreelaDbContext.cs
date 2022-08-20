using System.Reflection;
using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public  DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base()
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Skill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // referencia Assembly chcar se é correto
            
            modelBuilder.Entity<Skill>()
                .HasKey(s => s.Id);
            
            modelBuilder.Entity<UserSkill>()
                .HasKey(s => s.Id);
        }
    }
}