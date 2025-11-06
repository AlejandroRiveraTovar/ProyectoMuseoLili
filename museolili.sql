-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: museolili
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `idCategoria` int NOT NULL AUTO_INCREMENT,
  `nombreCategoria` varchar(50) NOT NULL,
  `descripcionCategoria` varchar(50) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `colecciones`
--

DROP TABLE IF EXISTS `colecciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `colecciones` (
  `UUIDColeccion` varchar(50) NOT NULL,
  `nombreColeccion` varchar(50) NOT NULL,
  `fechaCreacionC` datetime NOT NULL,
  `descripcionColeccion` varchar(50) NOT NULL,
  PRIMARY KEY (`UUIDColeccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colecciones`
--

LOCK TABLES `colecciones` WRITE;
/*!40000 ALTER TABLE `colecciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `colecciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalles_pe`
--

DROP TABLE IF EXISTS `detalles_pe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalles_pe` (
  `idDP` int NOT NULL AUTO_INCREMENT,
  `UUIDPieza_PDP` varchar(50) NOT NULL,
  `UUIDPrestamo_Externo_PEDP` varchar(50) NOT NULL,
  PRIMARY KEY (`idDP`),
  KEY `UUIDPieza_PDP_FK_idx` (`UUIDPieza_PDP`),
  KEY `UUIDPrestamo_Externo_PEDP_FK_idx` (`UUIDPrestamo_Externo_PEDP`),
  CONSTRAINT `UUIDPieza_PDP_FK` FOREIGN KEY (`UUIDPieza_PDP`) REFERENCES `piezas` (`UUIDPieza`),
  CONSTRAINT `UUIDPrestamo_Externo_PEDP_FK` FOREIGN KEY (`UUIDPrestamo_Externo_PEDP`) REFERENCES `prestamos_externos` (`UUIDPrestamo_Externo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalles_pe`
--

LOCK TABLES `detalles_pe` WRITE;
/*!40000 ALTER TABLE `detalles_pe` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles_pe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exhibiciones`
--

DROP TABLE IF EXISTS `exhibiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exhibiciones` (
  `UUIDExhibicion` varchar(50) NOT NULL,
  `nombreExhibicion` varchar(50) NOT NULL,
  `descripcionExhibicion` varchar(50) NOT NULL,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`UUIDExhibicion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exhibiciones`
--

LOCK TABLES `exhibiciones` WRITE;
/*!40000 ALTER TABLE `exhibiciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `exhibiciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fotos_piezas`
--

DROP TABLE IF EXISTS `fotos_piezas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fotos_piezas` (
  `UUIDFotoP` varchar(50) NOT NULL,
  `nombreFotoP` varchar(50) NOT NULL,
  `archivoFotoP` longblob NOT NULL,
  `UUIDPieza_PFP` varchar(50) NOT NULL,
  PRIMARY KEY (`UUIDFotoP`),
  KEY `UUIDPieza_PFP_FK_idx` (`UUIDPieza_PFP`),
  CONSTRAINT `UUIDPieza_PFP_FK` FOREIGN KEY (`UUIDPieza_PFP`) REFERENCES `piezas` (`UUIDPieza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fotos_piezas`
--

LOCK TABLES `fotos_piezas` WRITE;
/*!40000 ALTER TABLE `fotos_piezas` DISABLE KEYS */;
/*!40000 ALTER TABLE `fotos_piezas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiales`
--

DROP TABLE IF EXISTS `materiales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiales` (
  `UUIDMaterial` varchar(50) NOT NULL,
  `nombreMaterial` varchar(50) NOT NULL,
  PRIMARY KEY (`UUIDMaterial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiales`
--

LOCK TABLES `materiales` WRITE;
/*!40000 ALTER TABLE `materiales` DISABLE KEYS */;
/*!40000 ALTER TABLE `materiales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiales_piezas`
--

DROP TABLE IF EXISTS `materiales_piezas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiales_piezas` (
  `idMP` int NOT NULL AUTO_INCREMENT,
  `UUIDPieza_PMP` varchar(50) NOT NULL,
  `UUIDMaterial_MMP` varchar(50) NOT NULL,
  PRIMARY KEY (`idMP`),
  KEY `UUIDPieza_PMP_FK_idx` (`UUIDPieza_PMP`),
  KEY `UUIDMaterial_MMP_FK_idx` (`UUIDMaterial_MMP`),
  CONSTRAINT `UUIDMaterial_MMP_FK` FOREIGN KEY (`UUIDMaterial_MMP`) REFERENCES `materiales` (`UUIDMaterial`),
  CONSTRAINT `UUIDPieza_PMP_FK` FOREIGN KEY (`UUIDPieza_PMP`) REFERENCES `piezas` (`UUIDPieza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiales_piezas`
--

LOCK TABLES `materiales_piezas` WRITE;
/*!40000 ALTER TABLE `materiales_piezas` DISABLE KEYS */;
/*!40000 ALTER TABLE `materiales_piezas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `piezas`
--

DROP TABLE IF EXISTS `piezas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `piezas` (
  `UUIDPieza` varchar(50) NOT NULL,
  `nombrePieza` varchar(50) NOT NULL,
  `descripcionPieza` varchar(50) NOT NULL,
  `fechaIngresoPieza` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fechaAproxCP` date NOT NULL,
  `AltoP` float NOT NULL,
  `AnchoP` float NOT NULL,
  `Profundidad` float NOT NULL,
  `ubicacionP` varchar(50) NOT NULL,
  `estadoConservacion` varchar(50) NOT NULL,
  `UUIDUsuario_UP` varchar(50) NOT NULL,
  `UUIDColeccion_CP` varchar(50) NOT NULL,
  `idCategoria_CP` int NOT NULL,
  PRIMARY KEY (`UUIDPieza`),
  KEY `UUIDUsuario_UP_FK_idx` (`UUIDUsuario_UP`),
  KEY `UUIDColeccion_CP_FK_idx` (`UUIDColeccion_CP`),
  KEY `idCategoria_CP_idx` (`idCategoria_CP`),
  CONSTRAINT `idCategoria_CP_FK` FOREIGN KEY (`idCategoria_CP`) REFERENCES `categorias` (`idCategoria`),
  CONSTRAINT `UUIDColeccion_CP_FK` FOREIGN KEY (`UUIDColeccion_CP`) REFERENCES `colecciones` (`UUIDColeccion`),
  CONSTRAINT `UUIDUsuario_UP_FK` FOREIGN KEY (`UUIDUsuario_UP`) REFERENCES `usuarios` (`UUIDUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `piezas`
--

LOCK TABLES `piezas` WRITE;
/*!40000 ALTER TABLE `piezas` DISABLE KEYS */;
/*!40000 ALTER TABLE `piezas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `piezas_exhibiciones`
--

DROP TABLE IF EXISTS `piezas_exhibiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `piezas_exhibiciones` (
  `idPieza_Exhibicion` int NOT NULL AUTO_INCREMENT,
  `UUIDPieza_PPE` varchar(50) NOT NULL,
  `UUIDExhibicion_EPE` varchar(50) NOT NULL,
  PRIMARY KEY (`idPieza_Exhibicion`),
  KEY `UUIDPieza_PPE_FK_idx` (`UUIDPieza_PPE`),
  KEY `UUIDExhibicion_EPE_FK_idx` (`UUIDExhibicion_EPE`),
  CONSTRAINT `UUIDExhibicion_EPE_FK` FOREIGN KEY (`UUIDExhibicion_EPE`) REFERENCES `exhibiciones` (`UUIDExhibicion`),
  CONSTRAINT `UUIDPieza_PPE_FK` FOREIGN KEY (`UUIDPieza_PPE`) REFERENCES `piezas` (`UUIDPieza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `piezas_exhibiciones`
--

LOCK TABLES `piezas_exhibiciones` WRITE;
/*!40000 ALTER TABLE `piezas_exhibiciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `piezas_exhibiciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prestamos_externos`
--

DROP TABLE IF EXISTS `prestamos_externos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prestamos_externos` (
  `UUIDPrestamo_Externo` varchar(50) NOT NULL,
  `institucion` varchar(50) NOT NULL,
  `direccionI` varchar(50) NOT NULL,
  `fechaPrestamo` datetime NOT NULL,
  `fechaDevolucion` datetime NOT NULL,
  `descripcionPrestamoExterno` varchar(50) NOT NULL,
  PRIMARY KEY (`UUIDPrestamo_Externo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prestamos_externos`
--

LOCK TABLES `prestamos_externos` WRITE;
/*!40000 ALTER TABLE `prestamos_externos` DISABLE KEYS */;
/*!40000 ALTER TABLE `prestamos_externos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRol` int NOT NULL AUTO_INCREMENT,
  `nombreRol` varchar(50) NOT NULL,
  `descripcionRol` varchar(50) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador','Inserta, actualiza y borra piezas'),(2,'Estudiante','Consulta piezas'),(3,'Profesor','Presta piezas'),(4,'Temporal','Consulta piezas');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `UUIDUsuario` varchar(50) NOT NULL,
  `cedulaUsuario` varchar(50) NOT NULL,
  `nombre1Usuario` varchar(50) NOT NULL,
  `nombre2Usuario` varchar(50) DEFAULT NULL,
  `apellido1Usuario` varchar(50) NOT NULL,
  `apellido2Usuario` varchar(50) DEFAULT NULL,
  `emailUsuario` varchar(50) NOT NULL,
  `telefonoUsuario` varchar(50) NOT NULL,
  `passwordUsuario` varchar(50) NOT NULL,
  `idRol_RU` int NOT NULL,
  PRIMARY KEY (`UUIDUsuario`),
  KEY `idRol_RU_FK_idx` (`idRol_RU`),
  CONSTRAINT `idRol_RU_FK` FOREIGN KEY (`idRol_RU`) REFERENCES `roles` (`idRol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('','1110365790','Jose','','Criollo','','jose.criollo@uao.edu.co','3138457820','1234',4),('03228ebd-83db-4c58-9405-27ca30335cff','1110365790','jose','','criollo','','jose.criollo@uao.edu.co','3138457820','1234',4),('05afd23d-5c19-4fc1-8b07-622a32f075eb','123123132','Juan','Andres','Tovar','Rivera','juanT@uao.edu.co','313145622','josejose',4),('USR001','1001234567','Carlos','Andrés','Pérez','Gómez','carlos.perez@example.com','3114567890','jose',1),('USR002','1009876543','María','Elena','Rodríguez','Lopez','maria.rodriguez@example.com','3209876543','abcd',2),('USR003','1011122233','Juan','David','García','Martínez','juan.garcia@example.com','3001234567','pass',1),('USR004','1022334455','Luisa','Fernanda','Torres','Rivas','luisa.torres@example.com','3157654321','0000',3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-06 10:32:34
