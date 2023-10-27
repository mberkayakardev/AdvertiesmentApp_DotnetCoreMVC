using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class BaseRole : BaseEntity
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        #region Navigation Properties 
        public List<UserBaseRoles> SubRoles { get; set; }
        public List<BaseRoleRoleEntity> Roles { get; set; }
        #endregion

    }
}
