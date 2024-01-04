using Atbbank.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atbbank.WebUI.Models.Persistences.Configurations
{
    public class NewEntityConfiguration : IEntityTypeConfiguration<New>
    {
        public void Configure(EntityTypeBuilder<New> builder)
        {

            builder.Property(m => m.Id).UseIdentityColumn(1, 1);
            builder.Property(m => m.Title).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(m => m.Description).HasColumnType("nvarchar").HasMaxLength(2000).IsRequired();
            builder.Property(m => m.Date).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.ConfigureAsAudiTable();


            builder.HasKey(m => m.Id);
            builder.ToTable("News");
        }
    }


}
