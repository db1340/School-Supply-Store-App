-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2023 at 06:13 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `schoolsupplystore`
--

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `ID` int(11) NOT NULL,
  `itemID` varchar(20) DEFAULT NULL,
  `itemname` varchar(50) DEFAULT NULL,
  `itemprice` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`ID`, `itemID`, `itemname`, `itemprice`) VALUES
(1, '79467982729', 'PANDA Ballpen', '10.00'),
(2, '27567982590', 'FABER CASTELL Ballpen', '12.00'),
(3, '98265370682', 'Mongol Pencil No.2', '10.00'),
(4, '09321678506', 'Correction Tape', '20.00'),
(5, '09136456970', 'Pentel Pen/Marker', '25.00'),
(6, '90460916345', 'Yellow Pad', '30.00'),
(7, '03987560627', 'White Board Marker', '40.00'),
(8, '39045606927', 'Bond Paper (A4 Size)', '25.00'),
(9, '30856180765', 'FABER CASTELL Eraser', '15.00'),
(10, '01765820167', 'Notebook (80 Leaves)', '60.00');

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `ID` int(11) NOT NULL,
  `studID` varchar(20) DEFAULT NULL,
  `itemID` varchar(50) DEFAULT NULL,
  `itemQuantity` int(10) NOT NULL,
  `purchaseDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`ID`, `studID`, `itemID`, `itemQuantity`, `purchaseDate`) VALUES
(1, '1', '1', 2, '2023-05-20 20:28:54'),
(7, '3', '6', 1, '2023-05-21 06:39:59'),
(8, '5', '6', 5, '2023-05-21 07:12:44'),
(9, '4', '10', 3, '2023-05-21 07:30:17');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `ID` int(11) NOT NULL,
  `studID` varchar(20) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `course` varchar(50) DEFAULT NULL,
  `college` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`ID`, `studID`, `lastname`, `firstname`, `middlename`, `course`, `college`) VALUES
(1, '19-1488-91', 'Bonilla', 'Daryl Brian', 'Paredes', 'BSCS', 'CCS'),
(2, '21-2345-43', 'Aguillana', 'Jhim Martin', 'Florante', 'BSIT', 'CCS'),
(3, '17-8763-73', 'Alagos', 'Neil Andrie', 'Caspe', 'BSIT', 'CCS'),
(4, '19-5683-42', 'Rosales', 'Wesley', 'Torres', 'DMIA', 'CCS'),
(5, '20-3677-98', 'Soto', 'Andrew', 'Suarez', 'BLIS', 'CCS'),
(6, '21-1738-87', 'Simmons', 'Debra', 'Walter', 'DMIA', 'CCS'),
(7, '18-2358-27', 'Perez', 'Allen Christopher', 'Hernandez', 'BSCS', 'CCS');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
