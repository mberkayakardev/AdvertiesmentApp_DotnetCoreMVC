using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class AppUserRole : BaseEntity
    {
        public int AppUserId { get; set; } // FK
        public AppUser AppUser { get; set; }

        public int BaseRoleId { get; set; } //FK
        public AppRole BaseRole { get; set; }

    }
}
