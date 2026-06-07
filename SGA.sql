CREATE DATABASE SGA;

USE SGA;

CREATE TABLE Usuario
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdentificadorInstitucional VARCHAR(50) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    TipoUsuario VARCHAR(50) NOT NULL,
    Estado VARCHAR(20) NOT NULL
);

CREATE TABLE Autobus
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Placa VARCHAR(20) NOT NULL,
    CapacidadMaxima INT NOT NULL,
    EstadoOperativo VARCHAR(50) NOT NULL
);

CREATE TABLE Conductor
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Identificacion VARCHAR(50) NOT NULL,
    EstadoLaboral VARCHAR(20) NOT NULL
);

CREATE TABLE Ruta
(
    Id INT IDENTITY(1,1) PRIMARY KEY
);

CREATE TABLE Parada
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrdenParada INT NOT NULL,
    RutaId INT NOT NULL,

    FOREIGN KEY (RutaId)
    REFERENCES Ruta(Id)
);

CREATE TABLE Horario
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DiasOperacion VARCHAR(100),
    HoraSalida TIME,
    RutaId INT NOT NULL,

    FOREIGN KEY (RutaId)
    REFERENCES Ruta(Id)
);

CREATE TABLE Pago
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    FechaPago DATETIME NOT NULL,
    Modalidad VARCHAR(50),

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id)
);

CREATE TABLE TicketMensual
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    PagoId INT NOT NULL,
    FechaInicio DATE,
    FechaFin DATE,

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id),

    FOREIGN KEY (PagoId)
    REFERENCES Pago(Id)
);

CREATE TABLE TarjetaRecargable
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    Saldo DECIMAL(10,2),

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id)
);

CREATE TABLE Viaje
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RutaId INT NOT NULL,
    HorarioId INT NOT NULL,
    AutobusId INT NOT NULL,
    ConductorId INT NOT NULL,
    Estado VARCHAR(50),
    HoraInicioReal DATETIME NULL,
    HoraFinReal DATETIME NULL,

    FOREIGN KEY (RutaId)
    REFERENCES Ruta(Id),

    FOREIGN KEY (HorarioId)
    REFERENCES Horario(Id),

    FOREIGN KEY (AutobusId)
    REFERENCES Autobus(Id),

    FOREIGN KEY (ConductorId)
    REFERENCES Conductor(Id)
);

CREATE TABLE RegistroAcceso
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    ViajeId INT NOT NULL,
    TicketMensualId INT NULL,
    TarjetaRecargableId INT NULL,
    Permitido BIT,
    Motivo VARCHAR(250),
    FechaHora DATETIME,

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id),

    FOREIGN KEY (ViajeId)
    REFERENCES Viaje(Id),

    FOREIGN KEY (TicketMensualId)
    REFERENCES TicketMensual(Id),

    FOREIGN KEY (TarjetaRecargableId)
    REFERENCES TarjetaRecargable(Id)
);

CREATE TABLE Incidencia
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ViajeId INT NOT NULL,
    ConductorId INT NOT NULL,
    Tipo VARCHAR(100),
    Descripcion VARCHAR(500),
    FechaHora DATETIME,

    FOREIGN KEY (ViajeId)
    REFERENCES Viaje(Id),

    FOREIGN KEY (ConductorId)
    REFERENCES Conductor(Id)
);

CREATE TABLE Notificacion
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    ViajeId INT NULL,
    TipoEvento VARCHAR(100),
    FechaHora DATETIME,

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id),

    FOREIGN KEY (ViajeId)
    REFERENCES Viaje(Id)
);

CREATE TABLE Auditoria
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    Actor VARCHAR(100),
    TipoAccion VARCHAR(100),
    FechaHora DATETIME,

    FOREIGN KEY (UsuarioId)
    REFERENCES Usuario(Id)
);