USE [master]
GO
/****** Object:  Database [banco_contraseña]    Script Date: 07/01/2020 15:56:34 ******/
CREATE DATABASE [banco_contraseña]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'banco_contraseña', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\banco_contraseña.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'banco_contraseña_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\banco_contraseña_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [banco_contraseña] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [banco_contraseña].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [banco_contraseña] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [banco_contraseña] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [banco_contraseña] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [banco_contraseña] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [banco_contraseña] SET ARITHABORT OFF 
GO
ALTER DATABASE [banco_contraseña] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [banco_contraseña] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [banco_contraseña] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [banco_contraseña] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [banco_contraseña] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [banco_contraseña] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [banco_contraseña] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [banco_contraseña] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [banco_contraseña] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [banco_contraseña] SET  ENABLE_BROKER 
GO
ALTER DATABASE [banco_contraseña] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [banco_contraseña] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [banco_contraseña] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [banco_contraseña] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [banco_contraseña] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [banco_contraseña] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [banco_contraseña] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [banco_contraseña] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [banco_contraseña] SET  MULTI_USER 
GO
ALTER DATABASE [banco_contraseña] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [banco_contraseña] SET DB_CHAINING OFF 
GO
ALTER DATABASE [banco_contraseña] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [banco_contraseña] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [banco_contraseña] SET DELAYED_DURABILITY = DISABLED 
GO
USE [banco_contraseña]
GO
/****** Object:  Table [dbo].[banco]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[banco](
	[id_registro] [int] IDENTITY(1,1) NOT NULL,
	[entidad] [varchar](20) NOT NULL,
	[descripcion] [varchar](40) NOT NULL,
	[usuario] [varchar](25) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[habilitados]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[habilitados](
	[usuario] [varchar](25) NOT NULL,
	[contraseña] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[actualizar_habilitado]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[actualizar_habilitado]
@usuario VARCHAR(25),
@contraseña VARCHAR(15)
AS
UPDATE habilitados SET usuario=@usuario,contraseña=@contraseña WHERE usuario='gloria'

GO
/****** Object:  StoredProcedure [dbo].[consultar_usuario]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para validar el usuario habilitado para ingresar al sistema
CREATE PROCEDURE [dbo].[consultar_usuario]
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
SELECT usuario,contraseña from habilitados where usuario=@usuario and contraseña=@contraseña

GO
/****** Object:  StoredProcedure [dbo].[editar_contraseña]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para actualizar contraseña del banco de contraseñas.
CREATE PROCEDURE [dbo].[editar_contraseña]
@id_registro INT,
@contraseña VARCHAR(20)
AS
UPDATE banco SET contraseña=@contraseña WHERE id_registro=@id_registro

GO
/****** Object:  StoredProcedure [dbo].[editar_duo]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para actualizar usuario y contraseña del banco de contraseñas.
CREATE PROCEDURE [dbo].[editar_duo]
@id_registro INT,
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
UPDATE banco SET usuario=@usuario,contraseña=@contraseña WHERE id_registro=@id_registro

GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para actualizar usuario del banco de contraseñas.
CREATE PROCEDURE [dbo].[editar_usuario]
@id_registro INT,
@usuario VARCHAR(25)
AS
UPDATE banco SET usuario=@usuario WHERE id_registro=@id_registro

GO
/****** Object:  StoredProcedure [dbo].[eliminar_banco]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para borrar un registro del banco de contraseñas.
CREATE PROCEDURE [dbo].[eliminar_banco]
@id_registro INT
AS
DELETE FROM banco WHERE id_registro=@id_registro

GO
/****** Object:  StoredProcedure [dbo].[filtrar_banco]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento almacenado para filtrar por entidad
CREATE PROCEDURE [dbo].[filtrar_banco]
@entidad VARCHAR(20)
AS
SELECT * FROM banco WHERE entidad LIKE  '%'+ @entidad +'%'

GO
/****** Object:  StoredProcedure [dbo].[insertar_banco]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--se hace un procedimiento almacenado para añadir una entidad completa al banco de contraseñas
CREATE PROCEDURE [dbo].[insertar_banco]
@entidad VARCHAR(20),
@descripcion VARCHAR(40),
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
INSERT INTO banco(entidad,descripcion,usuario,contraseña) VALUES (@entidad,@descripcion,@usuario,@contraseña)

GO
/****** Object:  StoredProcedure [dbo].[insertar_habilitado]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------------------------------
--se crea un procedimiento almacenado para insertar usuarios habilitados
CREATE PROCEDURE [dbo].[insertar_habilitado]
@usuario VARCHAR(25),
@contraseña VARCHAR(20)
AS
INSERT INTO habilitados(usuario,contraseña) VALUES (@usuario,@contraseña)

GO
/****** Object:  StoredProcedure [dbo].[listar_banco]    Script Date: 07/01/2020 15:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--procedimiento para listar los campos a trabjajar
CREATE PROCEDURE [dbo].[listar_banco]
AS
SELECT id_registro,entidad,descripcion,usuario,contraseña FROM banco

GO
USE [master]
GO
ALTER DATABASE [banco_contraseña] SET  READ_WRITE 
GO
