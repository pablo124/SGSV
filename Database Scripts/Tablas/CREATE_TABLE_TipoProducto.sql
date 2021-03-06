GO

/****** Object:  Table [dbo_sgsv].[TipoProducto]    Script Date: 24/08/2013 06:00:50 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.TipoProducto') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[TipoProducto]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[TipoProducto](
	[idTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL UNIQUE,
 CONSTRAINT [PK_Tipo_Producto] PRIMARY KEY CLUSTERED 
(
	[idTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


