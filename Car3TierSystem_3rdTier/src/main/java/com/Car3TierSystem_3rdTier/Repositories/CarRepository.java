package com.Car3TierSystem_3rdTier.Repositories;

import com.Car3TierSystem_3rdTier.Models.Car;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface CarRepository extends JpaRepository<Car, String>
{
}
