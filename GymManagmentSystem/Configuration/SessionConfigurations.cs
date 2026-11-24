using GymManagmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Configuration
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityConstrain", "Capacity between 1 and 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate>StartDate");
            });
            builder.HasOne(x => x.Trainer)
                .WithMany(x => x.Sessions)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
