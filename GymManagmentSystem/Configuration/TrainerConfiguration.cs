using GymManagmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class TrainerConfiguration : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
                 
            base.Configure(builder);
        }
    

    }
}
