USE [Base_Usuarios]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 24/10/2020 18:18:11 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 24/10/2020 18:18:11 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 24/10/2020 18:18:11 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermisosHistorico]    Script Date: 24/10/2020 18:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosHistorico](
	[id_phistorico] [int] IDENTITY(1,1) NOT NULL,
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[fecha] [date] NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_PermisosHistorico] PRIMARY KEY CLUSTERED 
(
	[id_phistorico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/10/2020 18:18:11 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosHistorico]    Script Date: 24/10/2020 18:18:11 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (1, N'Administrador', 0, N'persona encargada de la administracion')
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (2, N'Tester', 0, NULL)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (3, N'Desarrollador', 0, NULL)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado], [descripcion]) VALUES (4, N'Responsable de Reportes', 0, NULL)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 2, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 2, 3, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 8, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 9, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 10, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 11, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 12, 1, 0)
INSERT [dbo].[Permisos] ([fecha_alta], [id_formulario], [id_perfil], [borrado]) VALUES (CAST(N'2020-10-23T00:00:00' AS SmallDateTime), 12, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[PermisosHistorico] ON 

INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (154, 2, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (155, 11, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (156, 10, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (157, 8, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (158, 9, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (159, 12, 1, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (160, 2, 3, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (161, 12, 3, CAST(N'2020-10-23' AS Date), N'Conceder permiso')
INSERT [dbo].[PermisosHistorico] ([id_phistorico], [id_formulario], [id_perfil], [fecha], [descripcion]) VALUES (162, 10, 2, CAST(N'2020-02-25' AS Date), N'Prueba de fechas')
SET IDENTITY_INSERT [dbo].[PermisosHistorico] OFF
GO
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
GO
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
GO
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
ALTER TABLE [dbo].[PermisosHistorico]  WITH CHECK ADD  CONSTRAINT [FK__PermisosHistorico_Formulario] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[PermisosHistorico] CHECK CONSTRAINT [FK__PermisosHistorico_Formulario]
GO
ALTER TABLE [dbo].[PermisosHistorico]  WITH CHECK ADD  CONSTRAINT [FK__PermisosHistorico_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[PermisosHistorico] CHECK CONSTRAINT [FK__PermisosHistorico_Perfil]
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
