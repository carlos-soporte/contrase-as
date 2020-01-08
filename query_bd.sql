--lineas para borrar la base de datos.
USE MASTER
DROP DATABASE banco_contrase�a

----------------------------------------------codigo para ejecutar-------------------------------------------
--se crea la base de datos
CREATE DATABASE banco_contrase�a;
GO

--se pasa de la bd master a la bd creada
USE banco_contrase�a;
GO

--se crea la tabla para usuarios habilitados
CREATE TABLE habilitados
(
usuario VARCHAR(25) NOT NULL,
contrase�a VARCHAR(15) NOT NULL
)
GO

--se crea la clave primaria para evitar usuarios con el mismo nombre
ALTER TABLE habilitados
ADD PRIMARY KEY(usuario);
GO

--se crea la tabla que manejar� el banco de hojas de vida
CREATE TABLE banco
(
id_registro INT IDENTITY NOT NULL,
entidad VARCHAR(20) NOT NULL,
descripcion VARCHAR(40) NOT NULL,
usuario VARCHAR(25) NOT NULL,
contrase�a VARCHAR(20) NOT NULL
)
GO

--se asigna la clave primaria para 
ALTER TABLE banco
ADD PRIMARY KEY(id_registro)
GO

-------------------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------------------------------
--se crea un procedimiento almacenado para insertar usuarios habilitados
CREATE PROCEDURE insertar_habilitado
@usuario VARCHAR(25),
@contrase�a VARCHAR(20)
AS
INSERT INTO habilitados(usuario,contrase�a) VALUES (@usuario,@contrase�a)
GO

CREATE PROCEDURE actualizar_habilitado
@usuario VARCHAR(25),
@contrase�a VARCHAR(15)
AS
UPDATE habilitados SET usuario=@usuario,contrase�a=@contrase�a WHERE usuario='gloria'
GO

--se hace un procedimiento almacenado para a�adir una entidad completa al banco de contrase�as
CREATE PROCEDURE insertar_banco
@entidad VARCHAR(20),
@descripcion VARCHAR(40),
@usuario VARCHAR(25),
@contrase�a VARCHAR(20)
AS
INSERT INTO banco(entidad,descripcion,usuario,contrase�a) VALUES (@entidad,@descripcion,@usuario,@contrase�a)
GO

--procedimiento para validar el usuario habilitado para ingresar al sistema
CREATE PROCEDURE consultar_usuario
@usuario VARCHAR(25),
@contrase�a VARCHAR(20)
AS
SELECT usuario,contrase�a from habilitados where usuario=@usuario and contrase�a=@contrase�a
GO

--procedimiento para listar los campos a trabjajar
CREATE PROCEDURE listar_banco
AS
SELECT id_registro,entidad,descripcion,usuario,contrase�a FROM banco
GO
--procedimiento almacenado para filtrar por entidad
CREATE PROCEDURE filtrar_banco
@entidad VARCHAR(20)
AS
SELECT * FROM banco WHERE entidad LIKE  '%'+ @entidad +'%'
GO

--procedimiento para actualizar contrase�a del banco de contrase�as.
CREATE PROCEDURE editar_contrase�a
@id_registro INT,
@contrase�a VARCHAR(20)
AS
UPDATE banco SET contrase�a=@contrase�a WHERE id_registro=@id_registro
GO

--procedimiento para actualizar usuario del banco de contrase�as.
CREATE PROCEDURE editar_usuario
@id_registro INT,
@usuario VARCHAR(25)
AS
UPDATE banco SET usuario=@usuario WHERE id_registro=@id_registro
GO

--procedimiento para actualizar usuario y contrase�a del banco de contrase�as.
CREATE PROCEDURE editar_duo
@id_registro INT,
@usuario VARCHAR(25),
@contrase�a VARCHAR(20)
AS
UPDATE banco SET usuario=@usuario,contrase�a=@contrase�a WHERE id_registro=@id_registro
GO

--procedimiento para borrar un registro del banco de contrase�as.
CREATE PROCEDURE eliminar_banco
@id_registro INT
AS
DELETE FROM banco WHERE id_registro=@id_registro
GO



-----------------------------------REGISTROS-----------------------------------------------
--se hacen dos registros de usuarios habilitados despues de ejecutado el procedimiento
EXEC insertar_habilitado 'gloria','1234'
GO

SELECT * FROM habilitados

--se hacen 15 registros con fines practicos.
EXEC insertar_banco 'bancolombia','retiro de dinero','te_amamos','chao1234' 
EXEC insertar_banco 'bancolombia','procesamiento de documentos','te_pegamos','chao4321' 
EXEC insertar_banco 'natillera','natillera del abuelito','te_queremos','chao1r676' 
EXEC insertar_banco 'bu�uelera','negocio redondo','chaopap�','chao6876' 
EXEC insertar_banco 'suggarMom','regalo del 31','te_extra�amos','chao32145' 
EXEC insertar_banco 'suggarDaddy','regalo del 31','cr7','chao32145' 
EXEC insertar_banco 'Pascual bravo','acceso a la plataforma interactiva','pepe_grillo','chao32145' 
EXEC insertar_banco 'zandaly','chicas malas','pepe_grillo','chao32145' 
EXEC insertar_banco 'casa de messi','hack de la casa inteligente de messi','pepe_grillo','chao32145' 
EXEC insertar_banco 'cr7 tu pap�','verdades que duelen','pepe_grillo','chao32145' 
EXEC insertar_banco 'fea del barrio','si no hay solomo, de todo como','pepe_grillo','chao32145' 
EXEC insertar_banco 'culito nuevo','te la creiste, solo seriedad','pepe_grillo','chao32145' 
EXEC insertar_banco 'vecina amable','digale que apague el equipo','pepe_grillo','chao32145' 
EXEC insertar_banco 'inventenflix','habia que colocar algo','pepe_grillo','chao32145' 
EXEC insertar_banco 'tunel del gato','si no sabe de tuneles, no opine','pepe_grillo','chao32145' 
