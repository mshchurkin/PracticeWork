
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/27/2016 10:27:34
-- Generated from EDMX file: \\mac\home\documents\visual studio 2013\Projects\PracticeWork\PracticeWork\PracticeWorkDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PracticeWorkDataBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ModelComputer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComputerSet] DROP CONSTRAINT [FK_ModelComputer];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelConnection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionSet] DROP CONSTRAINT [FK_ModelConnection];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelDevice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeviceSet] DROP CONSTRAINT [FK_ModelDevice];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelRouter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RouterSet] DROP CONSTRAINT [FK_ModelRouter];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelQueue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QueueSet] DROP CONSTRAINT [FK_ModelQueue];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelRoutine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoutineSet] DROP CONSTRAINT [FK_ModelRoutine];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelServer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServerSet] DROP CONSTRAINT [FK_ModelServer];
GO
IF OBJECT_ID(N'[dbo].[FK_DeviceQueue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QueueSet] DROP CONSTRAINT [FK_DeviceQueue];
GO
IF OBJECT_ID(N'[dbo].[FK_QueueRoutine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoutineSet] DROP CONSTRAINT [FK_QueueRoutine];
GO
IF OBJECT_ID(N'[dbo].[FK_RouterConnection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionSet] DROP CONSTRAINT [FK_RouterConnection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionServer_Connection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionServer] DROP CONSTRAINT [FK_ConnectionServer_Connection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionServer_Server]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionServer] DROP CONSTRAINT [FK_ConnectionServer_Server];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionDevice_Connection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionDevice] DROP CONSTRAINT [FK_ConnectionDevice_Connection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionDevice_Device]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionDevice] DROP CONSTRAINT [FK_ConnectionDevice_Device];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionQueue_Connection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionQueue] DROP CONSTRAINT [FK_ConnectionQueue_Connection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionQueue_Queue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionQueue] DROP CONSTRAINT [FK_ConnectionQueue_Queue];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionComputer_Connection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionComputer] DROP CONSTRAINT [FK_ConnectionComputer_Connection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionComputer_Computer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionComputer] DROP CONSTRAINT [FK_ConnectionComputer_Computer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ModelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelSet];
GO
IF OBJECT_ID(N'[dbo].[ComputerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComputerSet];
GO
IF OBJECT_ID(N'[dbo].[DeviceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeviceSet];
GO
IF OBJECT_ID(N'[dbo].[ServerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServerSet];
GO
IF OBJECT_ID(N'[dbo].[QueueSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QueueSet];
GO
IF OBJECT_ID(N'[dbo].[RoutineSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoutineSet];
GO
IF OBJECT_ID(N'[dbo].[RouterSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RouterSet];
GO
IF OBJECT_ID(N'[dbo].[ConnectionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionSet];
GO
IF OBJECT_ID(N'[dbo].[ConnectionServer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionServer];
GO
IF OBJECT_ID(N'[dbo].[ConnectionDevice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionDevice];
GO
IF OBJECT_ID(N'[dbo].[ConnectionQueue]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionQueue];
GO
IF OBJECT_ID(N'[dbo].[ConnectionComputer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionComputer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ModelSet'
CREATE TABLE [dbo].[ModelSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ComputerSet'
CREATE TABLE [dbo].[ComputerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Processor] nvarchar(max)  NOT NULL,
    [RAM] int  NULL,
    [Memory] int  NOT NULL,
    [ConnectionSpeed] int  NOT NULL,
    [ModelId] int  NOT NULL
);
GO

-- Creating table 'DeviceSet'
CREATE TABLE [dbo].[DeviceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [RAM] int  NOT NULL,
    [Memory] int  NOT NULL,
    [VideoMemory] int  NOT NULL,
    [HaveQueue] bit  NOT NULL,
    [ConnectionSpeed] int  NOT NULL,
    [ModelId] int  NOT NULL
);
GO

-- Creating table 'ServerSet'
CREATE TABLE [dbo].[ServerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RAM] int  NOT NULL,
    [Memory] int  NOT NULL,
    [ConnectionSpeed] int  NOT NULL,
    [ModelId] int  NOT NULL
);
GO

-- Creating table 'QueueSet'
CREATE TABLE [dbo].[QueueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [NumberInQueue] int  NOT NULL,
    [ConnectionSpeed] int  NOT NULL,
    [ModelId] int  NOT NULL,
    [Device_Id] int  NOT NULL
);
GO

-- Creating table 'RoutineSet'
CREATE TABLE [dbo].[RoutineSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Function] nvarchar(max)  NOT NULL,
    [ModelId] int  NOT NULL,
    [QueueId] int  NOT NULL
);
GO

-- Creating table 'RouterSet'
CREATE TABLE [dbo].[RouterSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ConnectionSpeed] int  NOT NULL,
    [ModelId] int  NOT NULL
);
GO

-- Creating table 'ConnectionSet'
CREATE TABLE [dbo].[ConnectionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [D1] nvarchar(max)  NOT NULL,
    [D2] nvarchar(max)  NOT NULL,
    [ModelId] int  NOT NULL,
    [RouterId] int  NOT NULL
);
GO

-- Creating table 'ConnectionServer'
CREATE TABLE [dbo].[ConnectionServer] (
    [Connection_Id] int  NOT NULL,
    [Server_Id] int  NOT NULL
);
GO

-- Creating table 'ConnectionDevice'
CREATE TABLE [dbo].[ConnectionDevice] (
    [Connection_Id] int  NOT NULL,
    [Device_Id] int  NOT NULL
);
GO

-- Creating table 'ConnectionQueue'
CREATE TABLE [dbo].[ConnectionQueue] (
    [Connection_Id] int  NOT NULL,
    [Queue_Id] int  NOT NULL
);
GO

-- Creating table 'ConnectionComputer'
CREATE TABLE [dbo].[ConnectionComputer] (
    [Connection_Id] int  NOT NULL,
    [Computer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ModelSet'
ALTER TABLE [dbo].[ModelSet]
ADD CONSTRAINT [PK_ModelSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComputerSet'
ALTER TABLE [dbo].[ComputerSet]
ADD CONSTRAINT [PK_ComputerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [PK_DeviceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServerSet'
ALTER TABLE [dbo].[ServerSet]
ADD CONSTRAINT [PK_ServerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QueueSet'
ALTER TABLE [dbo].[QueueSet]
ADD CONSTRAINT [PK_QueueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoutineSet'
ALTER TABLE [dbo].[RoutineSet]
ADD CONSTRAINT [PK_RoutineSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RouterSet'
ALTER TABLE [dbo].[RouterSet]
ADD CONSTRAINT [PK_RouterSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [PK_ConnectionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Connection_Id], [Server_Id] in table 'ConnectionServer'
ALTER TABLE [dbo].[ConnectionServer]
ADD CONSTRAINT [PK_ConnectionServer]
    PRIMARY KEY CLUSTERED ([Connection_Id], [Server_Id] ASC);
GO

-- Creating primary key on [Connection_Id], [Device_Id] in table 'ConnectionDevice'
ALTER TABLE [dbo].[ConnectionDevice]
ADD CONSTRAINT [PK_ConnectionDevice]
    PRIMARY KEY CLUSTERED ([Connection_Id], [Device_Id] ASC);
GO

-- Creating primary key on [Connection_Id], [Queue_Id] in table 'ConnectionQueue'
ALTER TABLE [dbo].[ConnectionQueue]
ADD CONSTRAINT [PK_ConnectionQueue]
    PRIMARY KEY CLUSTERED ([Connection_Id], [Queue_Id] ASC);
GO

-- Creating primary key on [Connection_Id], [Computer_Id] in table 'ConnectionComputer'
ALTER TABLE [dbo].[ConnectionComputer]
ADD CONSTRAINT [PK_ConnectionComputer]
    PRIMARY KEY CLUSTERED ([Connection_Id], [Computer_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ModelId] in table 'ComputerSet'
ALTER TABLE [dbo].[ComputerSet]
ADD CONSTRAINT [FK_ModelComputer]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelComputer'
CREATE INDEX [IX_FK_ModelComputer]
ON [dbo].[ComputerSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [FK_ModelConnection]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelConnection'
CREATE INDEX [IX_FK_ModelConnection]
ON [dbo].[ConnectionSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'DeviceSet'
ALTER TABLE [dbo].[DeviceSet]
ADD CONSTRAINT [FK_ModelDevice]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelDevice'
CREATE INDEX [IX_FK_ModelDevice]
ON [dbo].[DeviceSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'RouterSet'
ALTER TABLE [dbo].[RouterSet]
ADD CONSTRAINT [FK_ModelRouter]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelRouter'
CREATE INDEX [IX_FK_ModelRouter]
ON [dbo].[RouterSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'QueueSet'
ALTER TABLE [dbo].[QueueSet]
ADD CONSTRAINT [FK_ModelQueue]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelQueue'
CREATE INDEX [IX_FK_ModelQueue]
ON [dbo].[QueueSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'RoutineSet'
ALTER TABLE [dbo].[RoutineSet]
ADD CONSTRAINT [FK_ModelRoutine]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelRoutine'
CREATE INDEX [IX_FK_ModelRoutine]
ON [dbo].[RoutineSet]
    ([ModelId]);
GO

-- Creating foreign key on [ModelId] in table 'ServerSet'
ALTER TABLE [dbo].[ServerSet]
ADD CONSTRAINT [FK_ModelServer]
    FOREIGN KEY ([ModelId])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelServer'
CREATE INDEX [IX_FK_ModelServer]
ON [dbo].[ServerSet]
    ([ModelId]);
GO

-- Creating foreign key on [Device_Id] in table 'QueueSet'
ALTER TABLE [dbo].[QueueSet]
ADD CONSTRAINT [FK_DeviceQueue]
    FOREIGN KEY ([Device_Id])
    REFERENCES [dbo].[DeviceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeviceQueue'
CREATE INDEX [IX_FK_DeviceQueue]
ON [dbo].[QueueSet]
    ([Device_Id]);
GO

-- Creating foreign key on [QueueId] in table 'RoutineSet'
ALTER TABLE [dbo].[RoutineSet]
ADD CONSTRAINT [FK_QueueRoutine]
    FOREIGN KEY ([QueueId])
    REFERENCES [dbo].[QueueSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_QueueRoutine'
CREATE INDEX [IX_FK_QueueRoutine]
ON [dbo].[RoutineSet]
    ([QueueId]);
GO

-- Creating foreign key on [RouterId] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [FK_RouterConnection]
    FOREIGN KEY ([RouterId])
    REFERENCES [dbo].[RouterSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RouterConnection'
CREATE INDEX [IX_FK_RouterConnection]
ON [dbo].[ConnectionSet]
    ([RouterId]);
GO

-- Creating foreign key on [Connection_Id] in table 'ConnectionServer'
ALTER TABLE [dbo].[ConnectionServer]
ADD CONSTRAINT [FK_ConnectionServer_Connection]
    FOREIGN KEY ([Connection_Id])
    REFERENCES [dbo].[ConnectionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Server_Id] in table 'ConnectionServer'
ALTER TABLE [dbo].[ConnectionServer]
ADD CONSTRAINT [FK_ConnectionServer_Server]
    FOREIGN KEY ([Server_Id])
    REFERENCES [dbo].[ServerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConnectionServer_Server'
CREATE INDEX [IX_FK_ConnectionServer_Server]
ON [dbo].[ConnectionServer]
    ([Server_Id]);
GO

-- Creating foreign key on [Connection_Id] in table 'ConnectionDevice'
ALTER TABLE [dbo].[ConnectionDevice]
ADD CONSTRAINT [FK_ConnectionDevice_Connection]
    FOREIGN KEY ([Connection_Id])
    REFERENCES [dbo].[ConnectionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Device_Id] in table 'ConnectionDevice'
ALTER TABLE [dbo].[ConnectionDevice]
ADD CONSTRAINT [FK_ConnectionDevice_Device]
    FOREIGN KEY ([Device_Id])
    REFERENCES [dbo].[DeviceSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConnectionDevice_Device'
CREATE INDEX [IX_FK_ConnectionDevice_Device]
ON [dbo].[ConnectionDevice]
    ([Device_Id]);
GO

-- Creating foreign key on [Connection_Id] in table 'ConnectionQueue'
ALTER TABLE [dbo].[ConnectionQueue]
ADD CONSTRAINT [FK_ConnectionQueue_Connection]
    FOREIGN KEY ([Connection_Id])
    REFERENCES [dbo].[ConnectionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Queue_Id] in table 'ConnectionQueue'
ALTER TABLE [dbo].[ConnectionQueue]
ADD CONSTRAINT [FK_ConnectionQueue_Queue]
    FOREIGN KEY ([Queue_Id])
    REFERENCES [dbo].[QueueSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConnectionQueue_Queue'
CREATE INDEX [IX_FK_ConnectionQueue_Queue]
ON [dbo].[ConnectionQueue]
    ([Queue_Id]);
GO

-- Creating foreign key on [Connection_Id] in table 'ConnectionComputer'
ALTER TABLE [dbo].[ConnectionComputer]
ADD CONSTRAINT [FK_ConnectionComputer_Connection]
    FOREIGN KEY ([Connection_Id])
    REFERENCES [dbo].[ConnectionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Computer_Id] in table 'ConnectionComputer'
ALTER TABLE [dbo].[ConnectionComputer]
ADD CONSTRAINT [FK_ConnectionComputer_Computer]
    FOREIGN KEY ([Computer_Id])
    REFERENCES [dbo].[ComputerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConnectionComputer_Computer'
CREATE INDEX [IX_FK_ConnectionComputer_Computer]
ON [dbo].[ConnectionComputer]
    ([Computer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------