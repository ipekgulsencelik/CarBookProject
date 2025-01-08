﻿namespace CarBook.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandByIdQueryResult
    {
        public int BrandID { get; set; }
        public string? BrandName { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}