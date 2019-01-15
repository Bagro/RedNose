CREATE TABLE `rednose`.`products` (
  `number` INT NOT NULL,
  `productId` INT NOT NULL,
  `productNumber` INT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `name2` VARCHAR(100) NULL,
  `price` DECIMAL(8,2) NOT NULL,
  `size` DECIMAL(8,2) NOT NULL,
  `pricePerLitre` DECIMAL(8,2) NOT NULL,
  `startOfSale` DATE NOT NULL,
  `discontinued` TINYINT NOT NULL,
  `productGroup` VARCHAR(45) NOT NULL,
  `type` VARCHAR(45) NOT NULL,
  `style` VARCHAR(45) NOT NULL,
  `packaging` VARCHAR(100) NOT NULL,
  `seal` VARCHAR(45) NOT NULL,
  `origin` VARCHAR(45) NOT NULL,
  `countryOfOrigin` VARCHAR(45) NOT NULL,
  `producer` VARCHAR(100) NOT NULL,
  `supplier` VARCHAR(100) NOT NULL,
  `year` SMALLINT NOT NULL,
  `yearTested` SMALLINT NOT NULL,
  `alcohol` VARCHAR(10) NOT NULL,
  `assortment` VARCHAR(45) NOT NULL,
  `assortmentText` MEDIUMTEXT NOT NULL,
  `ecological` TINYINT NOT NULL,
  `ethically` TINYINT NOT NULL,
  `koscher` TINYINT NOT NULL,
  `rawMaterialDescription` MEDIUMTEXT NOT NULL,
  `added` DATETIME NOT NULL,
  `updated` DATETIME NOT NULL,
  PRIMARY KEY (`number`));
