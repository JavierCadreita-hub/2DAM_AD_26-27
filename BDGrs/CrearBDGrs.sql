Use master
Create DataBase BDGrs
Go
USE [BDGrs]
GO
/****** Object:  Table [dbo].[Albergues]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Albergues](
	[Id] [nvarchar](10) NOT NULL,
	[IdZona] [nvarchar](5) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[TotalPlazas] [int] NOT NULL,
	[Precio] [real] NOT NULL,
 CONSTRAINT [PK_Albergues] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Dni] [nvarchar](9) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
	[Telefono] [nvarchar](9) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etapas]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etapas](
	[IdGr] [nvarchar](5) NOT NULL,
	[NumEtapa] [int] NOT NULL,
	[IdZona] [nvarchar](5) NOT NULL,
	[Km] [int] NULL,
	[Desnivel] [int] NULL,
 CONSTRAINT [PK_Etapas] PRIMARY KEY CLUSTERED 
(
	[IdGr] ASC,
	[NumEtapa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grs]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grs](
	[Id] [nvarchar](5) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Gr] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ocupaciones]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocupaciones](
	[Dni] [nvarchar](9) NOT NULL,
	[IdAlbergue] [nvarchar](10) NOT NULL,
	[CantPersonas] [int] NOT NULL,
 CONSTRAINT [PK_Ocupaciones_1] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC,
	[IdAlbergue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zonas]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zonas](
	[Id] [nvarchar](5) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Zonas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Albergues]  WITH CHECK ADD  CONSTRAINT [FK_Albergues_Zonas] FOREIGN KEY([IdZona])
REFERENCES [dbo].[Zonas] ([Id])
GO
ALTER TABLE [dbo].[Albergues] CHECK CONSTRAINT [FK_Albergues_Zonas]
GO
ALTER TABLE [dbo].[Etapas]  WITH CHECK ADD  CONSTRAINT [FK_Etapas_Grs] FOREIGN KEY([IdGr])
REFERENCES [dbo].[Grs] ([Id])
GO
ALTER TABLE [dbo].[Etapas] CHECK CONSTRAINT [FK_Etapas_Grs]
GO
ALTER TABLE [dbo].[Etapas]  WITH CHECK ADD  CONSTRAINT [FK_Etapas_Zonas] FOREIGN KEY([IdZona])
REFERENCES [dbo].[Zonas] ([Id])
GO
ALTER TABLE [dbo].[Etapas] CHECK CONSTRAINT [FK_Etapas_Zonas]
GO
ALTER TABLE [dbo].[Ocupaciones]  WITH CHECK ADD  CONSTRAINT [FK_Ocupaciones_Albergues] FOREIGN KEY([IdAlbergue])
REFERENCES [dbo].[Albergues] ([Id])
GO
ALTER TABLE [dbo].[Ocupaciones] CHECK CONSTRAINT [FK_Ocupaciones_Albergues]
GO
ALTER TABLE [dbo].[Ocupaciones]  WITH CHECK ADD  CONSTRAINT [FK_Ocupaciones_Clientes] FOREIGN KEY([Dni])
REFERENCES [dbo].[Clientes] ([Dni])
GO
ALTER TABLE [dbo].[Ocupaciones] CHECK CONSTRAINT [FK_Ocupaciones_Clientes]
GO
