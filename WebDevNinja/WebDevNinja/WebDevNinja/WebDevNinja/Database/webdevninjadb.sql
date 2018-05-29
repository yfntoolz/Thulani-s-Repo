/*
SQLyog Community Edition- MySQL GUI v5.22a
Host - 5.5.5-10.1.16-MariaDB : Database - webdevninjadb
*********************************************************************
Server version : 5.5.5-10.1.16-MariaDB
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `webdevninjadb`;

USE `webdevninjadb`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `tblresult` */

DROP TABLE IF EXISTS `tblresult`;

CREATE TABLE `tblresult` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `research` varchar(2000) DEFAULT NULL,
  `graphUrl` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tblresult` */

insert  into `tblresult`(`id`,`research`,`graphUrl`) values (1,'The authors examined the effects of framing on life-saving interventions and found interesting divergences. Participants were asked about whether equipment should be bought for use in airport safety procedures. In one condition participants were told the equipment has a chance saving 150 lives. In other conditions participants were told it had a x% chance of saving 150 lives.','Images/Graphs/Graph1.PNG'),(2,'The authors sought to prime honesty by asking people to sign at the start of a form rather than the end when reporting how many miles they had driven on their car for insurance purposes.','Images/Graphs/Graph2.PNG'),(3,'A famous paper demonstrating the massive effect default choices have on organ donation compliance rates. Those countries where people are required to opt-out of organ donation report significantly higher consent than those with an opt-in policy.','Images/Graphs/Graph3.PNG'),(4,'If something is not scarce, then it is not desired or valued that much. Praises from a teacher who seldom praises are valued more than praises from a teacher who is liberal with his or her praise.',NULL),(5,'If I am uncertain I will take a cue from others.',NULL);

/*Table structure for table `tblsalesperson` */

DROP TABLE IF EXISTS `tblsalesperson`;

CREATE TABLE `tblsalesperson` (
  `email` varchar(100) NOT NULL,
  `firstName` varchar(100) DEFAULT NULL,
  `lastName` varchar(100) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblsalesperson` */

insert  into `tblsalesperson`(`email`,`firstName`,`lastName`,`password`) values ('andiswadlala@gmail.com','Andiswa','Dladla','12345'),('ditoolz.nkabini1994@gmail.com','Toolz','Nkebs','12345'),('esihledlala@gmail.com','Esihle','Dladla','12345'),('Thulani','Nkabini','thulani.nkabini@live.com','12345'),('thulani.nkabini@live.com','Thulani','Nkabini','12345');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
