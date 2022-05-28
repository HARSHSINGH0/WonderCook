
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2022 12:05:03
-- Generated from EDMX file: C:\Users\hs475\source\repos\HARSHSINGH0\WonderCook\WonderCook\Models\RecipesModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [project];
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

-- Creating table 'Recipes'
CREATE TABLE [dbo].[Recipes] (
    [recipe_id] int IDENTITY(1,1) NOT NULL,
    [recipe_name] nvarchar(50)  NOT NULL,
    [image] nvarchar(max)  NOT NULL,
    [how_to_make] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Ingredients'
CREATE TABLE [dbo].[Ingredients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ingredient] nvarchar(50)  NOT NULL,
    [quantity] nvarchar(20)  NOT NULL,
    [Recipes_recipe_id] int  NOT NULL
);
GO

-- Creating table 'Macro_Ingredients'
CREATE TABLE [dbo].[Macro_Ingredients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nutrient] nvarchar(50)  NOT NULL,
    [amount] nvarchar(20)  NOT NULL,
    [Recipes_recipe_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [recipe_id] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [PK_Recipes]
    PRIMARY KEY CLUSTERED ([recipe_id] ASC);
GO

-- Creating primary key on [Id] in table 'Ingredients'
ALTER TABLE [dbo].[Ingredients]
ADD CONSTRAINT [PK_Ingredients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Macro_Ingredients'
ALTER TABLE [dbo].[Macro_Ingredients]
ADD CONSTRAINT [PK_Macro_Ingredients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Recipes_recipe_id] in table 'Ingredients'
ALTER TABLE [dbo].[Ingredients]
ADD CONSTRAINT [FK_Recipes_Ingredients]
    FOREIGN KEY ([Recipes_recipe_id])
    REFERENCES [dbo].[Recipes]
        ([recipe_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Recipes_Ingredients'
CREATE INDEX [IX_FK_Recipes_Ingredients]
ON [dbo].[Ingredients]
    ([Recipes_recipe_id]);
GO

-- Creating foreign key on [Recipes_recipe_id] in table 'Macro_Ingredients'
ALTER TABLE [dbo].[Macro_Ingredients]
ADD CONSTRAINT [FK_Recipes_Macro_Ingredients]
    FOREIGN KEY ([Recipes_recipe_id])
    REFERENCES [dbo].[Recipes]
        ([recipe_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Recipes_Macro_Ingredients'
CREATE INDEX [IX_FK_Recipes_Macro_Ingredients]
ON [dbo].[Macro_Ingredients]
    ([Recipes_recipe_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------