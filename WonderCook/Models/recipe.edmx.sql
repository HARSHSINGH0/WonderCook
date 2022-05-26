
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2022 23:54:50
-- Generated from EDMX file: C:\Users\hs475\OneDrive\Desktop\college stuff\sem2\prj\WonderCook\WonderCook\Models\recipe.edmx
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

IF OBJECT_ID(N'[dbo].[recipes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[recipes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'recipes1'
CREATE TABLE [dbo].[recipes1] (
    [recipe_id] decimal(18,0)  NOT NULL,
    [recipe_name] nvarchar(50)  NULL,
    [image] varbinary(max)  NULL,
    [how_to_make] varchar(5000)  NULL
);
GO

-- Creating table 'ingredients'
CREATE TABLE [dbo].[ingredients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [recipeId] nvarchar(max)  NOT NULL,
    [ingredient] nvarchar(max)  NOT NULL,
    [quantity] nvarchar(max)  NOT NULL,
    [recipe_recipe_id] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'macro_nutrients'
CREATE TABLE [dbo].[macro_nutrients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [recipeId] nvarchar(max)  NOT NULL,
    [nutrient] nvarchar(max)  NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [recipe_recipe_id] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [recipe_id] in table 'recipes1'
ALTER TABLE [dbo].[recipes1]
ADD CONSTRAINT [PK_recipes1]
    PRIMARY KEY CLUSTERED ([recipe_id] ASC);
GO

-- Creating primary key on [Id] in table 'ingredients'
ALTER TABLE [dbo].[ingredients]
ADD CONSTRAINT [PK_ingredients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'macro_nutrients'
ALTER TABLE [dbo].[macro_nutrients]
ADD CONSTRAINT [PK_macro_nutrients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [recipe_recipe_id] in table 'ingredients'
ALTER TABLE [dbo].[ingredients]
ADD CONSTRAINT [FK_recipeingredients]
    FOREIGN KEY ([recipe_recipe_id])
    REFERENCES [dbo].[recipes1]
        ([recipe_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_recipeingredients'
CREATE INDEX [IX_FK_recipeingredients]
ON [dbo].[ingredients]
    ([recipe_recipe_id]);
GO

-- Creating foreign key on [recipe_recipe_id] in table 'macro_nutrients'
ALTER TABLE [dbo].[macro_nutrients]
ADD CONSTRAINT [FK_recipemacro_nutrients]
    FOREIGN KEY ([recipe_recipe_id])
    REFERENCES [dbo].[recipes1]
        ([recipe_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_recipemacro_nutrients'
CREATE INDEX [IX_FK_recipemacro_nutrients]
ON [dbo].[macro_nutrients]
    ([recipe_recipe_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------