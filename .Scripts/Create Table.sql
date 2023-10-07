IF NOT EXISTS(SELECT name FROM master.sys.sysdatabases WHERE name = 'CepBrasil')
BEGIN
	CREATE DATABASE CepBrasil
END
GO

USE [CepBrasil]
GO
/****** Object:  Table [dbo].[Adresses]    Script Date: 06/10/2023 23:09:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[NeighborhoodID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[ZipCode] [char](8) NULL,
	[Address] [nvarchar](150) NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 06/10/2023 23:09:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[StateID] [int] NOT NULL,
	[ZipCode] [char](8) NULL,
	[City] [varchar](100) NOT NULL,
	[Capital] [bit] NOT NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Neighborhoods]    Script Date: 06/10/2023 23:09:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Neighborhoods](
	[NeighborhoodID] [int] IDENTITY(1,1) NOT NULL,
	[CityID] [int] NOT NULL,
	[StateID] [int] NOT NULL,
	[Neighborhood] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Bairro] PRIMARY KEY CLUSTERED 
(
	[NeighborhoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 06/10/2023 23:09:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[FU] [char](2) NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adresses]  WITH NOCHECK ADD  CONSTRAINT [FK_Endereco_Bairro] FOREIGN KEY([NeighborhoodID])
REFERENCES [dbo].[Neighborhoods] ([NeighborhoodID])
GO
ALTER TABLE [dbo].[Adresses] CHECK CONSTRAINT [FK_Endereco_Bairro]
GO
ALTER TABLE [dbo].[Adresses]  WITH NOCHECK ADD  CONSTRAINT [FK_Endereco_Cidade] FOREIGN KEY([CityID])
REFERENCES [dbo].[Cities] ([CityID])
GO
ALTER TABLE [dbo].[Adresses] CHECK CONSTRAINT [FK_Endereco_Cidade]
GO
ALTER TABLE [dbo].[Adresses]  WITH NOCHECK ADD  CONSTRAINT [FK_Endereco_Estado] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[Adresses] CHECK CONSTRAINT [FK_Endereco_Estado]
GO
ALTER TABLE [dbo].[Cities]  WITH NOCHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cidade_Estado]
GO
ALTER TABLE [dbo].[Neighborhoods]  WITH NOCHECK ADD  CONSTRAINT [FK_Bairro_Cidade] FOREIGN KEY([CityID])
REFERENCES [dbo].[Cities] ([CityID])
GO
ALTER TABLE [dbo].[Neighborhoods] CHECK CONSTRAINT [FK_Bairro_Cidade]
GO
ALTER TABLE [dbo].[Neighborhoods]  WITH NOCHECK ADD  CONSTRAINT [FK_Bairro_Estado] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[Neighborhoods] CHECK CONSTRAINT [FK_Bairro_Estado]
GO
