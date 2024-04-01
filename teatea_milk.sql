-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 01, 2024 at 10:20 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `teatea_milk`
--

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_no` int(11) NOT NULL,
  `item_description` text NOT NULL,
  `item_price` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`item_no`, `item_description`, `item_price`) VALUES
(1, 'Regular Milktea', 100.00),
(2, 'Red Bean and Pudding Milktea', 200.00),
(3, 'Red Bean and Pudding Matcha Milktea', 300.00),
(4, 'Pearl Milktea', 150.00);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_no` int(11) NOT NULL,
  `order_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_no`, `order_date`) VALUES
(1, '2024-03-29 12:06:00'),
(2, '2024-03-29 12:12:00'),
(3, '2024-03-29 12:16:00'),
(4, '2024-03-29 12:17:00'),
(5, '2024-03-29 12:17:00'),
(6, '2024-03-29 12:20:00'),
(7, '2024-03-29 12:23:00'),
(8, '2024-03-29 12:26:00'),
(9, '2024-03-29 12:31:00'),
(10, '2024-03-29 12:31:00'),
(11, '2024-03-29 12:41:00'),
(12, '2024-03-29 01:43:00'),
(13, '2024-03-29 01:50:00'),
(14, '2024-03-29 01:58:00'),
(15, '2024-03-29 02:11:00'),
(16, '2024-03-29 02:13:00'),
(17, '2024-03-29 02:15:00'),
(18, '2024-03-29 02:18:00'),
(19, '2024-03-29 02:19:00');

-- --------------------------------------------------------

--
-- Table structure for table `order_line`
--

CREATE TABLE `order_line` (
  `trans_no` int(11) NOT NULL,
  `order_no` int(11) NOT NULL,
  `item_no` int(11) NOT NULL,
  `price` decimal(15,2) NOT NULL,
  `order_quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `order_line`
--

INSERT INTO `order_line` (`trans_no`, `order_no`, `item_no`, `price`, `order_quantity`) VALUES
(2, 1, 2, 200.00, 1),
(3, 2, 1, 100.00, 1),
(4, 2, 3, 300.00, 1),
(5, 3, 1, 100.00, 3),
(6, 3, 4, 150.00, 1),
(7, 4, 2, 200.00, 1),
(8, 5, 2, 200.00, 1),
(9, 6, 1, 100.00, 1),
(10, 6, 2, 200.00, 1),
(11, 7, 2, 200.00, 1),
(12, 8, 2, 200.00, 1),
(13, 9, 3, 300.00, 1),
(14, 10, 2, 200.00, 1),
(15, 11, 1, 100.00, 1),
(16, 12, 2, 200.00, 1),
(17, 12, 3, 300.00, 1),
(18, 13, 2, 200.00, 1),
(19, 13, 4, 150.00, 1),
(20, 14, 1, 100.00, 1),
(21, 15, 3, 300.00, 1),
(22, 16, 2, 200.00, 1),
(23, 17, 2, 200.00, 1),
(24, 18, 2, 200.00, 1),
(25, 19, 3, 300.00, 6);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `pay_no` int(11) NOT NULL,
  `order_no` int(11) NOT NULL,
  `amount_paid` decimal(15,2) NOT NULL,
  `cash_tendered` decimal(15,2) NOT NULL,
  `payment_change` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`pay_no`, `order_no`, `amount_paid`, `cash_tendered`, `payment_change`) VALUES
(3, 1, 200.00, 300.00, 100.00),
(4, 2, 400.00, 500.00, 100.00),
(5, 3, 450.00, 500.00, 50.00),
(6, 4, 200.00, 300.00, 100.00),
(7, 5, 200.00, 500.00, 300.00),
(8, 6, 300.00, 500.00, 200.00),
(9, 7, 200.00, 500.00, 300.00),
(10, 8, 200.00, 12333.00, 12133.00),
(11, 9, 300.00, 499.00, 199.00),
(12, 10, 200.00, 1222.00, 1022.00),
(13, 11, 100.00, 100.00, 0.00),
(14, 12, 500.00, 1000.00, 500.00),
(15, 13, 350.00, 500.00, 150.00),
(16, 14, 100.00, 200.00, 100.00),
(17, 15, 300.00, 500.00, 200.00),
(18, 16, 200.00, 500.00, 300.00),
(19, 17, 200.00, 600.00, 400.00),
(20, 18, 200.00, 599.00, 399.00),
(21, 19, 1800.00, 2000.00, 200.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_no`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_no`);

--
-- Indexes for table `order_line`
--
ALTER TABLE `order_line`
  ADD PRIMARY KEY (`trans_no`),
  ADD KEY `item_fk` (`item_no`),
  ADD KEY `order_fk` (`order_no`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`pay_no`),
  ADD KEY `pay_order_fk` (`order_no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `pay_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order_line`
--
ALTER TABLE `order_line`
  ADD CONSTRAINT `item_fk` FOREIGN KEY (`item_no`) REFERENCES `items` (`item_no`) ON DELETE CASCADE,
  ADD CONSTRAINT `order_fk` FOREIGN KEY (`order_no`) REFERENCES `orders` (`order_no`) ON DELETE CASCADE;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `pay_order_fk` FOREIGN KEY (`order_no`) REFERENCES `orders` (`order_no`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
