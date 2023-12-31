﻿using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Entities.Concrete
{
    /// <summary>
    /// İlanlar. 
    /// </summary>
    public class Advertiesment: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool ApplicationStatus { get; set; } // işe başvurulabilirlik statüsü 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<AdvertiesmentUser> AdvertiesmentUsers { get; set; }

    }
}
