﻿using AkarSoftware.Core.Dtos.Abstract;

namespace AkarSoftware.Dtos.Concrete.ProviderServicesDtos
{
    public class AddProviderServiceDto : IDto
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int ListOrder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
