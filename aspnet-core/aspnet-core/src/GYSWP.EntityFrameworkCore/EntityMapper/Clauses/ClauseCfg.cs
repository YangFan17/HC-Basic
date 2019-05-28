

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GYSWP.Clauses;

namespace GYSWP.EntityMapper.Clauses
{
    public class ClauseCfg : IEntityTypeConfiguration<Clause>
    {
        public void Configure(EntityTypeBuilder<Clause> builder)
        {

            builder.ToTable("Clauses", YoYoAbpefCoreConsts.SchemaNames.CMS);

            
			builder.Property(a => a.ParentId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Type).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.DocumentId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


        }
    }
}


