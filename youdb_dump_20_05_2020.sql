-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: youdb
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `access_method`
--

DROP TABLE IF EXISTS `access_method`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `access_method` (
  `id_m` int NOT NULL AUTO_INCREMENT,
  `name_method` varchar(100) NOT NULL,
  `short_name_m` varchar(100) NOT NULL,
  PRIMARY KEY (`id_m`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `access_method`
--

LOCK TABLES `access_method` WRITE;
/*!40000 ALTER TABLE `access_method` DISABLE KEYS */;
INSERT INTO `access_method` VALUES (1,'Read','R'),(2,'Write','W'),(3,'Delete','D'),(4,'Read, Delete','RD'),(5,'Read, Write','RW'),(6,'Write, Delete','WD'),(7,'Read,Write, Delete','RWD');
/*!40000 ALTER TABLE `access_method` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `access_rights`
--

DROP TABLE IF EXISTS `access_rights`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `access_rights` (
  `id_rights` int NOT NULL AUTO_INCREMENT,
  `data_start_r` date NOT NULL,
  `data_end_r` date NOT NULL,
  `kod_e_r` int NOT NULL,
  `kod_ex_r` int NOT NULL,
  `kod_is_r` int NOT NULL,
  `kod_m_r` int NOT NULL,
  PRIMARY KEY (`id_rights`),
  KEY `kod_eex_r` (`kod_ex_r`),
  KEY `kod_ee_r` (`kod_e_r`),
  KEY `kod_iss_r` (`kod_is_r`),
  KEY `kod_mm_r` (`kod_m_r`),
  CONSTRAINT `kod_ee_r` FOREIGN KEY (`kod_e_r`) REFERENCES `employee_role` (`id_e`),
  CONSTRAINT `kod_eex_r` FOREIGN KEY (`kod_ex_r`) REFERENCES `role_external` (`id_ex`),
  CONSTRAINT `kod_iss_r` FOREIGN KEY (`kod_is_r`) REFERENCES `inf_s` (`id_is`),
  CONSTRAINT `kod_mm_r` FOREIGN KEY (`kod_m_r`) REFERENCES `access_method` (`id_m`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `access_rights`
--

LOCK TABLES `access_rights` WRITE;
/*!40000 ALTER TABLE `access_rights` DISABLE KEYS */;
INSERT INTO `access_rights` VALUES (1,'2018-05-22','2020-05-20',5,2,1,7),(2,'2020-05-14','2021-05-20',4,1,2,7),(3,'2014-02-22','2020-05-20',3,1,4,7),(4,'2018-05-22','2020-05-25',2,2,5,7),(5,'2020-01-26','2021-01-20',1,1,3,7);
/*!40000 ALTER TABLE `access_rights` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_role`
--

DROP TABLE IF EXISTS `employee_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_role` (
  `id_e` int NOT NULL AUTO_INCREMENT,
  `data_start_e` date NOT NULL,
  `data_end_e` date NOT NULL,
  `kod_f_e` int NOT NULL,
  `kod_p_e` int NOT NULL,
  PRIMARY KEY (`id_e`),
  KEY `kod_ff_e` (`kod_f_e`),
  KEY `kod_pp_e` (`kod_p_e`),
  CONSTRAINT `kod_ff_e` FOREIGN KEY (`kod_f_e`) REFERENCES `face` (`id_f`),
  CONSTRAINT `kod_pp_e` FOREIGN KEY (`kod_p_e`) REFERENCES `position` (`id_p`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_role`
--

LOCK TABLES `employee_role` WRITE;
/*!40000 ALTER TABLE `employee_role` DISABLE KEYS */;
INSERT INTO `employee_role` VALUES (1,'2020-05-14','2020-05-24',1,2),(2,'2020-05-14','2021-05-24',3,4),(3,'2020-05-03','2021-05-02',4,1),(4,'2020-05-14','2024-05-24',6,3),(5,'2020-05-28','2022-05-24',7,9),(6,'2018-05-14','2020-08-24',5,11);
/*!40000 ALTER TABLE `employee_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `face`
--

DROP TABLE IF EXISTS `face`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `face` (
  `id_f` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `patronymic` varchar(100) NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id_f`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `face`
--

LOCK TABLES `face` WRITE;
/*!40000 ALTER TABLE `face` DISABLE KEYS */;
INSERT INTO `face` VALUES (1,'surname_1','name_1','patronymic_1','login_1','password_1'),(2,'surname_2','name_2','patronymic_2','login_2','password_2'),(3,'surname_3','name_3','patronymic_3','login_3','password_3'),(4,'surname_4','name_4','patronymic_4','login_4','password_4'),(5,'surname_5','name_5','patronymic_5','login_5','password_5'),(6,'surname_6','name_6','patronymic_6','login_6','password_6'),(7,'surname_7','name_7','patronymic_7','login_7','password_7');
/*!40000 ALTER TABLE `face` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inf_s`
--

DROP TABLE IF EXISTS `inf_s`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inf_s` (
  `id_is` int NOT NULL AUTO_INCREMENT,
  `name_is` varchar(100) NOT NULL,
  `short_name_is` varchar(100) NOT NULL,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`id_is`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inf_s`
--

LOCK TABLES `inf_s` WRITE;
/*!40000 ALTER TABLE `inf_s` DISABLE KEYS */;
INSERT INTO `inf_s` VALUES (1,'DIRECTUM','DIRECTUM','1'),(2,' SAP ERP','SAP ERP','2'),(3,'NERPA EAM','NERPA EAM','3'),(4,'ZuluGIS','ZuluGIS','4'),(5,'?Диспетчер?','?Диспетчер?','5');
/*!40000 ALTER TABLE `inf_s` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `position`
--

DROP TABLE IF EXISTS `position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `position` (
  `id_p` int NOT NULL AUTO_INCREMENT,
  `name_position` varchar(100) NOT NULL,
  PRIMARY KEY (`id_p`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'Начальник ИТ отдела'),(2,'Администратор безопасности'),(3,'Специалист по поддержке пользователей'),(4,'Зам. директора по общим вопросам'),(5,'Бухгалтер'),(6,'Сотрудник отдела учета и прогнозирование реализации '),(7,'Сотрудник экономического отдела '),(8,'Главный инженер'),(9,'Зам. главного инженера по эксплуатации'),(10,'Сотрудник службы эксплуатации тепловых сетей'),(11,'Сотрудник службы автоматизации и измерений'),(12,'Сотрудник оперативно-диспетчерской службы'),(13,'Сотрудник производственно-технического отдела'),(14,'Оператор АСУ ТП'),(15,'Сотрудник отдела кадров'),(16,'Зам. директора по маркетингу и сбыту');
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role_external`
--

DROP TABLE IF EXISTS `role_external`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role_external` (
  `id_ex` int NOT NULL AUTO_INCREMENT,
  `data_start_ex` date NOT NULL,
  `data_end_ex` date NOT NULL,
  `kod_f_ex` int NOT NULL,
  `kod_p_ex` int NOT NULL,
  PRIMARY KEY (`id_ex`),
  KEY `kod_ff_ex` (`kod_f_ex`),
  KEY `kod_pp_ex` (`kod_p_ex`),
  CONSTRAINT `kod_ff_ex` FOREIGN KEY (`kod_f_ex`) REFERENCES `face` (`id_f`),
  CONSTRAINT `kod_pp_ex` FOREIGN KEY (`kod_p_ex`) REFERENCES `position` (`id_p`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role_external`
--

LOCK TABLES `role_external` WRITE;
/*!40000 ALTER TABLE `role_external` DISABLE KEYS */;
INSERT INTO `role_external` VALUES (1,'2020-05-17','2022-05-19',4,3),(2,'2018-05-16','2020-05-26',3,2);
/*!40000 ALTER TABLE `role_external` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subdivision`
--

DROP TABLE IF EXISTS `subdivision`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subdivision` (
  `id_s` int NOT NULL AUTO_INCREMENT,
  `name_subdivision` varchar(100) NOT NULL,
  `kod_e_s` int NOT NULL,
  PRIMARY KEY (`id_s`),
  KEY `kod_ee_s` (`kod_e_s`),
  CONSTRAINT `kod_ee_s` FOREIGN KEY (`kod_e_s`) REFERENCES `employee_role` (`id_e`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subdivision`
--

LOCK TABLES `subdivision` WRITE;
/*!40000 ALTER TABLE `subdivision` DISABLE KEYS */;
INSERT INTO `subdivision` VALUES (1,'Отдел ИТ',1),(2,'Административный отдел',2),(3,'Отдел кадров',3),(4,'Бухгалтерия',4),(5,'Отдела учета и прогнозирования реализации',6),(6,'Экономичекий отдел',5),(7,'Служба эксплуатации тепловых сетей',3),(8,'Служба автоматизации и измерений',2),(9,'Оперативно-диспетчерская служба',5),(10,'Производственно-технический отдел',3);
/*!40000 ALTER TABLE `subdivision` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-20 18:45:14
