GO
/****** Object:  StoredProcedure [dbo_sgsv].[P_S_Localidad]    Script Date: 03/09/2013 07:45:33 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Martín Tissier>
-- Create date: <23/08/2013>
-- Description:	<Lectura de Localidades>
-- =============================================
ALTER Procedure [dbo_sgsv].[P_S_Localidad] 
 @idLocalidad int = NULL,
 @nombre varchar(100) = NULL
 AS

--Selecciono todas las localidades ordenadas por nombre
SELECT		idLocalidad,
			nombre
FROM		dbo_sgsv.Localidad
WHERE		idLocalidad = ISNULL(@idLocalidad, idLocalidad)
	AND		nombre LIKE ISNULL(@nombre, nombre) + '%'
ORDER BY	nombre


