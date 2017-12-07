CREATE TABLE [dbo].[Accounts] (
    [AccountID]     INT           IDENTITY (1, 1) NOT NULL,
    [AccountNumber] INT           NOT NULL,
	[Pin] INT NOT NULL, 
    [AccountType]   NVARCHAR (25) NOT NULL,
    [CustomerID]    INT           NOT NULL,
    CONSTRAINT [PK_dbo.Accounts] PRIMARY KEY CLUSTERED ([AccountID] ASC)
);

