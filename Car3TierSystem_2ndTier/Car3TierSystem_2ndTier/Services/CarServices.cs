using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Car3TierSystem_2ndTier.Models;

namespace Car3TierSystem_2ndTier.Services
{
    public class CarServices : ICarServices
    {
        private string uri = "http://localhost:8080/api/";
        HttpClient client = new ();

        public async Task<IList<Car>> GetCars()
        {
            HttpResponseMessage response = await client.GetAsync($"{uri}cars");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string carsAsJson = await response.Content.ReadAsStringAsync();
                IList<Car> resultCars = JsonSerializer.Deserialize<IList<Car>>(carsAsJson);
                return resultCars;
            }
            return null;
        }

        public async Task<Car> GetCar(string licensePlate)
        {
            HttpResponseMessage response = await client.GetAsync($"{uri}cars/{licensePlate}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string carAsJson = await response.Content.ReadAsStringAsync();
                Car resultCar = JsonSerializer.Deserialize<Car>(carAsJson);
                return resultCar;
            }
            return null;
        }

        public async Task AddCar(Car car)
        {
            if (await GetCar(car.LicensePlate) == null)
            {
                string carAsJson = JsonSerializer.Serialize(car);
                HttpContent content = new StringContent(carAsJson,
                    Encoding.UTF8,
                    "application/json");
                HttpResponseMessage response = await client.PostAsync(uri+"cars", content);
                            
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
                }
            }
            else
            {
                throw new Exception("Car already exist");
            }
        }
    }
}