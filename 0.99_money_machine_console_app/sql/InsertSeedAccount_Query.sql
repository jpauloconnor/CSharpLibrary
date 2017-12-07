SET IDENTITY_INSERT dbo.Accounts ON

insert into dbo.Accounts (AccountID, AccountNumber, Pin, AccountType, CustomerID, Balance)
select 1, 4321, 4321, N'Savings', 9, 0
where not exists (select 1 from dbo.Accounts where AccountID = 1)
go

SET IDENTITY_INSERT dbo.Accounts OFF 
