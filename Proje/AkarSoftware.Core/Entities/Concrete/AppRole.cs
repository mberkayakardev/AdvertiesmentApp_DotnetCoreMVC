using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    // Kullanıcı Normal Rolleri 
    public class AppRole : BaseEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        #region Navigation Property 
        List<AppUserRole> AppUserRoles { get; set; }
        #endregion
    }
}
