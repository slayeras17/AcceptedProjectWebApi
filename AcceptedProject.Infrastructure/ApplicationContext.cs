using AcceptedProject.Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcceptedProject.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Match> Match { get; set; }
        public DbSet<MatchOdd> MatchOdds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchOdd>()
                .HasOne(p => p.Match)
                .WithMany(b => b.MatchOdds)
                .HasForeignKey(p => p.MatchId);
        }
    }
}
