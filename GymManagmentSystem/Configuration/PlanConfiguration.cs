using GymManagmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationCheck", "DaurationDays between 1 and 365");
            });
        }
    }
}
