using AkarSoftware.Core.Entities.Abstract;
using AkarSoftware.Core.Entities.Concrete;

namespace AkarSoftware.Entities.Concrete
{
    public class AdvertiesmentUser : BaseEntity
    {
        public string? CoverLetter { get; set; }
        public DateTime? EndDate { get; set; } // Military Statü bitiş tarihi (Tecil için)
        public int WorkExperiance { get; set; }
        public string CvPath { get; set; }
        public int AppUserId { get; set; }
        public AppUser ApplyUser { get; set; }
        public int AdvertiesmentId { get; set; }
        public Advertiesment Advertiesment { get; set; }
        public int AdvertiesmentUserApplyStatusId { get; set; }
        public AdvertiesmentUserApplyStatus advertiesmentUserApplyStatus { get; set; }
        public int MilitaryStatusId { get; set; }
        public MilitaryStatus MilitaryStatus { get; set; }
    }
}
