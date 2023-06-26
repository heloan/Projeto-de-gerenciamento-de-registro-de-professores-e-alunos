CREATE TABLE `disciplina` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(64) NOT NULL,
  `IdProfessor` int NOT NULL,
  `IdTurma` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aula` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdDisciplina` int NOT NULL,
  `IdProfessor` int NOT NULL,
  `Data` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aluno` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdPessoa` int NOT NULL,
  `IdTurma` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `disciplina` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(64) NOT NULL,
  `IdProfessor` int NOT NULL,
  `IdTurma` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `login` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `User` varchar(64) NOT NULL,
  `Password` varchar(64) NOT NULL,
  `IdPessoa` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `pessoa` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(64) NOT NULL,
  `Email` varchar(64) NOT NULL,
  `RA` varchar(32) NOT NULL,
  `Type` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `presenca` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdAluno` int NOT NULL,
  `IdAula` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `turma` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Curso` varchar(64) NOT NULL,
  `Periodo` varchar(64) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
