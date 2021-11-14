CREATE SCHEMA car_database;

SET SCHEMA 'car_database';

--Car Domain
CREATE DOMAIN Brand VARCHAR(20);
CREATE DOMAIN Model VARCHAR(20);
CREATE DOMAIN LicensePlate VARCHAR(20);
CREATE DOMAIN Power INTEGER;

--User Table
CREATE TABLE Car
(
    license_plate LicensePlate PRIMARY KEY ,
    brand Brand,
    model  Model,
    power Power
);

INSERT INTO Car VALUES ('BA40136', 'Audi', 'A1',105);

--DROP SCHEMA car_database CASCADE;
