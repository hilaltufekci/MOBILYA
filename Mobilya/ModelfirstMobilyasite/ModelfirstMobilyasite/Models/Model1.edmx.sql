
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2023 21:54:04
-- Generated from EDMX file: C:\Users\LENOVO\Desktop\uygulamalarım\ModelfirstMobilyasite\ModelfirstMobilyasite\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mobilya];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KoltukSet'
CREATE TABLE [dbo].[KoltukSet] (
    [KoltukNo] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Kumas] nvarchar(max)  NOT NULL,
    [Renk] nvarchar(max)  NOT NULL,
    [Fiyat] int  NOT NULL
);
GO

-- Creating table 'YemekOdasıSet'
CREATE TABLE [dbo].[YemekOdasıSet] (
    [YemekOdaNo] int IDENTITY(1,1) NOT NULL,
    [Malzeme] nvarchar(max)  NOT NULL,
    [KisiSayisi] int  NOT NULL,
    [Fiyat] int  NOT NULL
);
GO

-- Creating table 'YatakOdasıSet'
CREATE TABLE [dbo].[YatakOdasıSet] (
    [YatakOdaNo] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Kumas] nvarchar(max)  NOT NULL,
    [Boyut] nvarchar(max)  NOT NULL,
    [Fiyat] int  NOT NULL
);
GO

-- Creating table 'YatakSet'
CREATE TABLE [dbo].[YatakSet] (
    [YatakNo] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Malzeme] nvarchar(max)  NOT NULL,
    [Boyut] nvarchar(max)  NOT NULL,
    [Fiyat] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KoltukNo] in table 'KoltukSet'
ALTER TABLE [dbo].[KoltukSet]
ADD CONSTRAINT [PK_KoltukSet]
    PRIMARY KEY CLUSTERED ([KoltukNo] ASC);
GO

-- Creating primary key on [YemekOdaNo] in table 'YemekOdasıSet'
ALTER TABLE [dbo].[YemekOdasıSet]
ADD CONSTRAINT [PK_YemekOdasıSet]
    PRIMARY KEY CLUSTERED ([YemekOdaNo] ASC);
GO

-- Creating primary key on [YatakOdaNo] in table 'YatakOdasıSet'
ALTER TABLE [dbo].[YatakOdasıSet]
ADD CONSTRAINT [PK_YatakOdasıSet]
    PRIMARY KEY CLUSTERED ([YatakOdaNo] ASC);
GO

-- Creating primary key on [YatakNo] in table 'YatakSet'
ALTER TABLE [dbo].[YatakSet]
ADD CONSTRAINT [PK_YatakSet]
    PRIMARY KEY CLUSTERED ([YatakNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------