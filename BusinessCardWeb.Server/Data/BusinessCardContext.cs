using Microsoft.EntityFrameworkCore;
using BusinessCardWeb.Server.Data.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

public class BusinessCardContext : DbContext
{
    public DbSet<Member> Members { get; set; }

    public DbSet<MemberLocale> MemberLocales { get; set; }

    public DbSet<MemberContactOption> MemberContactOptions { get; set; }

    public DbSet<MemberJobAndService> MemberJobAndServices { get; set; }

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
        memberLocalBuilder.Property(ml => ml.Name)
            .IsRequired(false)
            .HasMaxLength(200);

        var memberContactOptionBuilder = modelBuilder.Entity<MemberContactOption>();
        memberContactOptionBuilder.ToTable(nameof(MemberContactOption))
            .HasKey(ml => new { ml.MemberId, ml.Name });
        memberContactOptionBuilder.Property(mco => mco.Href)
            .IsRequired(false)
            .HasMaxLength(200);

        var memberJobAndServiceBuilder = modelBuilder.Entity<MemberJobAndService>();
        memberJobAndServiceBuilder.ToTable(nameof(MemberJobAndService))
            .HasKey(mjs => mjs.Id);
        memberJobAndServiceBuilder.Property(mjs => mjs.EnumType)
            .IsRequired()
            .HasConversion<string>();
        memberJobAndServiceBuilder.Property(mjs => mjs.Description)
            .IsRequired()
            .HasMaxLength(200);

    }
}