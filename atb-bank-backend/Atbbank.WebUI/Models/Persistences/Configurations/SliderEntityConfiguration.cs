using Atbbank.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atbbank.WebUI.Models.Persistences.Configurations
{
    public class SliderEntityConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {

            builder.Property(m => m.Id).UseIdentityColumn(1, 1);
            builder.Property(m => m.Title).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(m => m.Description).HasColumnType("nvarchar").HasMaxLength(2000).IsRequired();
            builder.Property(m => m.ImgSrc).HasColumnType("nvarchar").IsRequired();
            builder.Property(m => m.Btn).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.ConfigureAsAudiTable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Sliders");
        }
    }


}
