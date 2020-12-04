CREATE TABLE [dbo].[Users] (
    [Identifier]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Firstname]        NVARCHAR (150)  NULL,
    [Lastname]         NVARCHAR (150)  NULL,
    [Username]         NVARCHAR (50)   NOT NULL,
    [Password]         NVARCHAR (50)   NOT NULL,
    [Email]            NVARCHAR (200)  NOT NULL,
    [BirthDate]        DATE            NOT NULL,
    [Avatar]           NVARCHAR (2000) NULL,
    [IdentifierGender] BIGINT          NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Users_Gender] FOREIGN KEY ([IdentifierGender]) REFERENCES [dbo].[Gender] ([Identifier]),
    CONSTRAINT [FK_Users] UNIQUE NONCLUSTERED ([Identifier] ASC)
);

