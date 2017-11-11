
CREATE TABLE [dbo].[Transactions] ( 
    [TransactionID] INT IDENTITY (1, 1) NOT NULL, 
    [TransactionType] NVARCHAR (200) NULL, 
	[LastName] NVARCHAR (200) NULL,
	[AccountID] INT NOT NULL, 
    CONSTRAINT [PK_dbo.Transaction] PRIMARY KEY CLUSTERED ([TransactionID] ASC), 
    CONSTRAINT [FK_dbo.Transactions_dbo.Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([AccountID]) ON DELETE CASCADE 
);