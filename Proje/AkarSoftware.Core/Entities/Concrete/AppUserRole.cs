using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class AppUserRole : BaseEntity
    {
        public int Id { get; set; } // PK
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int BaseRoleId { get; set; }
        public AppRole BaseRole { get; set; }


    }
}
