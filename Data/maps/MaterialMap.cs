using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAppMaterialControl.Api.Models;

namespace webAppMaterialControl.Api.Data.Maps
{

  public class MaterialMap : IEntityTypeConfiguration<Material>
  {
    public void Configure(EntityTypeBuilder<Material> builder)
    {
      builder.ToTable("Material");
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).HasColumnType("varchar(80)").IsRequired();
      builder.Property(x => x.Description).HasColumnType("varchar(200)");
      builder.HasOne(x => x.Category).WithMany(x => x.Materials);

    }
  }


}