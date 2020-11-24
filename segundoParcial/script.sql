USE [Parcial]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 11/24/2020 7:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hamburguesa] [nvarchar](50) NOT NULL,
	[IdPedido] [int] NOT NULL,
	[NombreCliente] [nvarchar](50) NOT NULL,
	[DireccionCliente] [nvarchar](50) NOT NULL,
	[NumeroCliente] [int] NOT NULL
) ON [PRIMARY]
GO
