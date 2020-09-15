CREATE TABLE [dbo].[PrinterRepairs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RepairDate] DATETIME2 NOT NULL, 
    [RepairCost] NVARCHAR(100) NOT NULL, 
    [RepairCompany] NVARCHAR(100) NOT NULL, 
    [Comment] NVARCHAR(100) NULL, 
    [PrinterId] INT NOT NULL, 
    CONSTRAINT [FK_PrinterRepairs_ToPrinters] FOREIGN KEY ([PrinterId]) REFERENCES [Printers]([Id]) 

)
