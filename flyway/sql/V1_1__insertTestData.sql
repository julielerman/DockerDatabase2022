USE DB_Agilistas 
GO

INSERT INTO [Categories] ([Id], [Description])
VALUES ('167d1f6b-a93d-49e4-8a0d-e651369e018b', N'Agile Testing');
INSERT INTO [Categories] ([Id], [Description])
VALUES ('5f6d6f80-9f9a-469e-9036-07ecbb3971ea', N'Exploratory Testing');
INSERT INTO [Categories] ([Id], [Description])
VALUES ('c5b6a0e8-e43f-4765-906f-e15e019a19d8', N'Psychology of Collaboration');
INSERT INTO [Categories] ([Id], [Description])
VALUES ('c461183d-e3e4-4f14-a4d4-34431a3b4c39', N'Agile Data');

GO

INSERT INTO [Agilistas] ([Id], [Name], [PrimaryFocusId], [TwitterHandle])
VALUES 
('5efdb55d-1205-419f-8a0b-9cc7a15f8565', N'Lisa Crispin', '167d1f6b-a93d-49e4-8a0d-e651369e018b', '@lisacrispin'),
('554be900-d1a4-4908-9d6a-5ef3ea05650e', N'Janet Gregory', '167d1f6b-a93d-49e4-8a0d-e651369e018b', '@janetgregoryca'),
('f2e5fdba-daf9-43f0-8bde-9ed2562bd12a', N'Melissa Eaden', '167d1f6b-a93d-49e4-8a0d-e651369e018b', '@melthetester'),
('83eda86f-c652-4666-ba17-db90b218a54b', N'Linda Rising', 'c5b6a0e8-e43f-4765-906f-e15e019a19d8', '@risinglinda'),
('70de119b-3860-42c4-8150-19c7d017c0b5', N'Julie Lerman', 'c461183d-e3e4-4f14-a4d4-34431a3b4c39', '@julielerman');

GO
