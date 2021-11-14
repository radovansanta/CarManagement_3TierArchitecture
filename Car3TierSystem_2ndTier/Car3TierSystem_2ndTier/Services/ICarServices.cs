using System.Collections.Generic;
using System.Threading.Tasks;
using Car3TierSystem_2ndTier.Models;

namespace Car3TierSystem_2ndTier.Services
{
    public interface ICarServices
    {
        Task<IList<Car>> GetCars();
        Task <Car> GetCar(string licensePlate);
        Task AddCar(Car car);
    }
}