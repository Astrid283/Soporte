-- MySQL Script generated by MySQL Workbench
-- Sat Nov  5 11:38:14 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Examen_IIParcial
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Examen_IIParcial
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Examen_IIParcial` DEFAULT CHARACTER SET utf8 ;
USE `Examen_IIParcial` ;

-- -----------------------------------------------------
-- Table `Examen_IIParcial`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_IIParcial`.`Usuario` (
  `Correo` NVARCHAR(150) NOT NULL,
  `Nombre` NVARCHAR(45) NOT NULL,
  `Clave` NVARCHAR(45) NOT NULL,
  PRIMARY KEY (`Correo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen_IIParcial`.`Soporte`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_IIParcial`.`Soporte` (
  `Codigo` INT NOT NULL,
  `TipoSoporte` NVARCHAR(45) NOT NULL,
  `Cantidad` INT NOT NULL,
  `Precio` DECIMAL(9,2) NOT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen_IIParcial`.`Ticket`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen_IIParcial`.`Ticket` (
  `Fecha` DATETIME NOT NULL,
  `CorreoUsuario` NVARCHAR(50) NOT NULL,
  `Cliente` NVARCHAR(50) NOT NULL,
  `TipoSoporte` NVARCHAR(45) NOT NULL,
  `DescripcionSolicitud` NVARCHAR(50) NOT NULL,
  `DescripcionRespuesta` NVARCHAR(50) NOT NULL,
  `Precio` DECIMAL(9,2) NOT NULL,
  `ISV` DECIMAL(9,2) NOT NULL,
  `Descuento` DECIMAL(9,2) NOT NULL,
  `Total` DECIMAL(9,2) NOT NULL,
  INDEX `FK_Ticket_Usuario_idx` (`CorreoUsuario` ASC) VISIBLE,
  INDEX `FK_Ticket_Usuario_idx1` (`TipoSoporte` ASC) VISIBLE,
  PRIMARY KEY (`CorreoUsuario`),
  CONSTRAINT `FK_Ticket_Usuario`
    FOREIGN KEY (`CorreoUsuario`)
    REFERENCES `Examen_IIParcial`.`Usuario` (`Correo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Ticket_Usuario`
    FOREIGN KEY (`TipoSoporte`)
    REFERENCES `Examen_IIParcial`.`Soporte` (`TipoSoporte`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
