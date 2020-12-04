CREATE TABLE [dbo].[Pack] (
    [Identifier] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Label]      NVARCHAR (150) NULL,
    [Price]      BIGINT         NULL,
    CONSTRAINT [PK_Pack] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

