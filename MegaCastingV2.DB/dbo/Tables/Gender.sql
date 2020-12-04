CREATE TABLE [dbo].[Gender] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Label]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Gender_1] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [PK_Gender] UNIQUE NONCLUSTERED ([Identifier] ASC)
);

