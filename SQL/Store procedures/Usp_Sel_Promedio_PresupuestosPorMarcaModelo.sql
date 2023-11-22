SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
--Promedio del Monto Total de Presupuestos por Marca/Modelo 
-- =============================================
ALTER PROCEDURE Usp_Sel_Promedio_PresupuestosPorMarcaModelo
AS
BEGIN
	SELECT Marca,Modelo,AVG(Total) as Promedio FROM Presupuesto p
	INNER JOIN Vehiculo v ON p.IdVehiculo = v.Id
	Group by v.Marca,v.Modelo
END
GO
