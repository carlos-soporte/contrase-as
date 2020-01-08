--lineas para borrar la base de datos.
USE MASTER
DROP DATABASE banco_contraseña

----------------------------------------------codigo para ejecutar-------------------------------------------
--se crea la base de datos
CREATE DATABASE banco_contraseña;
GO

--se pasa de la bd master a la bd creada
USE banco_contraseña;
GO

--se crea la tabla para usuarios habilitados
CREATE TABLE habilitados
(
usuario VARCHAR(25) NOT NULL,
contraseña VARCHAR(15) NOT NULL
)
GO

--se crea la clave primaria para evitar usuarios con el mismo nombre
ALTER TABLE habilitados
ADD PRIMARY KEY(usuario);
GO

--se crea la tabla que manejará el banco de hojas de vida
CREATE TABLE banco
(
id_registro INT IDENTITY NOT NULL,
entidad VARCHAR(20) NOT NULL,
descripcion VARCHAR(40) NOT NULL,
usuario VARCHAR(25) NOT NULL,
contraseña VARCHAR(20) NOT NULL
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
@contraseña VARCHAR(20)
AS
INSERT INTO habilitados(usuario,contraseña) VALUES (@usuario,@contraseña)
GO

CREATE PROCEDURE actualizar_habilitado
@usuario VARCHAR(25),
@contraseña VARCHAR(15)
AS
UPDATE habilitados SET usuario=@usuario,contraseña=@contraseña WHERE usuario='gloria'
GO

--se hace un procedimiento almacenado para añadir una entidad completa al banco de contraseñas
CREATE PROCEDURE insertar_banco
@entidad VARCHAR(20),
@descripcion VARCHAR(40),
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
INSERT INTO banco(entidad,descripcion,usuario,contraseña) VALUES (@entidad,@descripcion,@usuario,@contraseña)
GO

--procedimiento para validar el usuario habilitado para ingresar al sistema
CREATE PROCEDURE consultar_usuario
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
SELECT usuario,contraseña from habilitados where usuario=@usuario and contraseña=@contraseña
GO

--procedimiento para listar los campos a trabjajar
CREATE PROCEDURE listar_banco
AS
SELECT id_registro,entidad,descripcion,usuario,contraseña FROM banco
GO
--procedimiento almacenado para filtrar por entidad
CREATE PROCEDURE filtrar_banco
@entidad VARCHAR(20)
AS
SELECT * FROM banco WHERE entidad LIKE  '%'+ @entidad +'%'
GO

--procedimiento para actualizar contraseña del banco de contraseñas.
CREATE PROCEDURE editar_contraseña
@id_registro INT,
@contraseña VARCHAR(20)
AS
UPDATE banco SET contraseña=@contraseña WHERE id_registro=@id_registro
GO

--procedimiento para actualizar usuario del banco de contraseñas.
CREATE PROCEDURE editar_usuario
@id_registro INT,
@usuario VARCHAR(25)
AS
UPDATE banco SET usuario=@usuario WHERE id_registro=@id_registro
GO

--procedimiento para actualizar usuario y contraseña del banco de contraseñas.
CREATE PROCEDURE editar_duo
@id_registro INT,
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
UPDATE banco SET usuario=@usuario,contraseña=@contraseña WHERE id_registro=@id_registro
GO

--procedimiento para borrar un registro del banco de contraseñas.
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
EXEC insertar_banco 'buñuelera','negocio redondo','chaopapá','chao6876' 
EXEC insertar_banco 'suggarMom','regalo del 31','te_extrañamos','chao32145' 
EXEC insertar_banco 'suggarDaddy','regalo del 31','cr7','chao32145' 
EXEC insertar_banco 'Pascual bravo','acceso a la plataforma interactiva','pepe_grillo','chao32145' 
EXEC insertar_banco 'zandaly','chicas malas','pepe_grillo','chao32145' 
EXEC insertar_banco 'casa de messi','hack de la casa inteligente de messi','pepe_grillo','chao32145' 
EXEC insertar_banco 'cr7 tu papá','verdades que duelen','pepe_grillo','chao32145' 
EXEC insertar_banco 'fea del barrio','si no hay solomo, de todo como','pepe_grillo','chao32145' 
EXEC insertar_banco 'culito nuevo','te la creiste, solo seriedad','pepe_grillo','chao32145' 
EXEC insertar_banco 'vecina amable','digale que apague el equipo','pepe_grillo','chao32145' 
EXEC insertar_banco 'inventenflix','habia que colocar algo','pepe_grillo','chao32145' 
EXEC insertar_banco 'tunel del gato','si no sabe de tuneles, no opine','pepe_grillo','chao32145' 
