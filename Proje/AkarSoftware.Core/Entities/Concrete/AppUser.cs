using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class AppUser : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; } // Username users (uniqe)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OptionalName { get; set; }
        public string Email { get; set; } 
        public bool EmailConfirmed { get; set; } = false;
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; } = false;
        public bool TwoFactorAuthenticaton { get; set; } 
        public bool AlwaysLockAccount { get; set; } // bir hesap kalıcı bir şekilde blokelenebilir. bu özellik bunu sağlamaktadır. 
        public DateTime? LockOutEndDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; } = true;

        #region Navigation Properties 
        public List<UserBaseRoles> UserMasterRoles { get; set; }

        #endregion

    }
}
