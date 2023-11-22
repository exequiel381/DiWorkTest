
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Sumatoria del Monto Total de Presupuestos para Autos y para Motos
-- ================================================

CREATE PROCEDURE Usp_Sel_Sum_AutoMoto
AS
BEGIN
	SELECT v.TipoVehiculo,SUM(p.Total) as TotalPorVehiculo FROM Vehiculo v
	INNER JOIN Presupuesto p ON v.Id = p.IdVehiculo
	group by v.TipoVehiculo
END
GO
