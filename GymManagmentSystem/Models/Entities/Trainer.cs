using GymManagmentSystem.Models.Entities.Enum;

namespace GymManagmentSystem.Models.Entities
{
    public class Trainer:GymUser
    {
        
        public DateTime HireDate { get; set; }
        public Specialities Specialities { get; set; }

        //Relationship
        public ICollection<Session> Sessions { get; set; } = default!;

    }
}
