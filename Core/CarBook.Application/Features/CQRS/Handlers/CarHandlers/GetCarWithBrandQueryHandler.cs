using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                BrandName = x.Brand.BrandName,
                BrandID = x.BrandID,
                ImageUrl = x.ImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                GasType = x.GasType,
                Km = x.Km,
                Luggage = x.Luggage,
                CarName = x.CarName,
                PersonCount = x.PersonCount,
                Gear = x.Gear,
                Year = x.Year,
                CategoryID = x.CategoryID,
                CategoryName = x.Category.Name,
                RentPrice = x.RentPrice,
                IsActive = x.IsActive,
                IsShown = x.IsShown
            }).ToList();
        }
    }
}