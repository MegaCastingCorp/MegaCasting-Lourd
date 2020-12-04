CREATE TABLE [dbo].[Category] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Label]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

