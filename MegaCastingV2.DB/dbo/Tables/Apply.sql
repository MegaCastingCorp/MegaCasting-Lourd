CREATE TABLE [dbo].[Apply] (
    [IdentifierOffer] BIGINT IDENTITY (1, 1) NOT NULL,
    [IdentifierUsers] BIGINT NOT NULL,
    CONSTRAINT [PK_Apply] PRIMARY KEY CLUSTERED ([IdentifierOffer] ASC),
    CONSTRAINT [FK_Apply_Users] FOREIGN KEY ([IdentifierUsers]) REFERENCES [dbo].[Users] ([Identifier])
);

