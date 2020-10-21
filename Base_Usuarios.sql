USE [master]
GO
/****** Object:  Database [Base_Usuarios]    Script Date: 20/10/2020 22:38:52 ******/
CREATE DATABASE [Base_Usuarios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Base_Usuarios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Base_Usuarios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Base_Usuarios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Base_Usuarios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Base_Usuarios] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Base_Usuarios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Base_Usuarios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Base_Usuarios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Base_Usuarios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Base_Usuarios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Base_Usuarios] SET ARITHABORT OFF 
GO
ALTER DATABASE [Base_Usuarios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Base_Usuarios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Base_Usuarios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Base_Usuarios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Base_Usuarios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Base_Usuarios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Base_Usuarios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Base_Usuarios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Base_Usuarios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Base_Usuarios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Base_Usuarios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Base_Usuarios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Base_Usuarios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Base_Usuarios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Base_Usuarios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Base_Usuarios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Base_Usuarios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Base_Usuarios] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Base_Usuarios] SET  MULTI_USER 
GO
ALTER DATABASE [Base_Usuarios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Base_Usuarios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Base_Usuarios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Base_Usuarios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Base_Usuarios] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Base_Usuarios] SET QUERY_STORE = OFF
GO
USE [Base_Usuarios]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 20/10/2020 22:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 20/10/2020 22:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 20/10/2020 22:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[fecha_alta] [smalldatetime] NULL,
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/10/2020 22:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosHistorico]    Script Date: 20/10/2020 22:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosHistorico](
	[id_historico_usuario] [int] IDENTITY(1,1) NOT NULL,
	[fecha_historico] [smalldatetime] NULL,
	[titulo] [varchar](100) NULL,
	[descripcion] [varchar](150) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_HistoricoUsuarios] PRIMARY KEY CLUSTERED 
(
	[id_historico_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Formularios] ON 

INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (2, N'Agregar Nuevo Perfil', 0, N'creacion de un nuevo perfil')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (7, N'consultar listado usuarios', 1, N'consultar listado de usuarios')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (8, N'consultar perfiles', 0, N'listado de perfiles')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (9, N'consultar permisos', 0, N'listado de permisos')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (10, N'agregar nuevo usuario', 0, N'dar de alta un usuario')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (11, N'asignar permisos', 0, N'asignar permisos a perfiles')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (12, N'agregar nuevo formulario', 0, N'dar de alta un formulario')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (13, N'reporte de historico usuarios', 0, N'listado historico usuarios con filtro')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (14, N'estadistica perfil', 0, N'grafico de perfiles por usuario')
INSERT [dbo].[Formularios] ([id_formulario], [nombre], [borrado], [descripcion]) VALUES (15, N'historico de usuarios', 0, N'historico de usuarios')
SET IDENTITY_INSERT [dbo].[Formularios] OFF
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (1, N'Administrador', 0, N'persona encargada de la administracion')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (2, N'Tester', 0, NULL)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (3, N'Desarrollador', 0, NULL)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (4, N'Responsable de Reportes', 0, NULL)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-20T00:00:00' AS SmallDateTime), 2, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-20T00:00:00' AS SmallDateTime), 2, 2, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-20T00:00:00' AS SmallDateTime), 8, 2, 1)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-20T00:00:00' AS SmallDateTime), 9, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-20T00:00:00' AS SmallDateTime), 11, 1, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'12345', N'administrador@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'jazmin', N'12345', N'jazmin@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (3, 3, N'julian', N'1235julian', N'julian@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'maria', N'1837maria', N'maria@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 4, N'pedro', N'78910', N'pedroJuarez@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'enrique', N'5789enri', N'enrique@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 3, N'lucia', N'5693lucia', N'lucia@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, 3, N'Ana', N'1253ana', N'ana@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (9, 3, N'diego', N'89632die', N'diego@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (10, 2, N'leonardo', N'896321leo', N'leonardo@gmail.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (11, 4, N'natalia', N'96321nat', N'natalia@gmail.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (12, 2, N'juan', N'8965juan', N'juan@gmail.com', N'S', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET IDENTITY_INSERT [dbo].[UsuariosHistorico] ON 

INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 1, 1, N'administrador', N'12345', N'administrador@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 2, 2, N'jazmin', N'12345', N'jazmin@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (3, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 3, 3, N'julian', N'1235', N'julian@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 4, 4, N'maria', N'1837', N'maria@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 5, 4, N'pedro', N'78910', N'pedro@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 6, 3, N'enrique', N'5789', N'enrique@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 7, 3, N'lucia', N'5693', N'lucia@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 8, 4, N'Ana', N'1253ana', N'ana@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (9, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 9, 3, N'diego', N'89632die', N'diego@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (10, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 10, 2, N'leonardo', N'896321leo', N'leonardo@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (11, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 11, 4, N'natalia', N'96321nati', N'natalia@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (12, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Registro de Usuario', N'Primer alta de Usuario', 12, 2, N'juan', N'8965juan', N'juan@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (13, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Password,', 3, 3, N'julian', N'1235julian', N'julian@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (14, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Password,', 6, 3, N'enrique', N'5789enri', N'enrique@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (15, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Password,', 7, 3, N'lucia', N'5693lucia', N'lucia@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (16, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Password,', 11, 4, N'natalia', N'96321nat', N'natalia@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (17, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Password,', 4, 4, N'maria', N'1837maria', N'maria@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (18, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Email,', 5, 4, N'pedro', N'78910', N'pedroJuarez@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (19, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Eliminacion de Usuario', N'Eliminacion del usuario con id = 11', 11, 4, N'natalia', N'96321nat', N'natalia@gmail.com', N'S', 1)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (20, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Eliminacion de Usuario', N'Eliminacion del usuario con id = 10', 10, 2, N'leonardo', N'896321leo', N'leonardo@gmail.com', N'S', 1)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (21, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Perfil,', 8, 3, N'Ana', N'1253ana', N'ana@gmail.com', N'S', 0)
INSERT [dbo].[UsuariosHistorico] ([id_historico_usuario], [fecha_historico], [titulo], [descripcion], [id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (22, CAST(N'2020-10-20T00:00:00' AS SmallDateTime), N'Modificacion de Usuario', N'Se Modifico el: Perfil,', 4, 3, N'maria', N'1837maria', N'maria@gmail.com', N'S', 0)
SET IDENTITY_INSERT [dbo].[UsuariosHistorico] OFF
ALTER TABLE [dbo].[Formularios] ADD  CONSTRAINT [DF_Formularios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosHistorico]  WITH CHECK ADD  CONSTRAINT [FK_Historico_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[UsuariosHistorico] CHECK CONSTRAINT [FK_Historico_Usuario]
GO
ALTER TABLE [dbo].[UsuariosHistorico]  WITH CHECK ADD  CONSTRAINT [FK_Perfil_Historico_Usuarios] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[UsuariosHistorico] CHECK CONSTRAINT [FK_Perfil_Historico_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [Base_Usuarios] SET  READ_WRITE 
GO
