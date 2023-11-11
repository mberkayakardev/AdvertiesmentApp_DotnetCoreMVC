using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Core.Entities.Concrete
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }
        public List<AppUser> AppUsers { get; set; } // cinsiyet bilgisi üzerinden kullanıcı listelemeye yaramaktadır. 
    }
}
