CREATE TABLE [dbo].[Offer] (
    [Identifier]             BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]                   NVARCHAR (50)   NOT NULL,
    [Reference]              NVARCHAR (50)   NULL,
    [IdentifierJob]          BIGINT          NOT NULL,
    [IdentifierContractType] BIGINT          NOT NULL,
    [PublishDateTime]        DATE            NULL,
    [Duration]               INT             NOT NULL,
    [StartContractDate]      DATE            NULL,
    [PostCount]              INT             NULL,
    [JobDescription]         NVARCHAR (2000) NULL,
    [ProfilDescription]      NVARCHAR (2000) NULL,
    [Street]                 NVARCHAR (70)   NULL,
    [City]                   NVARCHAR (50)   NULL,
    [ZipCode]                NCHAR (10)      NULL,
    [IdentifierProducer]     BIGINT          NOT NULL,
    [IdentifierCategory]     BIGINT          NOT NULL,
    [IdentifierFilters]      BIGINT          NOT NULL,
    [IdentifierApply]        BIGINT          NULL,
    CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Offer_Apply] FOREIGN KEY ([Identifier]) REFERENCES [dbo].[Apply] ([IdentifierOffer]),
    CONSTRAINT [FK_Offer_Category] FOREIGN KEY ([IdentifierCategory]) REFERENCES [dbo].[Category] ([Identifier]),
    CONSTRAINT [FK_Offer_ContractType] FOREIGN KEY ([IdentifierContractType]) REFERENCES [dbo].[ContractType] ([Identifier]),
    CONSTRAINT [FK_Offer_Filtre] FOREIGN KEY ([IdentifierFilters]) REFERENCES [dbo].[Filtre] ([Identifier]),
    CONSTRAINT [FK_Offer_Job] FOREIGN KEY ([IdentifierJob]) REFERENCES [dbo].[Job] ([Identifier]),
    CONSTRAINT [FK_Offer_Producer] FOREIGN KEY ([IdentifierProducer]) REFERENCES [dbo].[Producer] ([Identifier])
);



