CREATE TABLE `rednose`.`stores` (
  `number` VARCHAR(10) NOT NULL,
  `storeType` TINYINT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `street` VARCHAR(50) NOT NULL,
  `postalCode` VARCHAR(10) NOT NULL,
  `city` VARCHAR(45) NOT NULL,
  `county` VARCHAR(45) NOT NULL,
  `phone` VARCHAR(20) NOT NULL,
  `services` VARCHAR(45) NOT NULL,
  `searchWords` JSON NOT NULL,
  `openingHours` JSON NOT NULL,
  `rt90x` VARCHAR(20) NOT NULL,
  `rt90y` VARCHAR(25) NOT NULL,
  `added` DATETIME NOT NULL,
  `updated` DATETIME NOT NULL,
  PRIMARY KEY (`number`));
