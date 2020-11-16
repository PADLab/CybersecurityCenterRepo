using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using CyberTool.Models.PublicationBibs;

namespace CyberTool.Data
{
  public partial class PublicationBibsContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public PublicationBibsContext(DbContextOptions<PublicationBibsContext> options):base(options)
    {
    }

    public PublicationBibsContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<CyberTool.Models.PublicationBibs.PublicationBibsPublication>()
              .Property(p => p.id)
              .HasDefaultValueSql("nextval('cyber.publications_id_seq'::regclass)");


        this.OnModelBuilding(builder);
    }


    public DbSet<CyberTool.Models.PublicationBibs.PublicationBibsPublication> PublicationBibsPublications
    {
      get;
      set;
    }
  }
}
