using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; } // Username users (uniqe)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OptionalName { get; set; }
        public string Email { get; set; } 
        public bool EmailConfirmed { get; set; } = false;
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; } = false;
        public bool TwoFactorAuthenticaton { get; set; } 
        public bool AlwaysLockAccount { get; set; } // Always locked. 
        public DateTime? LockOutEndDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string PasswordHash { get; set; }
        public bool Status { get; set; } = true;
        public int GendersId { get; set; }
        public Gender Genders { get; set; }
        #region Navigation Properties 
        public List<AppUserRole> AppUserRoles { get; set; }
        #endregion

    }
}
