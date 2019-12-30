USE MASTER
DROP DATABASE banco_contraseña
--se crea la base de datos
CREATE DATABASE banco_contraseña;
GO


--se pasa de la bd master a la bd creada
USE banco_contraseña;
GO

--se crea la tabla para usuarios habilitados
CREATE TABLE habilitados
(
usuario VARCHAR(20) NOT NULL,
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
entidad VARCHAR(25) NOT NULL,
descripcion VARCHAR(50) NOT NULL,
usuario VARCHAR(30) NOT NULL,
contraseña VARCHAR(20) NOT NULL
)
GO

ALTER TABLE banco
ADD PRIMARY KEY(id_registro)
GO

--se crea un procedimiento almacenado para insertar usuarios habilitados
CREATE PROCEDURE insertar_habilitado
@usuario VARCHAR(20),
@contraseña VARCHAR(15)
AS
INSERT INTO habilitados(usuario,contraseña) VALUES (@usuario,@contraseña)
GO

--se hacen dos registros de usuarios habilitados despues de ejecutado el procedimiento
EXEC insertar_habilitado 'carlos','1234'
EXEC insertar_habilitado 'duban','4321'
GO

--se hace un procedimiento almacenado para añadir una entidad completa al banco de contraseñas
CREATE PROCEDURE insertar_banco
@entidad VARCHAR(20),
@descripcion VARCHAR(50),
@usuario VARCHAR(25),
@contraseña VARCHAR(15)
AS
INSERT INTO banco(entidad,descripcion,usuario,contraseña) VALUES (@entidad,@descripcion,@usuario,@contraseña)
GO

--se hacen 5 registros con fines practicos.
EXEC insertar_banco 'bancolombia','retiro de dinero','te_robamos','chao1234' 
EXEC insertar_banco 'bancolombia','procesamiento de documentos','te_pegamos','chao4321' 
EXEC insertar_banco 'natillera','natillera del abuelito','te_queremos','chao1r676' 
EXEC insertar_banco 'buñuelera','negocio redondo','chaopapá','chao6876' 
EXEC insertar_banco 'suggarMom','regalo del 31','te_robamos','chao32145' 
GO
--procedimiento para validar el usuario habilitado para ingresar al sistema
CREATE PROCEDURE consultar_usuario
@usuario VARCHAR(20),
@contraseña VARCHAR(15)
AS
SELECT usuario,contraseña from habilitados where usuario=@usuario and contraseña=@contraseña

insert into habilitados(usuario,contraseña) values ('alejandra','12345')

--procedimiento para listar los campos a trabjajar
CREATE PROCEDURE listar_banco
AS
SELECT * FROM banco

--procedimiento almacenado para filtrar por entidad
CREATE PROCEDURE filtrar_banco
@entidad VARCHAR(25)
AS
SELECT * FROM banco WHERE entidad LIKE  '%'+ @entidad +'%'

