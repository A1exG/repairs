CREATE TABLE [dbo].[TVs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DisplayName] NVARCHAR(100) NOT NULL, 
    [InventoryNumber] NVARCHAR(100) NULL, 
    [VendorName] NVARCHAR(100) NOT NULL, 
    [ModelName] NVARCHAR(100) NOT NULL, 
    [SerialNumber] NVARCHAR(100) NULL,
)
