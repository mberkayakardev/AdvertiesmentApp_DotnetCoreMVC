using AkarSoftware.Core.Dtos.Abstract;

namespace AkarSoftware.Dtos.Concrete.AdvertiesmentDtos
{
    public class AdvertiesmentListDto : IDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool ApplicationStatus { get; set; } // işe başvurulabilirlik statüsü 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
