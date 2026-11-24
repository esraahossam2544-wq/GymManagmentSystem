using GymManagmentSystem.Models.Entities.Enum;

namespace GymManagmentSystem.Models.Entities
{
    public class Member:GymUser
    {
       
        public string Photo { get; set; }
        public ICollection<Membership> MemberSubscriptions { get; set; } = default!;


    }
}
