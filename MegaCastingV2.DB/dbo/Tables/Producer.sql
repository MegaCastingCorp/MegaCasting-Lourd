CREATE TABLE [dbo].[Producer] (
    [Identifier]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (50)  NULL,
    [UserName]       NVARCHAR (50)  NULL,
    [Password]       NVARCHAR (50)  NULL,
    [Url]            NVARCHAR (200) NULL,
    [IdentifierPack] BIGINT         NULL,
    CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Producer_Pack] FOREIGN KEY ([IdentifierPack]) REFERENCES [dbo].[Pack] ([Identifier])
);



