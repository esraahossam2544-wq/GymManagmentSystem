using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagmentSystem.Models.Entities
{
    public class Membership : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan plan { get; set; } = default!;

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing" :
            EndDate> DateTime.Now? "Active" :
            "Expired";



    }   }