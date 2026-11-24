using GymManagmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configuration
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(x => x.plan)
                .WithMany(x => x.PlanSubscription)
                .HasForeignKey(x => x.PlanId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasKey(x => x.Member);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(x => x.Member)
                .WithMany(x => x.MemberSubscriptions)
                .HasForeignKey(x => x.MemberId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
