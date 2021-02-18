IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Brand] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [LogoUrl] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Brand] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [CompanyInformation] (
        [Id] int NOT NULL IDENTITY,
        [Name] int NOT NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Slogan] nvarchar(max) NULL,
        [LogoUrl] nvarchar(max) NULL,
        [CompanyType] nvarchar(max) NULL,
        [CurrencyType] nvarchar(max) NULL,
        [CurrencyImage] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_CompanyInformation] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Customer] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [NID] nvarchar(max) NULL,
        [PhotoUrl] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Customer] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Supplier] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [NID] nvarchar(max) NULL,
        [PhotoUrl] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Supplier] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Unit] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Unit] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [User] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [PhotoUrl] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [VatAndTax] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Amount] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_VatAndTax] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Category] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [BrandId] int NULL,
        CONSTRAINT [PK_Category] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Category_Brand_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brand] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Stock] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [SupplierId] int NULL,
        [TotalAmount] decimal(16,2) NOT NULL,
        [InvoiceStatus] bit NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Stock] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Stock_Supplier_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Supplier] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Invoice] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] int NOT NULL,
        [CustomerId] int NULL,
        [SubTotal] decimal(16,2) NOT NULL,
        [GrandTotal] decimal(16,2) NOT NULL,
        [Discount] decimal(16,2) NOT NULL,
        [VatAndTaxId] int NULL,
        [PaymentMode] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Invoice] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Invoice_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Invoice_VatAndTax_VatAndTaxId] FOREIGN KEY ([VatAndTaxId]) REFERENCES [VatAndTax] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [Product] (
        [Id] int NOT NULL IDENTITY,
        [Name] int NOT NULL,
        [PhotoUrl] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CategoryId] int NULL,
        [UnitId] int NULL,
        [WarningQuantity] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Product] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Product_Unit_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Unit] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [InvoiceDetails] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [InvoiceId] int NULL,
        [ProductId] int NULL,
        [Quantity] decimal(16,2) NOT NULL,
        [Amount] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_InvoiceDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_InvoiceDetails_Invoice_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_InvoiceDetails_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE TABLE [StockDetail] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [StockId] int NULL,
        [ProcutId] int NULL,
        [ProductId] int NULL,
        [VatId] int NULL,
        [VatAndTaxId] int NULL,
        [PurchasePrice] decimal(16,2) NOT NULL,
        [BasePrice] decimal(16,2) NOT NULL,
        [SellPrice] decimal(16,2) NOT NULL,
        [IsBaseAndSellPriceSame] bit NOT NULL,
        [IsVatActive] bit NOT NULL,
        [Quantity] decimal(16,2) NOT NULL,
        [Amount] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_StockDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StockDetail_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_StockDetail_Stock_StockId] FOREIGN KEY ([StockId]) REFERENCES [Stock] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_StockDetail_VatAndTax_VatAndTaxId] FOREIGN KEY ([VatAndTaxId]) REFERENCES [VatAndTax] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Category_BrandId] ON [Category] ([BrandId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Invoice_CustomerId] ON [Invoice] ([CustomerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Invoice_VatAndTaxId] ON [Invoice] ([VatAndTaxId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_InvoiceDetails_InvoiceId] ON [InvoiceDetails] ([InvoiceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_InvoiceDetails_ProductId] ON [InvoiceDetails] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Product_CategoryId] ON [Product] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Product_UnitId] ON [Product] ([UnitId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_Stock_SupplierId] ON [Stock] ([SupplierId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_StockDetail_ProductId] ON [StockDetail] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_StockDetail_StockId] ON [StockDetail] ([StockId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    CREATE INDEX [IX_StockDetail_VatAndTaxId] ON [StockDetail] ([VatAndTaxId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210102102108_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210102102108_initial', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Supplier] ADD [CompanyName] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Supplier] ADD [Designation] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Supplier] ADD [Phone] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Customer] ADD [CompanyName] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Customer] ADD [Designation] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Customer] ADD [Phone] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    ALTER TABLE [Customer] ADD [Profession] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210106082824_SupplierAndCustomer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210106082824_SupplierAndCustomer', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    ALTER TABLE [Category] DROP CONSTRAINT [FK_Category_Brand_BrandId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    DROP INDEX [IX_Category_BrandId] ON [Category];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Category]') AND [c].[name] = N'BrandId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Category] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Category] DROP COLUMN [BrandId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    ALTER TABLE [Product] ADD [BrandId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    CREATE INDEX [IX_Product_BrandId] ON [Product] ([BrandId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    ALTER TABLE [Product] ADD CONSTRAINT [FK_Product_Brand_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brand] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107053612_swapTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210107053612_swapTable', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [CreatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [CreatedDate] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [IsActive] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [IsUpdated] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [UpdatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    ALTER TABLE [Category] ADD [UpdatedDate] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107054022_baseClassToCategory')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210107054022_baseClassToCategory', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107081032_unitTable')
BEGIN
    ALTER TABLE [Unit] ADD [ShortForm] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107081032_unitTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210107081032_unitTable', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107094059_productTable')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Product]') AND [c].[name] = N'Name');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Product] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Product] ALTER COLUMN [Name] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210107094059_productTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210107094059_productTable', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210108091732_stockTable')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[StockDetail]') AND [c].[name] = N'ProcutId');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [StockDetail] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [StockDetail] DROP COLUMN [ProcutId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210108091732_stockTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210108091732_stockTable', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE TABLE [PurchaseProduct] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [SupplierId] int NULL,
        [GrandTotal] decimal(16,2) NOT NULL,
        [SubTotal] decimal(16,2) NOT NULL,
        [Discount] decimal(16,2) NOT NULL,
        [PaidAmount] decimal(16,2) NOT NULL,
        [Dues] decimal(16,2) NOT NULL,
        [PaymentMode] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_PurchaseProduct] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PurchaseProduct_Supplier_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Supplier] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE TABLE [PurchaseProductDetail] (
        [Id] int NOT NULL IDENTITY,
        [PurchaseProductId] int NULL,
        [InvoiceNumber] nvarchar(max) NULL,
        [ProductId] int NULL,
        [Quantity] decimal(16,2) NOT NULL,
        [UnitPrice] decimal(16,2) NOT NULL,
        [VatAndTaxId] int NULL,
        [BasePrice] decimal(16,2) NOT NULL,
        [SellPrice] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_PurchaseProductDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PurchaseProductDetail_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PurchaseProductDetail_PurchaseProduct_PurchaseProductId] FOREIGN KEY ([PurchaseProductId]) REFERENCES [PurchaseProduct] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PurchaseProductDetail_VatAndTax_VatAndTaxId] FOREIGN KEY ([VatAndTaxId]) REFERENCES [VatAndTax] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE INDEX [IX_PurchaseProduct_SupplierId] ON [PurchaseProduct] ([SupplierId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE INDEX [IX_PurchaseProductDetail_ProductId] ON [PurchaseProductDetail] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE INDEX [IX_PurchaseProductDetail_PurchaseProductId] ON [PurchaseProductDetail] ([PurchaseProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    CREATE INDEX [IX_PurchaseProductDetail_VatAndTaxId] ON [PurchaseProductDetail] ([VatAndTaxId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110030242_purchaseProduct')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210110030242_purchaseProduct', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110162919_inventory')
BEGIN
    CREATE TABLE [Inventory] (
        [Id] int NOT NULL IDENTITY,
        [ProductId] int NULL,
        [AvailableQuantity] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Inventory] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Inventory_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110162919_inventory')
BEGIN
    CREATE INDEX [IX_Inventory_ProductId] ON [Inventory] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210110162919_inventory')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210110162919_inventory', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE TABLE [SalesInvoice] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [CustomerId] int NULL,
        [SubTotal] decimal(16,2) NOT NULL,
        [Discount] decimal(16,2) NOT NULL,
        [GrandTotal] decimal(16,2) NOT NULL,
        [PaidAmount] decimal(16,2) NOT NULL,
        [Dues] decimal(16,2) NOT NULL,
        [PaymentMode] nvarchar(max) NULL,
        [VatAndTaxId] int NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_SalesInvoice] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_SalesInvoice_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_SalesInvoice_VatAndTax_VatAndTaxId] FOREIGN KEY ([VatAndTaxId]) REFERENCES [VatAndTax] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE TABLE [SalesInvoiceDetail] (
        [Id] int NOT NULL IDENTITY,
        [InvoiceNumber] nvarchar(max) NULL,
        [SalesInvoiceId] int NULL,
        [ProductId] int NULL,
        [Quantity] decimal(16,2) NOT NULL,
        [Price] decimal(16,2) NOT NULL,
        [IsActive] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [IsUpdated] bit NOT NULL,
        [CreatedDate] nvarchar(max) NULL,
        [UpdatedDate] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_SalesInvoiceDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_SalesInvoiceDetail_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_SalesInvoiceDetail_SalesInvoice_SalesInvoiceId] FOREIGN KEY ([SalesInvoiceId]) REFERENCES [SalesInvoice] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE INDEX [IX_SalesInvoice_CustomerId] ON [SalesInvoice] ([CustomerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE INDEX [IX_SalesInvoice_VatAndTaxId] ON [SalesInvoice] ([VatAndTaxId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE INDEX [IX_SalesInvoiceDetail_ProductId] ON [SalesInvoiceDetail] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    CREATE INDEX [IX_SalesInvoiceDetail_SalesInvoiceId] ON [SalesInvoiceDetail] ([SalesInvoiceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111144501_SalesInvoice')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210111144501_SalesInvoice', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111151949_SalesInvoiceUpdated')
BEGIN
    ALTER TABLE [SalesInvoiceDetail] ADD [UnitPrice] decimal(16,2) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111151949_SalesInvoiceUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210111151949_SalesInvoiceUpdated', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111162317_inventorySellPrice')
BEGIN
    ALTER TABLE [Inventory] ADD [SellPrice] decimal(16,2) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210111162317_inventorySellPrice')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210111162317_inventorySellPrice', N'5.0.1');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210113065526_user')
BEGIN
    ALTER TABLE [User] ADD [HasLogged] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210113065526_user')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210113065526_user', N'5.0.1');
END;
GO

COMMIT;
GO

