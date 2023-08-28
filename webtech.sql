-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 02 Novembre 2021 à 11:23
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `webtech`
--

-- --------------------------------------------------------

--
-- Structure de la table `apprenant`
--

CREATE TABLE IF NOT EXISTS `apprenant` (
  `codeApp` varchar(20) NOT NULL,
  `nom` varchar(25) NOT NULL,
  `postnom` varchar(25) NOT NULL,
  `prenom` varchar(25) DEFAULT NULL,
  `genre` varchar(1) NOT NULL,
  `numeroTel` varchar(18) DEFAULT NULL,
  `quartierEtCell` varchar(50) DEFAULT NULL,
  `dateInscription` datetime DEFAULT NULL,
  `montant` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`codeApp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `apprenant`
--

INSERT INTO `apprenant` (`codeApp`, `nom`, `postnom`, `prenom`, `genre`, `numeroTel`, `quartierEtCell`, `dateInscription`, `montant`) VALUES
('App001', 'System.Windows.Forms.Text', 'Kiviti', 'Adel', 'F', '0955813236', 'Q/Matanda', '2021-10-27 09:34:17', '0'),
('App0010', 'System.Windows.Forms.Text', 'Aridja', 'Safi', 'M', '033336556', 'Kambali', '2021-10-30 10:25:23', '0'),
('App002', 'Masika', 'Masasi', 'Nelly', 'F', '256996355', 'Q/Eveche', '2021-10-27 10:15:14', '0'),
('App003', 'Kavugho', 'Kimbesa', 'Merveille', 'F', '0366365853', 'Q/Vutsundo', '2021-10-27 11:38:07', '0'),
('App004', 'Kasoki', 'Asifiwe', 'Louange', 'F', '026693315', 'Q/Matanda', '2021-10-27 12:22:19', '0'),
('App005', 'Moka', 'Kalume', 'Oscar', 'M', '052263633', 'Q/Congo', '2021-10-27 11:14:09', '0'),
('App006', 'Kisonia', 'Franck', 'Mumbere', 'M', '255852363', 'Q/ville', '2021-10-27 06:16:16', NULL),
('App008', 'Rachete', 'Bayongi', 'Kambale', 'M', '58823363', 'Q.VungiA', '2021-10-27 21:20:27', '0');

-- --------------------------------------------------------

--
-- Structure de la table `fraismodule`
--

CREATE TABLE IF NOT EXISTS `fraismodule` (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `codeApp` varchar(20) DEFAULT NULL,
  `codeMod` varchar(15) DEFAULT NULL,
  `Montant` decimal(10,0) NOT NULL,
  PRIMARY KEY (`numero`),
  KEY `codeApp` (`codeApp`),
  KEY `codeMod` (`codeMod`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `fraismodule`
--

INSERT INTO `fraismodule` (`numero`, `codeApp`, `codeMod`, `Montant`) VALUES
(6, 'App004', 'WebTech2/2021', '10'),
(7, 'App008', 'Q0025', '58'),
(8, 'App004', 'WebTech1/2021', '28');

-- --------------------------------------------------------

--
-- Structure de la table `module`
--

CREATE TABLE IF NOT EXISTS `module` (
  `codeMod` varchar(15) NOT NULL,
  `intitule` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codeMod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `module`
--

INSERT INTO `module` (`codeMod`, `intitule`) VALUES
('Q0025', '02525jkll'),
('WebTech1/2021', 'C# WindowsForm'),
('WebTech2/2021', 'HML & CSS'),
('WebTech5/2021', 'HML  CSS');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `fraismodule`
--
ALTER TABLE `fraismodule`
  ADD CONSTRAINT `fraismodule_ibfk_1` FOREIGN KEY (`codeApp`) REFERENCES `apprenant` (`codeApp`),
  ADD CONSTRAINT `fraismodule_ibfk_2` FOREIGN KEY (`codeMod`) REFERENCES `module` (`codeMod`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
