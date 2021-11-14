using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Car3TierSystem_1stTier.Models;

namespace Car3TierSystem_1stTier.Services
{
    public class CarServices : ICarServices
    {
        private string uri = "https://localhost:1234";
        private readonly HttpClient _client;
        
        public CarServices()
        {
            _client = new HttpClient();
        }

        public async Task<IList<Car>> GetCars()
        {
            HttpResponseMessage response = await _client.GetAsync(uri+"/Car");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string carsAsJson = await response.Content.ReadAsStringAsync();
                IList<Car> resultCars = JsonSerializer.Deserialize<IList<Car>>(carsAsJson);
                
                return resultCars;
            }
            throw new Exception("Cars not found");
        }

        public async Task<Car> GetCar(string licensePlate)
        {
            HttpResponseMessage response = await _client.GetAsync(uri+"/Car/licensePlate?licensePlate="+licensePlate);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string carAsJson = await response.Content.ReadAsStringAsync();
                Car resultCar = JsonSerializer.Deserialize<Car>(carAsJson);
                
                return resultCar;
                
            } 
            throw new Exception("Car not found");
        }

        public async Task AddCar(Car car)
        {
            string carAsJson = JsonSerializer.Serialize(car);
            HttpContent content = new StringContent(carAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await _client.PostAsync(uri + "/Car", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}