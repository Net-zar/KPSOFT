

--CREATE PROC USUARIO_LOGIN
--@USUARIO VARCHAR(50),
--@CONTRASEŅA VARCHAR(10)
--AS
--SELECT U.IDUSUARIO,U.ROL_ID, R.ROL_DESCRIP AS ROL, U.USUARIO_NOMBRE
--FROM USUARIO U INNER JOIN ROL R ON U.ROL_ID=R.IDROL
--WHERE U.USUARIO_NOMBRE=@USUARIO AND U.CONTRASEŅA=@CONTRASEŅA


--CREATE PROC ROL_LISTAR
--AS
--SELECT IDROL, ROL_DESCRIP FROM ROL
--WHERE ESTADO=1

--CREATE PROC USUARIO_BUSCAR
--@VALOR VARCHAR(50)
--AS
--SELECT U.IDUSUARIO AS ID, U.ROL_ID,U.USUARIO_NOMBRE AS USUARIO ,R.ROL_DESCRIP AS ROL, U.ESTADO AS ESTADO
--FROM USUARIO U INNER JOIN ROL R ON U.ROL_ID=R.IDROL
--WHERE U.USUARIO_NOMBRE LIKE '%'+@VALOR+'%'
--ORDER BY U.USUARIO_NOMBRE ASC

--CREATE PROC USUARIO_INSERTAR
--@IDROL INT,
--@USUARIO_NOMBRE VARCHAR(50),
--@CONTRASEŅA VARCHAR(50)

--AS

--INSERT INTO USUARIO(ROL_ID,USUARIO_NOMBRE,CONTRASEŅA)
--VALUES (@IDROL,@USUARIO_NOMBRE,HASHBYTES('SHA2_256',@CONTRASEŅA))

--alter PROC USUARIO_ACTUALIZAR
--@IDUSUARIO INT,
--@IDROL INT,
--@USUARIO_NOMBRE VARCHAR(50),
--@CONTRASEŅA VARCHAR(50)
--AS
--IF @CONTRASEŅA<>''
--UPDATE USUARIO SET ROL_ID=@IDROL, USUARIO_NOMBRE=@USUARIO_NOMBRE, CONTRASEŅA=HASHBYTES('SHA_256',@CONTRASEŅA)
--WHERE IDUSUARIO=@IDUSUARIO;
--ELSE 
--UPDATE USUARIO SET ROL_ID=@IDROL, USUARIO_NOMBRE=@USUARIO_NOMBRE
--where IDUSUARIO=@IDUSUARIO

--CREATE PROC USUARIO_ELIMINAR
--@IDUSUARIO INT
--AS 
--DELETE FROM USUARIO WHERE IDUSUARIO=@IDUSUARIO

--CREATE PROC USUARIO_DESACTIVAR
--@IDUSUARIO INT
--AS 
--UPDATE USUARIO SET ESTADO=0
--WHERE IDUSUARIO=@IDUSUARIO

--CREATE PROC USUARIO_ACTIVAR
--@IDUSUARIO INT
--AS 
--UPDATE USUARIO SET ESTADO=1
--WHERE IDUSUARIO=@IDUSUARIO

--CREATE PROC USUARIO_EXISTE
--@VALOR VARCHAR(100),
--@EXISTE BIT OUTPUT
--AS
--	IF EXISTS (SELECT USUARIO_NOMBRE FROM USUARIO WHERE USUARIO_NOMBRE =LTRIM(RTRIM(@VALOR)))
--	BEGIN
--	SET @EXISTE=1
--	END
--	ELSE
--	BEGIN
--	SET @EXISTE=0
--	END




