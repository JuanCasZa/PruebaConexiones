/*CREATE TABLE [Duenhos] (
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Edad] NVARCHAR(50) NOT NULL,
	[Identificacion] NVARCHAR(50) NOT NULL
);

CREATE TABLE [Veterinarios] (
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[AnhosExperiencia] NVARCHAR(50) NOT NULL,
	[Turno] NVARCHAR(8) NOT NULL
);

CREATE TABLE [Mascotas] (
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Edad] NVARCHAR(50) NOT NULL,
	[Raza] NVARCHAR(8) NOT NULL,
	[Peso] DECIMAL,
	[Duenho] int references [Duenhos]([Id]),
	[Veterinario] int references [Veterinarios]([Id])
);


-- Insertar Dueños
INSERT INTO Duenhos (Nombre, Edad, Identificacion)
VALUES
('Carlos Pérez', '35', 'CC123456'),
('María Gómez', '29', 'CC654321'),
('Juan Rodríguez', '42', 'CC987654'),
('Ana Martínez', '31', 'CC112233'),
('Luis Torres', '27', 'CC445566');

-- Insertar Veterinarios
INSERT INTO Veterinarios (Nombre, AnhosExperiencia, Turno)
VALUES
('Dr. Ramírez', '10', 'Mañana'),
('Dra. López', '7', 'Tarde'),
('Dr. Fernández', '5', 'Noche'),
('Dra. Morales', '12', 'Mañana'),
('Dr. Castro', '8', 'Tarde');

-- Insertar Mascotas (relacionadas con Dueños y Veterinarios existentes)
INSERT INTO Mascotas (Nombre, Edad, Raza, Duenho, Veterinario)
VALUES
('Firulais', '3', 'Beagle', 1, 1),
('Michi', '2', 'Persa', 2, 2),
('Rocky', '5', 'Boxer', 3, 3),
('Luna', '1', 'Siames', 4, 4),
('Max', '4', 'Pug', 5, 5);

use Veterinarias;
*/

USE Veterinarias;
GO

CREATE TABLE [Duenhos] (
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Edad] INT NOT NULL,
    [Identificacion] NVARCHAR(50) NOT NULL
);

CREATE TABLE [Veterinarios] (
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [AnhosExperiencia] INT NOT NULL,
    [Turno] NVARCHAR(20) NOT NULL
);

CREATE TABLE [Mascotas] (
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Edad] INT NOT NULL,
    [Raza] NVARCHAR(50) NOT NULL,
    [Peso] DECIMAL(10,2) NULL,
    [DuenhoId] INT NOT NULL REFERENCES [Duenhos]([Id]),
    [VeterinarioId] INT NOT NULL REFERENCES [Veterinarios]([Id])
);

-- Insertar Dueños
INSERT INTO Duenhos (Nombre, Edad, Identificacion)
VALUES
('Carlos Pérez', 35, 'CC123456'),
('María Gómez', 29, 'CC654321'),
('Juan Rodríguez', 42, 'CC987654'),
('Ana Martínez', 31, 'CC112233'),
('Luis Torres', 27, 'CC445566');

-- Insertar Veterinarios
INSERT INTO Veterinarios (Nombre, AnhosExperiencia, Turno)
VALUES
('Dr. Ramírez', 10, 'Mañana'),
('Dra. López', 7, 'Tarde'),
('Dr. Fernández', 5, 'Noche'),
('Dra. Morales', 12, 'Mañana'),
('Dr. Castro', 8, 'Tarde');

-- Insertar Mascotas (relacionadas con Dueños y Veterinarios existentes)
INSERT INTO Mascotas (Nombre, Edad, Raza, Peso, DuenhoId, VeterinarioId)
VALUES
('Firulais', 3, 'Beagle', 12.5, 1, 1),
('Michi', 2, 'Persa', 4.2, 2, 2),
('Rocky', 5, 'Boxer', 20.8, 3, 3),
('Luna', 1, 'Siames', 3.1, 4, 4),
('Max', 4, 'Pug', 8.7, 5, 5);

