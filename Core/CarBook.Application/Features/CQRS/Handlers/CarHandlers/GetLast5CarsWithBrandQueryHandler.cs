using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5CarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
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