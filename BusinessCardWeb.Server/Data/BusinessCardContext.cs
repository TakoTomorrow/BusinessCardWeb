using Microsoft.EntityFrameworkCore;
using BusinessCardWeb.Server.Data.Entities;
using System.Collections.Generic;

public class BusinessCardContext : DbContext
{
    public DbSet<Member> Members { get; set; }

    public BusinessCardContext(DbContextOptions<BusinessCardContext> options)
        : base(options)
    {
        // This constructor is used when the context is created by dependency injection.
        // The DbPath will be set in the OnConfiguring method.
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>().ToTable(nameof(Member));

        var memberLocalBuilder = modelBuilder.Entity<MemberLocale>();

        memberLocalBuilder.ToTable(nameof(MemberLocale))
            .HasKey(ml => new { ml.MemberId, ml.Locale });

    }
}