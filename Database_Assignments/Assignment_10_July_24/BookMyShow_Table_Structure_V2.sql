USE [BookMyShow]
GO
/****** Object:  UserDefinedTableType [dbo].[genLis]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[genLis] AS TABLE(
	[GENID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[genreType]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[genreType] AS TABLE(
	[genId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[langType]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[langType] AS TABLE(
	[langId] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[lanLis]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[lanLis] AS TABLE(
	[LANID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SCREEN]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[SCREEN] AS TABLE(
	[Scrn_Name] [varchar](1) NULL,
	[PRJCTN_ID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SEAT]    Script Date: 24-07-2023 17:16:28 ******/
CREATE TYPE [dbo].[SEAT] AS TABLE(
	[Scrn_ID] [int] NULL,
	[SEAT_CAT] [int] NULL
)
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[Mobile] [int] NOT NULL,
 CONSTRAINT [PK_Customer_Id] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genre]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genre](
	[genre_Id] [int] IDENTITY(1,1) NOT NULL,
	[genre_Name] [varchar](60) NOT NULL,
 CONSTRAINT [PK_genre_Id] PRIMARY KEY CLUSTERED 
(
	[genre_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[language]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[language](
	[language_Id] [int] IDENTITY(1,1) NOT NULL,
	[Language] [varchar](60) NOT NULL,
 CONSTRAINT [PK_language_Id] PRIMARY KEY CLUSTERED 
(
	[language_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieGenre]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieGenre](
	[MovieGenre_Id] [int] IDENTITY(1,1) NOT NULL,
	[Movie_Id] [int] NOT NULL,
	[genre_Id] [int] NOT NULL,
 CONSTRAINT [PK_MovieGenre_Id] PRIMARY KEY CLUSTERED 
(
	[MovieGenre_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieLanguage]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieLanguage](
	[MovieLanguage_Id] [int] IDENTITY(1,1) NOT NULL,
	[Movie_Id] [int] NOT NULL,
	[Language_Id] [int] NOT NULL,
 CONSTRAINT [PK_MovieLanguage_Id] PRIMARY KEY CLUSTERED 
(
	[MovieLanguage_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movies]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[Movie_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NULL,
 CONSTRAINT [PK_movies_Id] PRIMARY KEY CLUSTERED 
(
	[Movie_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentOptions]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentOptions](
	[PaymentOptions_Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [varchar](60) NOT NULL,
	[Description] [varchar](100) NOT NULL,
 CONSTRAINT [PK_PaymentOptions_Id] PRIMARY KEY CLUSTERED 
(
	[PaymentOptions_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Place]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[Place_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NULL,
 CONSTRAINT [PK_Place_Id] PRIMARY KEY CLUSTERED 
(
	[Place_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectionType]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectionType](
	[Projection_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Projection_Id] PRIMARY KEY CLUSTERED 
(
	[Projection_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Screen]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Screen](
	[Screen_Id] [int] IDENTITY(1,1) NOT NULL,
	[Screen_Name] [varchar](60) NULL,
	[Theatre_Id] [int] NOT NULL,
	[Projection_Id] [int] NULL,
 CONSTRAINT [PK_Screen_Id] PRIMARY KEY CLUSTERED 
(
	[Screen_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seat]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat](
	[Seat_Id] [int] IDENTITY(1,1) NOT NULL,
	[Screen_Id] [int] NOT NULL,
	[Seat_Category_Id] [int] NOT NULL,
 CONSTRAINT [PK_Seat_Id] PRIMARY KEY CLUSTERED 
(
	[Seat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeatCategory]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeatCategory](
	[Seat_Category_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Seat_Category_Id] PRIMARY KEY CLUSTERED 
(
	[Seat_Category_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Show]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Show](
	[Show_Id] [int] IDENTITY(1,1) NOT NULL,
	[Screen_Id] [int] NOT NULL,
	[MovieLanguage_Id] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Show_Id] PRIMARY KEY CLUSTERED 
(
	[Show_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student1]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student1](
	[Id] [int] NULL,
	[Name] [varchar](1) NULL,
	[Location] [varchar](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[theater]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[theater](
	[Theater_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](60) NOT NULL,
	[Place_Id] [int] NOT NULL,
 CONSTRAINT [PK_theater_Id] PRIMARY KEY CLUSTERED 
(
	[Theater_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Ticket_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Id] [int] NULL,
	[PaymentOptions_Id] [int] NULL,
	[Show_Id] [int] NULL,
 CONSTRAINT [PK_Ticket_Id] PRIMARY KEY CLUSTERED 
(
	[Ticket_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketSeat]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketSeat](
	[TicketSeat_Id] [int] IDENTITY(1,1) NOT NULL,
	[Seat_Id] [int] NOT NULL,
	[TicketId] [int] NOT NULL,
 CONSTRAINT [PK_TicketSeat_Id] PRIMARY KEY CLUSTERED 
(
	[TicketSeat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MovieGenre]  WITH CHECK ADD  CONSTRAINT [FK_MovieGenre_genre] FOREIGN KEY([genre_Id])
REFERENCES [dbo].[genre] ([genre_Id])
GO
ALTER TABLE [dbo].[MovieGenre] CHECK CONSTRAINT [FK_MovieGenre_genre]
GO
ALTER TABLE [dbo].[MovieGenre]  WITH CHECK ADD  CONSTRAINT [FK_MovieGenre_movie] FOREIGN KEY([Movie_Id])
REFERENCES [dbo].[movies] ([Movie_Id])
GO
ALTER TABLE [dbo].[MovieGenre] CHECK CONSTRAINT [FK_MovieGenre_movie]
GO
ALTER TABLE [dbo].[MovieLanguage]  WITH CHECK ADD  CONSTRAINT [FK_MovieLanguage_Language] FOREIGN KEY([Language_Id])
REFERENCES [dbo].[language] ([language_Id])
GO
ALTER TABLE [dbo].[MovieLanguage] CHECK CONSTRAINT [FK_MovieLanguage_Language]
GO
ALTER TABLE [dbo].[MovieLanguage]  WITH CHECK ADD  CONSTRAINT [FK_MovieLanguage_movies] FOREIGN KEY([Movie_Id])
REFERENCES [dbo].[movies] ([Movie_Id])
GO
ALTER TABLE [dbo].[MovieLanguage] CHECK CONSTRAINT [FK_MovieLanguage_movies]
GO
ALTER TABLE [dbo].[Screen]  WITH CHECK ADD  CONSTRAINT [FK_Screen_ProjectionType] FOREIGN KEY([Projection_Id])
REFERENCES [dbo].[ProjectionType] ([Projection_Id])
GO
ALTER TABLE [dbo].[Screen] CHECK CONSTRAINT [FK_Screen_ProjectionType]
GO
ALTER TABLE [dbo].[Screen]  WITH CHECK ADD  CONSTRAINT [FK_Screen_theater] FOREIGN KEY([Theatre_Id])
REFERENCES [dbo].[theater] ([Theater_Id])
GO
ALTER TABLE [dbo].[Screen] CHECK CONSTRAINT [FK_Screen_theater]
GO
ALTER TABLE [dbo].[Seat]  WITH CHECK ADD  CONSTRAINT [FK_Seat_Screen] FOREIGN KEY([Screen_Id])
REFERENCES [dbo].[Screen] ([Screen_Id])
GO
ALTER TABLE [dbo].[Seat] CHECK CONSTRAINT [FK_Seat_Screen]
GO
ALTER TABLE [dbo].[Seat]  WITH CHECK ADD  CONSTRAINT [FK_Seat_SeatCategory] FOREIGN KEY([Seat_Category_Id])
REFERENCES [dbo].[SeatCategory] ([Seat_Category_Id])
GO
ALTER TABLE [dbo].[Seat] CHECK CONSTRAINT [FK_Seat_SeatCategory]
GO
ALTER TABLE [dbo].[Show]  WITH CHECK ADD  CONSTRAINT [FK_Show_MovieLanguage] FOREIGN KEY([MovieLanguage_Id])
REFERENCES [dbo].[MovieLanguage] ([MovieLanguage_Id])
GO
ALTER TABLE [dbo].[Show] CHECK CONSTRAINT [FK_Show_MovieLanguage]
GO
ALTER TABLE [dbo].[Show]  WITH CHECK ADD  CONSTRAINT [FK_Show_Screen] FOREIGN KEY([Screen_Id])
REFERENCES [dbo].[Screen] ([Screen_Id])
GO
ALTER TABLE [dbo].[Show] CHECK CONSTRAINT [FK_Show_Screen]
GO
ALTER TABLE [dbo].[theater]  WITH CHECK ADD  CONSTRAINT [FK_theater_Place] FOREIGN KEY([Place_Id])
REFERENCES [dbo].[Place] ([Place_Id])
GO
ALTER TABLE [dbo].[theater] CHECK CONSTRAINT [FK_theater_Place]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Customer] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Customer]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_PaymentOptions] FOREIGN KEY([PaymentOptions_Id])
REFERENCES [dbo].[PaymentOptions] ([PaymentOptions_Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_PaymentOptions]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Show] FOREIGN KEY([Show_Id])
REFERENCES [dbo].[Show] ([Show_Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Show]
GO
ALTER TABLE [dbo].[TicketSeat]  WITH CHECK ADD  CONSTRAINT [FK_TicketSeat_Seat] FOREIGN KEY([Seat_Id])
REFERENCES [dbo].[Seat] ([Seat_Id])
GO
ALTER TABLE [dbo].[TicketSeat] CHECK CONSTRAINT [FK_TicketSeat_Seat]
GO
ALTER TABLE [dbo].[TicketSeat]  WITH CHECK ADD  CONSTRAINT [FK_TicketSeat_Ticket] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Ticket] ([Ticket_Id])
GO
ALTER TABLE [dbo].[TicketSeat] CHECK CONSTRAINT [FK_TicketSeat_Ticket]
GO
/****** Object:  StoredProcedure [dbo].[genreInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[genreInsertTable]
@gen VARCHAR(60)
AS 
BEGIN
    INSERT INTO genre(genre_Name)
	VALUES (@gen)
END 

GO
/****** Object:  StoredProcedure [dbo].[languageInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[languageInsertTable]
@lang VARCHAR(60)
AS 
BEGIN
    INSERT INTO [language]([Language])
	VALUES (@lang)
END 

GO
/****** Object:  StoredProcedure [dbo].[MovieInsert]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MovieInsert]
@name VARCHAR (60),
@genNEW AS genLis READONLY,
@lanNEW AS lanLis READONLY

AS
BEGIN 
	INSERT INTO movies([Name])
	SELECT @name

	DECLARE @MOVIEIDSCOPE INT = SCOPE_IDENTITY()
	
	INSERT INTO MovieGenre(Movie_Id,genre_Id)
	SELECT @MOVIEIDSCOPE, GENID FROM @genNEW

	INSERT INTO MovieLanguage(Movie_Id, Language_Id)
	SELECT @MOVIEIDSCOPE, LANID FROM @lanNEW

END
GO
/****** Object:  StoredProcedure [dbo].[movieInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[movieInsertTable]
@name VARCHAR(60)
AS 
BEGIN
    INSERT INTO movies([Name])
	VALUES (@name)
END 

GO
/****** Object:  StoredProcedure [dbo].[placeInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[placeInsertTable]
@name VARCHAR(60)
AS 
BEGIN
    INSERT INTO Place([Name])
	VALUES (@name)
END 

GO
/****** Object:  StoredProcedure [dbo].[projectioTypeInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[projectioTypeInsertTable]
@proejection VARCHAR(60)
AS 
BEGIN
    INSERT INTO ProjectionType([Name])
	VALUES (@proejection)
END 

GO
/****** Object:  StoredProcedure [dbo].[projectTYpeInsert]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[projectTYpeInsert]
@name VARCHAR(60)
AS
BEGIN
	INSERT INTO ProjectionType([Name])
	SELECT @name
END

EXEC projectTYpeInsert
	@name = 'IMAX'
EXEC projectTYpeInsert
	@name = '4K'
EXEC projectTYpeInsert
	@name = 'RGB LASER'
EXEC projectTYpeInsert
	@name = '2K'
GO
/****** Object:  StoredProcedure [dbo].[seatCatInsert]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[seatCatInsert]
@name VARCHAR(60),
@Price INT
AS
BEGIN
	INSERT INTO SeatCategory([Name],Price)
	SELECT @name, @Price
END
GO
/****** Object:  StoredProcedure [dbo].[theatreInsertTable]    Script Date: 24-07-2023 17:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[theatreInsertTable]
@name VARCHAR(60),
@projectType INT,
@place_id INT
AS 
BEGIN
    INSERT INTO theater([Name],Projection_Id,Place_Id)
	VALUES (@name, @projectType, @place_id)
END 

GO
