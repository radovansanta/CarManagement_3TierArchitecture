package com.Car3TierSystem_3rdTier;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.jpa.repository.config.EnableJpaAuditing;

@SpringBootApplication
@EnableJpaAuditing
public class Car3TierSystem3rdTierApplication {

	public static void main(String[] args) {
		SpringApplication.run(Car3TierSystem3rdTierApplication.class, args);
	}

}
