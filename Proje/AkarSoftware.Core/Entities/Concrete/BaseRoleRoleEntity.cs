using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class BaseRoleRoleEntity : BaseEntity
    {
        public int BaseRoleId { get; set; }
        public BaseRole BaseRole { get; set; }

        public int RoleId { get; set; }
        public AppRole Role { get; set; }

    }
}
