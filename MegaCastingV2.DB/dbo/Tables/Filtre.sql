CREATE TABLE [dbo].[Filtre] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Label]      NVARCHAR (30) NULL,
    CONSTRAINT [PK_Filtre] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

