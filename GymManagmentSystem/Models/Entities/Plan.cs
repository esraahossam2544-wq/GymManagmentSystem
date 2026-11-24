namespace GymManagmentSystem.Models.Entities
{
    public class Plan:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationDays { get; set; }
        public decimal price { get; set; }
        public bool IsActive { get; set; }

        //Relationship
        public ICollection<Membership> PlanSubscription { get; set; } = default!;

    }
}
