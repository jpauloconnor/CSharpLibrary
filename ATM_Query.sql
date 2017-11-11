
CREATE TABLE [dbo].[Withdrawls] ( 
    [WithdrawlID] INT IDENTITY (1, 1) NOT NULL, 
    [Amount] INT NOT NULL,
	[TransactionID] INT NOT NULL, 
    CONSTRAINT [PK_dbo.Withdrawls] PRIMARY KEY CLUSTERED ([WithdrawlID] ASC), 
    CONSTRAINT [FK_dbo.Withdrawls_dbo.Transactions_TransactionID] FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[Transactions] ([TransactionID]) ON DELETE CASCADE 
);