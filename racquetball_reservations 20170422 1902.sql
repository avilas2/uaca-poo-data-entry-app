﻿--
-- Script was generated by Devart dbForge Fusion for MySQL, Visual Studio Add-In, Version 6.4.11.2
-- Product home page: http://www.devart.com/dbforge/mysql/fusion
-- Script date 4/22/2017 7:02:45 PM
-- Server version: 5.7.14-google-log
-- Client version: 4.1
--


-- 
-- Disable foreign keys
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Set SQL mode
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8';

-- 
-- Set default database
--
USE racquetball_reservations;

--
-- Definition for table courts
--
DROP TABLE IF EXISTS courts;
CREATE TABLE courts (
  court_id INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  court_num VARCHAR(255) DEFAULT NULL,
  court_status ENUM('A','U') DEFAULT NULL,
  loc_id INT(10) UNSIGNED DEFAULT NULL,
  PRIMARY KEY (court_id)
)
ENGINE = INNODB
AUTO_INCREMENT = 6
AVG_ROW_LENGTH = 3276
CHARACTER SET utf8
COLLATE utf8_general_ci
ROW_FORMAT = DYNAMIC;

--
-- Definition for table locations
--
DROP TABLE IF EXISTS locations;
CREATE TABLE locations (
  loc_id INT(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  loc_name VARCHAR(50) DEFAULT NULL,
  loc_country VARCHAR(255) DEFAULT NULL,
  loc_state VARCHAR(255) DEFAULT NULL,
  loc_city VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (loc_id)
)
ENGINE = INNODB
AUTO_INCREMENT = 4
AVG_ROW_LENGTH = 8192
CHARACTER SET utf8
COLLATE utf8_general_ci
ROW_FORMAT = DYNAMIC;

--
-- Definition for table reservations
--
DROP TABLE IF EXISTS reservations;
CREATE TABLE reservations (
  res_id INT(11) NOT NULL AUTO_INCREMENT,
  res_time DATETIME NOT NULL,
  court_num VARCHAR(255) NOT NULL,
  user_id VARCHAR(9) NOT NULL,
  loc_id INT(10) NOT NULL,
  PRIMARY KEY (res_id)
)
ENGINE = INNODB
AUTO_INCREMENT = 3
CHARACTER SET utf8
COLLATE utf8_general_ci
ROW_FORMAT = DYNAMIC;

--
-- Definition for table users
--
DROP TABLE IF EXISTS users;
CREATE TABLE users (
  user_id VARCHAR(9) NOT NULL,
  user_firstName VARCHAR(50) NOT NULL,
  user_lastName VARCHAR(50) NOT NULL,
  user_fullName VARCHAR(50) DEFAULT NULL,
  user_age INT(10) UNSIGNED NOT NULL,
  user_skill VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (user_id),
  UNIQUE INDEX user_id (user_id)
)
ENGINE = INNODB
AVG_ROW_LENGTH = 2340
CHARACTER SET utf8
COLLATE utf8_general_ci
ROW_FORMAT = DYNAMIC;

DELIMITER $$

--
-- Definition for procedure createReservation
--
DROP PROCEDURE IF EXISTS createReservation$$
CREATE DEFINER = 'root'@'%'
PROCEDURE createReservation(IN res_time DATETIME, IN court_num VARCHAR(255), IN user_id VARCHAR(9), IN loc_id int(10))
BEGIN
INSERT INTO reservations (res_time, court_num, user_id, loc_id)
VALUES (res_time, court_num, user_id, loc_id);
END
$$

--
-- Definition for procedure createUser
--
DROP PROCEDURE IF EXISTS createUser$$
CREATE DEFINER = 'root'@'%'
PROCEDURE createUser(IN user_id varchar(9), IN user_firstName VARCHAR(255), IN user_lastName VARCHAR(255), IN user_age INT, IN user_skill VARCHAR(255))
  MODIFIES SQL DATA
BEGIN
INSERT INTO users (user_id, user_firstName, user_lastName, user_fullName, user_age, user_skill) 
VALUES (user_id, user_firstName, user_lastName, CONCAT(user_firstName, " ", user_lastName), user_age, user_skill); 
END
$$

DELIMITER ;

-- An error occurred while generating script for objects of type 'Triggers':
-- Expression #1 of SELECT list is not in GROUP BY clause and contains nonaggregated column 'information_schema.t1.EVENT_OBJECT_SCHEMA' which is not functionally dependent on columns in GROUP BY clause; this is incompatible with sql_mode=only_full_group_by

-- 
-- Dumping data for table courts
--
INSERT INTO courts VALUES
(1, '1', 'A', 1),
(2, '2', 'A', 2),
(3, '3', 'A', 1),
(4, '1', 'A', 2),
(5, '2', 'A', 1);

-- 
-- Dumping data for table locations
--
INSERT INTO locations VALUES
(1, 'San Jose Indoor Club', 'Costa Rica', 'San Jose', 'Curridabat'),
(2, 'Costa Rica Country Club', 'Costa Rica', 'San Jose', 'Escazu');

-- 
-- Dumping data for table reservations
--
INSERT INTO reservations VALUES
(2, '2017-04-15 07:37:24', '3', '115330723', 1);

-- 
-- Dumping data for table users
--
INSERT INTO users VALUES
('115330723', 'Sebastian', 'Avila', 'Sebastian Avila', 24, 'A'),
('12333421', 'Sebastian', 'Avila', 'Sebastian Avila', 34, 'D'),
('123412341', 'Daniel ', 'Fernandez', 'Daniel  Fernandez', 24, 'C'),
('123456777', 'Kane', 'Waselenchuk', 'Kane Waselenchuk', 32, 'Pro'),
('134530958', 'Marco', 'Acuña', 'Marco Acuña', 25, 'C'),
('140945823', 'Pablo', 'Arias', 'Pablo Arias', 28, 'C'),
('193459385', 'Brian', 'White', 'Brian White', 24, 'A');

-- 
-- Restore previous SQL mode
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Enable foreign keys
-- 
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;