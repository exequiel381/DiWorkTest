USE [tallerMecanico]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Ins_Presupuesto]    Script Date: 21/11/2023 9:17:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Usp_Ins_Presupuesto]
	@pNombre varchar(10) = '',
	@pApellido varchar(10),
	@pEmail varchar(25)= '',
	@pMarca varchar(10)= '',
	@pModelo varchar(10)= '',
	@pPatente varchar(10)= '',
	@pEsAuto tinyint,
	@pTipo int = 0,
	@pCantPuertas int = 0,
	@pCilindrada decimal(18,2) = 0,
	@pTotal decimal(18,2),
	@pDesperfectos Desperfectos READONLY
AS
BEGIN

	DECLARE @ClienteID INT, @VehiculoID INT, @PresupuestoID INT,@DesperfectoID INT;
	DECLARE @Descripcion nchar(100);
    DECLARE @ManoDeObra decimal(18, 0);
    DECLARE @Tiempo int;
    DECLARE @Repuestos nchar(200);

    DECLARE @RepuestoTabla TABLE (IdRepuesto int);
    DECLARE @IdRepuesto int;

    DECLARE cursorDesperfectos CURSOR FOR
    SELECT Descripcion, ManoDeObra, Tiempo, Repuestos
    FROM @pDesperfectos;


	INSERT INTO Cliente (Nombre,Apellido,Email) values (@pNombre,@pApellido,@pEmail);
	SET @ClienteID = SCOPE_IDENTITY();

	IF @pEsAuto = 1
		BEGIN
			INSERT INTO Vehiculo (Marca,Modelo,Patente,Cilindrada,CantidadPuertas,TipoAutomovil,TipoVehiculo) values (@pMarca,@pModelo,@pPatente,@pCilindrada,@pCantPuertas,@pTipo,'Automovil');
			SET @VehiculoID = SCOPE_IDENTITY();
		END
	ELSE
		BEGIN 
			INSERT INTO Vehiculo (Marca,Modelo,Patente,Cilindrada,CantidadPuertas,TipoAutomovil,TipoVehiculo) values (@pMarca,@pModelo,@pPatente,@pCilindrada,@pCantPuertas,@pTipo,'Moto');
			SET @VehiculoID = SCOPE_IDENTITY();
		END
	
	INSERT INTO Presupuesto (Total,IdCliente,IdVehiculo) values (@pTotal,@ClienteID,@VehiculoID);
	SET @PresupuestoID = SCOPE_IDENTITY();

    OPEN cursorDesperfectos;
    FETCH NEXT FROM cursorDesperfectos INTO @Descripcion, @ManoDeObra, @Tiempo, @Repuestos;
    WHILE @@FETCH_STATUS = 0
    BEGIN
       
	   INSERT INTO Desperfecto (Descripcion,ManoDeObra,Tiempo,IdPresupuesto) values (@Descripcion, @ManoDeObra, @Tiempo,@PresupuestoID);
	   SET @DesperfectoID = SCOPE_IDENTITY();
	   DELETE FROM @RepuestoTabla

	    --TABLA REPUESTOS DE CADA DESPERFECTO
        INSERT INTO @RepuestoTabla (IdRepuesto)
        SELECT value
        FROM STRING_SPLIT(@Repuestos, ',');

        -- Armo el cursor
        DECLARE cursorRepuestos CURSOR FOR
        SELECT IdRepuesto FROM @RepuestoTabla;

        OPEN cursorRepuestos;
        FETCH NEXT FROM cursorRepuestos INTO @IdRepuesto;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            INSERT INTO DesperfectoRespuesto (IdDesperfecto,IdRepuesto) values (@DesperfectoID,@IdRepuesto)
            PRINT @IdRepuesto

            FETCH NEXT FROM cursorRepuestos INTO @IdRepuesto;
        END

        CLOSE cursorRepuestos;
        DEALLOCATE cursorRepuestos;


        FETCH NEXT FROM cursorDesperfectos INTO @Descripcion, @ManoDeObra, @Tiempo, @Repuestos;
    END

    CLOSE cursorDesperfectos;
    DEALLOCATE cursorDesperfectos;
END
