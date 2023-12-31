﻿using AkarSoftware.Core.Dtos.Abstract;

namespace AkarSoftware.Dtos.Concrete.ProviderServicesDtos
{
    public class ListProviderServiceDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int ListOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
