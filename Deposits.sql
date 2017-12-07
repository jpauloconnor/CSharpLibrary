CREATE TABLE [dbo].[Deposits] (
    [DepositID]   INT IDENTITY (1, 1) NOT NULL,
    [Amount]        INT NOT NULL,
    [TransactionID] INT NOT NULL,
    CONSTRAINT [PK_dbo.Deposits] PRIMARY KEY CLUSTERED ([DepositID] ASC),
    CONSTRAINT [FK_dbo.Deposits_dbo.Transactions_TransactionID] FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[Transactions] ([TransactionID]) ON DELETE CASCADE
);

