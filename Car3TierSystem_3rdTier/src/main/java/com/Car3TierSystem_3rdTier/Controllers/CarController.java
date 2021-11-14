package com.Car3TierSystem_3rdTier.Controllers;

import com.Car3TierSystem_3rdTier.Models.Car;
import com.Car3TierSystem_3rdTier.Repositories.CarRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

@RestController
@RequestMapping("/api/")
public class CarController
{
  @Autowired
  private CarRepository carRepository;

  @GetMapping("/cars")
  public List<Car> getAllCars() {
    return carRepository.findAll();
  }

  @PostMapping("/cars")
  public Car createCar(@RequestBody Car car) {
    return carRepository.save(car);
  }

  @GetMapping("/cars/{license_plate}")
  public ResponseEntity<Car> getCarByLicensePlate(@PathVariable(value = "license_plate") String license_plate)
      throws Exception {
    Car car = carRepository.findById(license_plate).orElseThrow(() -> new Exception("Car not found"));
    return ResponseEntity.ok().body(car);
  }

  @DeleteMapping("/car/{license_plate}")
  public Map<String, Boolean> deleteCar(
      @PathVariable(value = "license_plate") String license_plate) throws Exception {
    Car car = carRepository.findById(license_plate)
        .orElseThrow(() -> new Exception("Car not found: "+ license_plate));

    carRepository.delete(car);
    Map<String, Boolean> response = new HashMap<>();
    response.put("deleted", Boolean.TRUE);
    return response;
  }
}
