
-- Create Database called mydb

CREATE DATABASE `mydb` /*!40100 DEFAULT CHARACTER SET utf8 */;

/*
 *Create a single table called games
 *Columns must stay in this order:
 *Title, Rating, Status, Genres, Review, Location
 */

CREATE TABLE `games` (
  `Title` varchar(100) DEFAULT NULL,
  `Rating` varchar(3) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `Genres` varchar(250) DEFAULT NULL,
  `Review` text,
  `Location` varchar(100) DEFAULT NULL,
  UNIQUE KEY `Title` (`Title`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



