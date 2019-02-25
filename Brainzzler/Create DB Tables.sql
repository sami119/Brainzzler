USE [Brainzzler_DB]
GO

/****** Object: Table [dbo].[Answers] Script Date: 24.2.2019 г. 10:40:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Answers] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [QuestionId] BIGINT        NOT NULL,
    [Answer]     VARCHAR (255) NOT NULL,
    [Correct]    SMALLINT      NOT NULL
);


CREATE TABLE [dbo].[Questions] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Question] VARCHAR (255) NOT NULL
);


CREATE TABLE [dbo].[Test] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Test] VARCHAR (100) NOT NULL
);


CREATE TABLE [dbo].[TestQuestions] (
    [Id]         BIGINT IDENTITY (1, 1) NOT NULL,
    [TestId]     INT    NOT NULL,
    [QuestionId] INT    NOT NULL
);


CREATE TABLE [dbo].[UserTestsResults] (
    [Id]         BIGINT   IDENTITY (1, 1) NOT NULL,
    [UserId]     INT      NOT NULL,
    [TestId]     INT      NOT NULL,
    [QuestionID] INT      NOT NULL,
    [AnswerId]   INT      NOT NULL,
    [Chosen]     SMALLINT NULL,
    [Correct]    SMALLINT NULL
);



