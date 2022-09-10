
WAITFOR DELAY '00:00:03'

CREATE LOGIN AppLogin WITH PASSWORD = 'yourStrongPassw0rd!'
GO

DROP USER IF EXISTS AppUser
CREATE USER AppUser FROM LOGIN AppLogin
GO

DROP ROLE IF EXISTS AppUserRole
CREATE ROLE AppUserRole
GO

GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE TO AppUserRole
EXEC sp_addrolemember N'AppUserRole', N'AppUser' 
GO

Create database DB_Agilistas
GO

USE DB_Agilistas
GO 

CREATE TABLE [Categories] (
    [Id] uniqueidentifier NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Agilistas] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [PrimaryFocusId] uniqueidentifier NOT NULL,
    [TwitterHandle] nvarchar(max) NULL,
    CONSTRAINT [PK_Agilistas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Agilistas_Categories_PrimaryFocusId] FOREIGN KEY ([PrimaryFocusId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Agilistas_PrimaryFocusId] ON [Agilistas] ([PrimaryFocusId]);

GO


