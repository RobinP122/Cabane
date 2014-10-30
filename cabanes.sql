-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 30 Octobre 2014 à 16:16
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `cabanes`
--
CREATE DATABASE `Cabanes`;
-- --------------------------------------------------------

--
-- Structure de la table `cabanes`
--

CREATE TABLE IF NOT EXISTS `cabanes` (
  `idCabane` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) COLLATE utf8_bin NOT NULL,
  `Altitude` int(11) NOT NULL,
  `Douche` tinyint(1) NOT NULL,
  `NbLits` int(11) NOT NULL,
  `GPS` varchar(100) COLLATE utf8_bin NOT NULL,
  `Tarif` decimal(4,2) NOT NULL,
  `Commentaire` text COLLATE utf8_bin,
  PRIMARY KEY (`idCabane`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `manger`
--

CREATE TABLE IF NOT EXISTS `manger` (
  `idMenu` int(11) NOT NULL,
  `idCabane` int(11) NOT NULL,
  PRIMARY KEY (`idMenu`,`idCabane`),
  KEY `idMenu` (`idMenu`,`idCabane`),
  KEY `idCabane` (`idCabane`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Structure de la table `menus`
--

CREATE TABLE IF NOT EXISTS `menus` (
  `idMenu` int(11) NOT NULL AUTO_INCREMENT,
  `NomMenu` varchar(100) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`idMenu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `personnes`
--

CREATE TABLE IF NOT EXISTS `personnes` (
  `idPersonne` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(25) COLLATE utf8_bin NOT NULL,
  `Prenom` varchar(25) COLLATE utf8_bin NOT NULL,
  `Adresse` varchar(100) COLLATE utf8_bin NOT NULL,
  `NoMobile` varchar(20) COLLATE utf8_bin NOT NULL,
  `Email` varchar(100) COLLATE utf8_bin NOT NULL,
  `SiteWeb` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`idPersonne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

CREATE TABLE IF NOT EXISTS `posseder` (
  `idPersonne` int(11) NOT NULL,
  `idCabane` int(11) NOT NULL,
  PRIMARY KEY (`idPersonne`,`idCabane`),
  KEY `idPersonne` (`idPersonne`,`idCabane`),
  KEY `idCabane` (`idCabane`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `manger`
--
ALTER TABLE `manger`
  ADD CONSTRAINT `manger_ibfk_1` FOREIGN KEY (`idMenu`) REFERENCES `menus` (`idMenu`),
  ADD CONSTRAINT `manger_ibfk_2` FOREIGN KEY (`idCabane`) REFERENCES `cabanes` (`idCabane`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `posseder_ibfk_1` FOREIGN KEY (`idPersonne`) REFERENCES `personnes` (`idPersonne`),
  ADD CONSTRAINT `posseder_ibfk_2` FOREIGN KEY (`idCabane`) REFERENCES `cabanes` (`idCabane`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
