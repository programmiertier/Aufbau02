-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 08. Februar 2018 um 14:39
-- Server Version: 5.5.8
-- PHP-Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `blumenladen`
--
DROP DATABASE `blumenladen`;
CREATE DATABASE `blumenladen` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `blumenladen`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `blume`
--

DROP TABLE IF EXISTS `blume`;
CREATE TABLE IF NOT EXISTS `blume` (
  `b_id` int(11) NOT NULL AUTO_INCREMENT,
  `art` text,
  `preis` double DEFAULT NULL,
  `anzahl` int(11) DEFAULT NULL,
  PRIMARY KEY (`b_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Daten für Tabelle `blume`
--

INSERT INTO `blume` (`b_id`, `art`, `preis`, `anzahl`) VALUES
(1, 'Diestel', 2.99, 68),
(2, 'Huflattich', 3.49, 33),
(3, 'Butterblume', 2.59, 80),
(4, 'Rose', 4.99, 99);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `blumenstrauß`
--

DROP TABLE IF EXISTS `blumenstrauß`;
CREATE TABLE IF NOT EXISTS `blumenstrauß` (
  `bs_id` int(11) NOT NULL AUTO_INCREMENT,
  `bestelldatum` datetime DEFAULT NULL,
  PRIMARY KEY (`bs_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Daten für Tabelle `blumenstrauß`
--

INSERT INTO `blumenstrauß` (`bs_id`, `bestelldatum`) VALUES
(1, '2016-08-25 09:10:00'),
(2, '2016-08-26 09:30:25'),
(3, '2016-08-26 09:44:15'),
(4, '2016-08-26 11:36:13'),
(5, '2016-08-26 12:34:33'),
(6, '2016-08-26 12:40:28'),
(7, '2016-08-26 12:43:30'),
(8, '2016-08-26 13:14:59'),
(9, '0001-01-01 00:00:00');

-- --------------------------------------------------------

--
-- Stellvertreter-Struktur des Views `v_verkauf`
--
DROP VIEW IF EXISTS `v_verkauf`;
CREATE TABLE IF NOT EXISTS `v_verkauf` (
`b_id` int(11)
,`art` text
,`preis` double
,`anzahl` int(11)
,`bs_id` int(11)
,`bestelldatum` datetime
);
-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `verkauf`
--

DROP TABLE IF EXISTS `verkauf`;
CREATE TABLE IF NOT EXISTS `verkauf` (
  `b_id` int(11) DEFAULT NULL,
  `bs_id` int(11) DEFAULT NULL,
  `anzahl` int(11) DEFAULT NULL,
  KEY `b_id` (`b_id`),
  KEY `bs_id` (`bs_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `verkauf`
--

INSERT INTO `verkauf` (`b_id`, `bs_id`, `anzahl`) VALUES
(1, 1, 4),
(1, 2, 5),
(2, 1, 6),
(2, 2, 3),
(3, 1, 8),
(3, 2, 2),
(1, 3, 10),
(1, 4, 4),
(2, 4, 3),
(1, 5, 4),
(2, 5, 3),
(1, 6, 4),
(2, 6, 3),
(1, 7, 4),
(2, 7, 3),
(1, 8, 4),
(2, 8, 3),
(1, 9, 2),
(2, 9, 2),
(4, 9, 1);

--
-- Trigger `verkauf`
--
DROP TRIGGER IF EXISTS `trg_update_bestand`;
DELIMITER //
CREATE TRIGGER `trg_update_bestand` AFTER INSERT ON `verkauf`
 FOR EACH ROW begin
update blume set blume.anzahl = blume.anzahl - new.anzahl where blume.b_id = new.b_id;
end
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur des Views `v_verkauf`
--
DROP TABLE IF EXISTS `v_verkauf`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_verkauf` AS select `blume`.`b_id` AS `b_id`,`blume`.`art` AS `art`,`blume`.`preis` AS `preis`,`verkauf`.`anzahl` AS `anzahl`,`verkauf`.`bs_id` AS `bs_id`,`blumenstrauß`.`bestelldatum` AS `bestelldatum` from ((`blume` join `verkauf` on((`blume`.`b_id` = `verkauf`.`b_id`))) join `blumenstrauß` on((`verkauf`.`bs_id` = `blumenstrauß`.`bs_id`)));

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `verkauf`
--
ALTER TABLE `verkauf`
  ADD CONSTRAINT `verkauf_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `blume` (`b_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `verkauf_ibfk_2` FOREIGN KEY (`bs_id`) REFERENCES `blumenstrauß` (`bs_id`) ON DELETE CASCADE ON UPDATE CASCADE;
