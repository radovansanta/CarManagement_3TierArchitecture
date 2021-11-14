using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Car3TierSystem_2ndTier.Models;
using Car3TierSystem_2ndTier.Services;
using Microsoft.AspNetCore.Mvc;

namespace Car3TierSystem_2ndTier.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carServices;
        
        public CarController(ICarServices carServices) => this._carServices = carServices;
        
        [HttpGet]
        public async Task<ActionResult<IList<Car>>> GetCars()
        {
            try
            {
                IList<Car> cars = await _carServices.GetCars();
                return Ok(cars);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet("licensePlate")]
        public async Task<ActionResult<Car>> GetCar([FromQuery] string licensePlate)
        {
            try
            {
                Car car = await _carServices.GetCar(licensePlate);
                return Ok(car);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        
        [HttpPost]
        public async Task<ActionResult<Car>> AddCar([FromBody] Car car)
        {
            try 
            {
                await _carServices.AddCar(car);
                return Created($"/cars", car); 
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                throw; 
            }
        }
        
    }
}