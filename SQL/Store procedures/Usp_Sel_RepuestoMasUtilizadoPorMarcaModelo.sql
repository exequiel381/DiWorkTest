SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
--Repuesto más utilizado por Marca/Modelo en las reparaciones realizadas
--(Mostrar Descripción del Repuesto y cantidad de veces usado) 
-- =============================================
CREATE PROCEDURE Usp_Sel_RepuestoMasUtilizadoPorMarcaModelo
AS
BEGIN

	SELECT v.Marca as marca,v.Modelo as modelo,r.Nombre as repuesto,count(*) as CantUsado 
	FROM Repuesto r
	INNER JOIN DesperfectoRespuesto dr ON r.Id = dr.IdRepuesto
	INNER JOIN Desperfecto d ON dr.IdDesperfecto = d.Id
	INNER JOIN Presupuesto p ON p.Id = d.IdPresupuesto
	INNER JOIN Vehiculo v ON v.Id = p.IdVehiculo
	group by v.Marca,v.Modelo,r.Nombre	
	having (CONCAT(marca,modelo,count(*)) IN (
		SELECT CONCAT(marca,modelo,MAX(CantUsado))FROM (
			SELECT v.Marca as marca,v.Modelo as modelo,r.Nombre as repuesto,count(*) as CantUsado 
			FROM Repuesto r
			INNER JOIN DesperfectoRespuesto dr ON r.Id = dr.IdRepuesto
			INNER JOIN Desperfecto d ON dr.IdDesperfecto = d.Id
			INNER JOIN Presupuesto p ON p.Id = d.IdPresupuesto
			INNER JOIN Vehiculo v ON v.Id = p.IdVehiculo
			group by v.Marca,v.Modelo,r.Nombre
		) T
		group by marca,modelo
	))
	
END
GO


