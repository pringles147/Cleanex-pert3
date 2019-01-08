CREATE TABLE [dbo].[Employees] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [FirstName]        NVARCHAR (50)    NOT NULL,
    [LastName]         NVARCHAR (50)    NULL,
    [JobTitle]         NVARCHAR (50)    NULL,
    [Phone]            DECIMAL (18)     NULL,
    [StartDate]        DATE             NULL,
    [EmployPercentage] NUMERIC (18)     NULL,
    [OnVacation]       BINARY (50)      NULL,
    [Email]            NVARCHAR (50)    NULL,
    [Salary]           MONEY            NULL,
    [Born]             DATE             NULL,
    [Gender]           NVARCHAR (50)    NULL,
    [Profilbild] IMAGE NULL, 
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Information about employees', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Employees';

