using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Entities.Concrete
{
    public class AdvertiesmentUserApplyStatus : BaseEntity
    {
        public string Status { get; set; }
        public string StatuDescription { get; set; }
        public List<AdvertiesmentUser> AdvertiesmentUsers { get; set; }
    }
}
