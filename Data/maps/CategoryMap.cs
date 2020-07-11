using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webAppMaterialControl.Api.Models;


namespace webAppMaterialControl.Api.Data.Maps
{

public class CategoryMap: IEntityTypeConfiguration<Category>
{
  public void Configure(EntityTypeBuilder<Category> builder)
  {
      builder.ToTable("Category");
      builder.HasKey(x => x.Id);
      builder.Property(x =>x.CategoryName).IsRequired().HasMaxLength(80).HasColumnType("varchar(120)");
  }
}

}