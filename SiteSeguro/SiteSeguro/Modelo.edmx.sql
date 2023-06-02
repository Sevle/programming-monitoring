
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2023 10:25:59
-- Generated from EDMX file: C:\Users\1050440\source\repos\SiteSeguro\SiteSeguro\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SecureDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LogAcesso_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LogAcesso] DROP CONSTRAINT [FK_LogAcesso_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuario_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Usuario_Perfil];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[LogAcesso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogAcesso];
GO
IF OBJECT_ID(N'[dbo].[Perfil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfil];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Perfils'
CREATE TABLE [dbo].[Perfils] (
    [IdPerfil] int IDENTITY(1,1) NOT NULL,
    [Descricao] varchar(50)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(50)  NOT NULL,
    [DataNasc] datetime  NULL,
    [Login] varchar(50)  NOT NULL,
    [Senha] varchar(256)  NOT NULL,
    [PerfilId] int  NOT NULL
);
GO

-- Creating table 'LogAcessoes'
CREATE TABLE [dbo].[LogAcessoes] (
    [IdLogAcesso] int  NOT NULL,
    [UsuarioId] int  NOT NULL,
    [UltimoAcesso] datetime  NOT NULL,
    [TempoAcesso] time  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPerfil] in table 'Perfils'
ALTER TABLE [dbo].[Perfils]
ADD CONSTRAINT [PK_Perfils]
    PRIMARY KEY CLUSTERED ([IdPerfil] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdLogAcesso] in table 'LogAcessoes'
ALTER TABLE [dbo].[LogAcessoes]
ADD CONSTRAINT [PK_LogAcessoes]
    PRIMARY KEY CLUSTERED ([IdLogAcesso] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PerfilId] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_Usuario_Perfil]
    FOREIGN KEY ([PerfilId])
    REFERENCES [dbo].[Perfils]
        ([IdPerfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuario_Perfil'
CREATE INDEX [IX_FK_Usuario_Perfil]
ON [dbo].[Usuarios]
    ([PerfilId]);
GO

-- Creating foreign key on [UsuarioId] in table 'LogAcessoes'
ALTER TABLE [dbo].[LogAcessoes]
ADD CONSTRAINT [FK_LogAcesso_Usuario]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LogAcesso_Usuario'
CREATE INDEX [IX_FK_LogAcesso_Usuario]
ON [dbo].[LogAcessoes]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------