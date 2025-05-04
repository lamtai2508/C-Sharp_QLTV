-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th4 13, 2025 lúc 09:35 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `qltv`
CREATE DATABASE qltv;
USE qltv;
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `account`
--

CREATE TABLE `account` (
    `account_id` VARCHAR(10) NOT NULL,
    `password` VARCHAR(20) NOT NULL,
    `role` INT(1) NULL DEFAULT '1'
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

--
-- Đang đổ dữ liệu cho bảng `account`
--

INSERT INTO `account` (`account_id`, `password`, `role`) VALUES
('admin1', '123456', 0),
('TV112', '1234', 1),
('TV113', '1234', 1),
('TV114', '1234', 1),
('TV115', '1234', 1),
('TV116', '1234', 1),
('TV117', '1234', 1),
('TV118', '1234', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `borroweddevices`
--

CREATE TABLE `borroweddevices` (
    `borrowed_id` VARCHAR(10) NOT NULL,
    `member_id` VARCHAR(10) NOT NULL,
    `device_id` VARCHAR(10) NOT NULL,
    `borrow_date` DATE NOT NULL,
    `return_date` DATE NOT NULL,
    `status` ENUM('Đã trả lại', 'Bị mất/Hư', 'Chưa trả lại') NOT NULL DEFAULT 'Chưa trả lại'
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `devices`
--

CREATE TABLE `devices` (
  `device_id` VARCHAR(10) NOT NULL,
  `device_name` VARCHAR(30) NOT NULL,
  `device_type` VARCHAR(20) NOT NULL,
  `status` ENUM('Bình thường','Được đặt chỗ','Đang được mượn') NOT NULL DEFAULT 'Bình thường'
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

--
-- Đang đổ dữ liệu cho bảng `devices`
--

INSERT INTO `devices` (`device_id`, `device_name`, `device_type`, `status`) VALUES
('D001', 'iPad Air', 'Tablet', 'Bình thường'),
('D002', 'Dell XPS 13', 'Laptop', 'Được đặt chỗ'),
('D003', 'Canon EOS 90D', 'Camera', 'Đang được mượn'),
('D004', 'Samsung Galaxy Tab', 'Tablet', 'Bình thường'),
('D005', 'MacBook Pro', 'Laptop', 'Bình thường');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `memberhistory`
--

CREATE TABLE `memberhistory` (
  `member_id` VARCHAR(10) NOT NULL,
  `device_id` VARCHAR(10) NOT NULL,
  `violation_id` VARCHAR(10) NOT NULL,
  `reservation_id` VARCHAR(10) NOT NULL
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `members`
--

CREATE TABLE `members` (    
    `member_id` VARCHAR(10) NOT NULL,
    `full_name` VARCHAR(30) NOT NULL,
    `gender` VARCHAR(4) NOT NULL,
    `number_phone` VARCHAR(11) NOT NULL,
    `dob` DATE NOT NULL,
    `email` VARCHAR(50) NOT NULL,
    `status` ENUM('Hoạt động', 'Đang bị phạt', 'Bị cấm') NOT NULL DEFAULT 'Hoạt động'
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

--
-- Đang đổ dữ liệu cho bảng `members`
--

INSERT INTO `members` (`member_id`, `full_name`, `gender`, `number_phone`, `dob`, `email`, `status`) VALUES
('admin1', 'admin', 'Nam', '123456789', '2000-01-11', 'admin1@gmail.com', 'Hoạt động'),
('TV112', 'Nguyen Van A', 'Nữ', '732183421', '2000-01-02', 'NguyenVanA123@gmail.com', 'Hoạt động'),
('TV113', 'TV112', 'Nam', '0123456789', '2000-01-23', 'TV112@gmail.com', 'Hoạt động'),
('TV114', 'Nguyễn Văn A', 'Nữ', '0987654321', '1990-05-01', 'nguyenvana@example.com', 'Hoạt động'),
('TV115', 'Trần Thị B', 'Nữ', '0912345678', '1988-03-14', 'tranthib@example.com', 'Đang bị phạt'),
('TV116', 'Lê Minh C', 'Nữ', '0934567890', '1992-07-23', 'leminhc@example.com', 'Hoạt động'),
('TV117', 'Phạm Thị D', 'Nữ', '0978123456', '1995-11-30', 'phamthid@example.com', 'Bị cấm'),
('TV118', 'Hoàng Quốc E', 'Nữ', '0901234567', '1997-02-20', 'hoangquoce@example.com', 'Hoạt động');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `reservations`
--

CREATE TABLE `reservations` (
    `reservation_id` VARCHAR(10) NOT NULL,
    `member_id` VARCHAR(10) NOT NULL,
    `device_id` VARCHAR(10) NOT NULL,
    `reservation_date` DATE NOT NULL,
    `borrowed_date` DATE NOT NULL,
    `returned_date` DATE NOT NULL,
    `status` ENUM('Chờ duyệt', 'Chấp nhận', 'Từ chối') NULL DEFAULT 'Chờ duyệt'
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

--
-- Đang đổ dữ liệu cho bảng `reservations`
--

INSERT INTO `reservations` 
(`reservation_id`, `member_id`, `device_id`, `reservation_date`, `borrowed_date`, `returned_date`, `status`)
VALUES
('R001', 'TV112', 'D001', '2025-04-01', '2025-04-02', '2025-04-10', 'Chấp nhận'),
('R002', 'TV113', 'D002', '2025-04-03', '2025-04-04', '2025-04-12', 'Chờ duyệt'),
('R003', 'TV114', 'D003', '2025-04-05', '2025-04-06', '2025-04-15', 'Từ chối'),
('R004', 'TV115', 'D004', '2025-04-07', '2025-04-08', '2025-04-17', 'Chấp nhận'),
('R005', 'TV116', 'D005', '2025-04-09', '2025-04-10', '2025-04-18', 'Chờ duyệt');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `violations`
--

CREATE TABLE `violations` (
  `violation_id` VARCHAR(10) NOT NULL,
  `member_id` VARCHAR(10) NOT NULL,
  `violation_type` VARCHAR(50) NOT NULL,
  `penalty` VARCHAR(50) NOT NULL,
  `violation_date` DATE NOT NULL,
  `block_date` DATE DEFAULT NULL,
  `unblock_date` DATE DEFAULT NULL,
  `status` ENUM('Đang hoạt động','Khóa tạm thời','Khóa vĩnh viễn') NOT NULL DEFAULT 'Đang hoạt động',
  `warning_count` INT NOT NULL DEFAULT 0
) ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE=UTF8MB4_GENERAL_CI;

--
-- Đang đổ dữ liệu cho bảng `violations`
--

INSERT INTO `violations` 
(`violation_id`, `member_id`, `violation_type`, `penalty`, `violation_date`, `block_date`, `unblock_date`, `status`, `warning_count`)
VALUES
('V001', 'TV112', 'Trả thiết bị trễ', 'Cảnh cáo', '2025-05-01', NULL, NULL, 'Đang hoạt động', 1),
('V002', 'TV113', 'Làm hỏng thiết bị', 'Phạt: 50$ (Yêu cầu đền bù)', '2025-05-02', '2025-05-02', '2025-05-05', 'Khóa tạm thời', 1),
('V003', 'TV114', 'Làm mất thiết bị', 'Yêu cầu đền bù', '2025-05-03', '2025-05-03', '2025-05-06', 'Khóa tạm thời', 1),
('V004', 'TV115', 'Sử dụng sai mục đích', 'Cảnh cáo', '2025-05-04', NULL, NULL, 'Đang hoạt động', 0),
('V005', 'TV116', 'Trả trễ nhiều lần', 'Phạt: 20$', '2025-05-05', '2025-05-05', '2025-05-08', 'Khóa tạm thời', 2),
('V006', 'TV117', 'Làm hỏng thiết bị', 'Phạt: 100$ (Yêu cầu đền bù)', '2025-05-06', '2025-05-06', '2025-05-09', 'Khóa tạm thời', 1),
('V007', 'TV118', 'Trả thiết bị trễ', 'Cảnh cáo', '2025-05-07', NULL, NULL, 'Đang hoạt động', 1),
('V008', 'TV119', 'Trả thiết bị trễ', 'Cảnh cáo', '2025-05-08', '2025-05-08', NULL, 'Khóa vĩnh viễn', 3);
-- --------------------------------------------------------

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`account_id`);

--
-- Chỉ mục cho bảng `borroweddevices`
--
ALTER TABLE `borroweddevices`
  ADD PRIMARY KEY (`borrowed_id`),
  ADD KEY `device_id` (`device_id`),
  ADD KEY `member_id` (`member_id`);

--
-- Chỉ mục cho bảng `devices`
--
ALTER TABLE `devices`
  ADD PRIMARY KEY (`device_id`);

--
-- Chỉ mục cho bảng `memberhistory`
--
ALTER TABLE `memberhistory`
  ADD KEY `violation_id` (`violation_id`),
  ADD KEY `device_id` (`device_id`),
  ADD KEY `member_id` (`member_id`),
  ADD KEY `reservation_id` (`reservation_id`);

--
-- Chỉ mục cho bảng `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`member_id`);

--
-- Chỉ mục cho bảng `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`reservation_id`),
  ADD KEY `member_id` (`member_id`),
  ADD KEY `device_id` (`device_id`);

--
-- Chỉ mục cho bảng `violations`
--
ALTER TABLE `violations`
  ADD PRIMARY KEY (`violation_id`),
  ADD KEY `member_id` (`member_id`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `members` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `borroweddevices`
--
ALTER TABLE `borroweddevices`
  ADD CONSTRAINT `borroweddevices_ibfk_1` FOREIGN KEY (`device_id`) REFERENCES `devices` (`device_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `borroweddevices_ibfk_2` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `memberhistory`
--
ALTER TABLE `memberhistory`
  ADD CONSTRAINT `memberhistory_ibfk_1` FOREIGN KEY (`violation_id`) REFERENCES `violations` (`violation_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `memberhistory_ibfk_2` FOREIGN KEY (`device_id`) REFERENCES `devices` (`device_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `memberhistory_ibfk_3` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `memberhistory_ibfk_4` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`reservation_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`device_id`) REFERENCES `devices` (`device_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `violations`
--
ALTER TABLE `violations`
  ADD CONSTRAINT `violations_ibfk_1` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`) ON DELETE CASCADE ON UPDATE CASCADE;

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;