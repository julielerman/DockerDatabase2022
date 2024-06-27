USE DB_Agilistas
GO

ALTER TABLE [Agilistas] ADD [SecondaryFocusId] uniqueidentifier NULL;
GO

UPDATE [Agilistas] SET [SecondaryFocusId] = '5f6d6f80-9f9a-469e-9036-07ecbb3971ea'
WHERE [Id] = '554be900-d1a4-4908-9d6a-5ef3ea05650e';
SELECT @@ROWCOUNT;


GO

UPDATE [Agilistas] SET [SecondaryFocusId] = '5f6d6f80-9f9a-469e-9036-07ecbb3971ea'
WHERE [Id] = '5efdb55d-1205-419f-8a0b-9cc7a15f8565';
SELECT @@ROWCOUNT;


GO

UPDATE [Agilistas] SET [SecondaryFocusId] = '5f6d6f80-9f9a-469e-9036-07ecbb3971ea'
WHERE [Id] = '83eda86f-c652-4666-ba17-db90b218a54b';
SELECT @@ROWCOUNT;


GO

UPDATE [Agilistas] SET [SecondaryFocusId] = 'c5b6a0e8-e43f-4765-906f-e15e019a19d8'
WHERE [Id] = '83eda86f-daf9-43f0-8bde-9ed2562bd12a';
SELECT @@ROWCOUNT;

GO

UPDATE [Agilistas] SET [SecondaryFocusId] = '0000000-0000-0000-0000-000000000000'
WHERE [Id] = '70de119b-3860-42c4-8150-19c7d017c0b5';
SELECT @@ROWCOUNT;

GO

UPDATE [Agilistas] SET [SecondaryFocusId] = '0000000-0000-0000-0000-000000000000'
WHERE [Id] = 'f2e5fdba-daf9-43f0-8bde-9ed2562bd12a';
SELECT @@ROWCOUNT;






CREATE INDEX [IX_Agilistas_SecondaryFocusId] ON [Agilistas] ([SecondaryFocusId]);

GO


ALTER TABLE [Agilistas] ADD CONSTRAINT [FK_Agilistas_Categories_SecondaryFocusId] FOREIGN KEY ([SecondaryFocusId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION;
