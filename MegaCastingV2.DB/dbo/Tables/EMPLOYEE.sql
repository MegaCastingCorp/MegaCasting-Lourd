CREATE TABLE [dbo].[Employee] (
    [Identifier]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [Firstname]        NVARCHAR (150) NULL,
    [Lastname]         NVARCHAR (150) NULL,
    [Username]         NVARCHAR (150) NOT NULL,
    [Password]         NVARCHAR (200) NOT NULL,
    [Admin]            BIT            NOT NULL,
    [IdentifierGender] BIGINT         NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Employee_Gender] FOREIGN KEY ([IdentifierGender]) REFERENCES [dbo].[Gender] ([Identifier])
);

