USE [aspnet-Major_Project_UBA_ProtoType-F295F12D-9D0D-4327-8DF6-E754FBF44F52]
GO

/****** Object: Table [dbo].[Transaction] Script Date: 5/19/2021 6:58:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transaction] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [StartDate]       DATETIME2 (7)   NOT NULL,
    [AccountNumber]   NVARCHAR (60)   NOT NULL,
    [TransactionType] NVARCHAR (MAX)  NULL,
    [Amount]          DECIMAL (18, 2) NOT NULL,
    [Location]        NVARCHAR (MAX)  NULL,
    [Item_purchase]   NVARCHAR (MAX)  NULL
);

insert into [Transaction] (StartDate,AccountNumber,TransactionType,Amount,Location,Item_purchase) values('05/19/2021 23:59',409382394,'purchase',50000,'KIngston','Liquor');
