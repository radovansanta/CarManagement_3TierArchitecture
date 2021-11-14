package com.Car3TierSystem_3rdTier.Models;

import javax.persistence.*;

@Entity
@Table(name = "car")
public class Car
{
  private String license_plate;
  private String brand;
  private String model;
  private int power;

  public Car(){

  }

  public Car(String license_plate, String brand, String model, int power){
    this.license_plate = license_plate;
    this.brand = brand;
    this.model = model;
    this.power = power;
  }

  @Id
  @Column(name = "license_plate", nullable = false)
  public String getLicense_plate()
  {
    return license_plate;
  }

  public void setLicense_plate(String license_plate)
  {
    this.license_plate = license_plate;
  }

  @Column(name = "brand", nullable = false)
  public String getBrand()
  {
    return brand;
  }

  public void setBrand(String brand)
  {
    this.brand = brand;
  }

  @Column(name = "model", nullable = false)
  public String getModel()
  {
    return model;
  }

  public void setModel(String model)
  {
    this.model = model;
  }

  @Column(name = "power", nullable = false)
  public int getPower()
  {
    return power;
  }

  public void setPower(int power)
  {
    this.power = power;
  }

  @Override public String toString()
  {
    return "Car{" + "license_plate='" + license_plate + '\'' + ", brand='"
        + brand + '\'' + ", model='" + model + '\'' + ", power=" + power + '}';
  }
}
