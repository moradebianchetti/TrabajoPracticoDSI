USE [Museo]
GO
/****** Object:  Table [dbo].[Cambio_Estado]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cambio_Estado](
	[fechaHoraFin] [datetime] NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[numeroReserva] [int] NOT NULL,
	[idEstado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Exposicion]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Exposicion](
	[lugarAsignado] [varchar](50) NOT NULL,
	[idObra] [int] NOT NULL,
	[idExposicion] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Exposicion] PRIMARY KEY CLUSTERED 
(
	[lugarAsignado] ASC,
	[idObra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[DNI] [int] NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idCargo] [int] NOT NULL,
	[idSede] [int] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[fechaVenta] [date] NOT NULL,
	[horaVenta] [time](7) NOT NULL,
	[monto] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[idSede] [int] NOT NULL,
	[idTipoEntrada] [int] NOT NULL,
	[idTipoVisita] [int] NOT NULL,
	[fechaInicioVigencia] [date] NOT NULL,
 CONSTRAINT [PK_Entrada] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ambito] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exposicion]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exposicion](
	[fechaFin] [date] NULL,
	[fechaInicio] [date] NOT NULL,
	[id] [int] NOT NULL,
	[idTipo] [int] NOT NULL,
	[idPublicoDestino] [varchar](50) NOT NULL,
	[idSede] [int] NOT NULL,
 CONSTRAINT [PK_Exposicion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obra]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obra](
	[duracionExtendida] [int] NOT NULL,
	[duracionResumida] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Obra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publico_Destino]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publico_Destino](
	[caracteristicas] [varchar](100) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Publico_Destino] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[fechaCreacion] [date] NULL,
	[horaInicioReal] [time](7) NOT NULL,
	[horaFinReal] [time](7) NULL,
	[fechaHoraReserva] [datetime] NULL,
	[cantidadAlumnosConfirmados] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[idSede] [int] NOT NULL,
	[duracionEstimada] [int] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[cantidadMaxVisitantes] [int] NOT NULL,
	[cantidadMaxPorGuia] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[montoBase] [int] NOT NULL,
 CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[usuario] [varchar](50) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NULL,
	[horaInicio] [time](7) NOT NULL,
	[horaFin] [time](7) NULL,
 CONSTRAINT [PK_Sesion_1] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC,
	[fechaInicio] ASC,
	[horaInicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifa]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifa](
	[fechaFinVigencia] [date] NULL,
	[fechaInicioVigencia] [date] NOT NULL,
	[monto] [int] NOT NULL,
	[montoAdicionalGuia] [int] NOT NULL,
	[idTipoEntrada] [int] NOT NULL,
	[idTipoVisita] [int] NOT NULL,
	[idSede] [int] NOT NULL,
 CONSTRAINT [PK_Tarifa_1] PRIMARY KEY CLUSTERED 
(
	[fechaInicioVigencia] ASC,
	[idTipoEntrada] ASC,
	[idTipoVisita] ASC,
	[idSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Entrada]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Entrada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[porcentaje] [int] NOT NULL,
 CONSTRAINT [PK_Tipo_Entrada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Exposicion]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Exposicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Exposicion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Visita]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Visita](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[porcentaje] [int] NOT NULL,
 CONSTRAINT [PK_Tipo_Visita] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 29/06/2021 10:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nombre] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[DNIEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cargo] ON 
GO
INSERT [dbo].[Cargo] ([id], [nombre]) VALUES (1, N'Guía')
GO
SET IDENTITY_INSERT [dbo].[Cargo] OFF
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 1| Sala 1', 10, 3)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 1| Sala 5', 1, 1)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 1| Sala 5', 2, 1)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 1| Sala 5', 3, 1)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 2| Sala 2', 4, 2)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 2| Sala 2', 6, 2)
GO
INSERT [dbo].[Detalle_Exposicion] ([lugarAsignado], [idObra], [idExposicion]) VALUES (N'Planta 2| Sala 2', 8, 2)
GO
INSERT [dbo].[Empleado] ([DNI], [apellido], [nombre], [idCargo], [idSede]) VALUES (30000000, N'Agustin', N'Viale', 1, 1)
GO
INSERT [dbo].[Empleado] ([DNI], [apellido], [nombre], [idCargo], [idSede]) VALUES (35000000, N'Miguel', N'Sanchez', 1, 1)
GO
INSERT [dbo].[Empleado] ([DNI], [apellido], [nombre], [idCargo], [idSede]) VALUES (38000000, N'Juan', N'Peez', 1, 1)
GO
INSERT [dbo].[Empleado] ([DNI], [apellido], [nombre], [idCargo], [idSede]) VALUES (40000000, N'Roberto', N'Gonzales', 1, 1)
GO
INSERT [dbo].[Empleado] ([DNI], [apellido], [nombre], [idCargo], [idSede]) VALUES (41000000, N'Malena', N'Burgos', 1, 1)
GO
INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:44:43' AS Time), 100, 1, 1, 1, 1, CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:46:28' AS Time), 100, 2, 1, 1, 1, CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:54:16' AS Time), 100, 3, 1, 1, 1, CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'19:17:30' AS Time), 100, 4, 1, 2, 1, CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'19:26:30' AS Time), 100, 5, 1, 1, 1, CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Exposicion] ([fechaFin], [fechaInicio], [id], [idTipo], [idPublicoDestino], [idSede]) VALUES (CAST(N'2021-07-02' AS Date), CAST(N'2021-06-28' AS Date), 1, 2, N'Niños', 1)
GO
INSERT [dbo].[Exposicion] ([fechaFin], [fechaInicio], [id], [idTipo], [idPublicoDestino], [idSede]) VALUES (CAST(N'2021-10-02' AS Date), CAST(N'2021-06-28' AS Date), 2, 1, N'Estudiantes de arte', 1)
GO
INSERT [dbo].[Exposicion] ([fechaFin], [fechaInicio], [id], [idTipo], [idPublicoDestino], [idSede]) VALUES (CAST(N'2021-04-24' AS Date), CAST(N'2020-11-15' AS Date), 3, 1, N'Público general', 1)
GO
SET IDENTITY_INSERT [dbo].[Obra] ON 
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (5, 2, 1)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 1, 2)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (5, 2, 3)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 1, 4)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (5, 2, 5)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 2, 6)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 1, 7)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (3, 1, 8)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (5, 2, 9)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 1, 10)
GO
INSERT [dbo].[Obra] ([duracionExtendida], [duracionResumida], [id]) VALUES (4, 1, 11)
GO
SET IDENTITY_INSERT [dbo].[Obra] OFF
GO
INSERT [dbo].[Publico_Destino] ([caracteristicas], [nombre]) VALUES (N'1', N'Estudiantes de arte')
GO
INSERT [dbo].[Publico_Destino] ([caracteristicas], [nombre]) VALUES (N'1', N'Jubilados')
GO
INSERT [dbo].[Publico_Destino] ([caracteristicas], [nombre]) VALUES (N'1', N'Niños')
GO
INSERT [dbo].[Publico_Destino] ([caracteristicas], [nombre]) VALUES (N'1', N'Público general')
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'2021-06-27' AS Date), CAST(N'00:44:13' AS Time), CAST(N'23:43:26' AS Time), CAST(N'2017-09-22T22:40:00.000' AS DateTime), 1, 200, 5, 3600)
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'2021-06-27' AS Date), CAST(N'00:44:13' AS Time), CAST(N'23:43:26' AS Time), CAST(N'2021-06-27T22:40:00.000' AS DateTime), 1, 220, 5, 3600)
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'2021-06-27' AS Date), CAST(N'00:44:13' AS Time), CAST(N'23:43:26' AS Time), CAST(N'2021-06-27T22:40:00.000' AS DateTime), 80, 221, 1, 3600)
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'2021-06-27' AS Date), CAST(N'13:30:13' AS Time), CAST(N'14:25:26' AS Time), CAST(N'2021-06-28T13:30:00.000' AS DateTime), 80, 222, 1, 7200)
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'2021-06-20' AS Date), CAST(N'13:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'2021-06-24T00:00:00.000' AS DateTime), 40, 544, 1, 3)
GO
INSERT [dbo].[Reserva] ([fechaCreacion], [horaInicioReal], [horaFinReal], [fechaHoraReserva], [cantidadAlumnosConfirmados], [numero], [idSede], [duracionEstimada]) VALUES (CAST(N'1995-09-23' AS Date), CAST(N'00:44:13' AS Time), CAST(N'23:43:26' AS Time), CAST(N'2017-09-22T00:00:00.000' AS DateTime), 5, 1001, 1, 5)
GO
SET IDENTITY_INSERT [dbo].[Sede] ON 
GO
INSERT [dbo].[Sede] ([cantidadMaxVisitantes], [cantidadMaxPorGuia], [nombre], [id], [montoBase]) VALUES (100, 10, N'Sede Provincial de Bellas Artes "Emilio Caraffa"', 1, 100)
GO
INSERT [dbo].[Sede] ([cantidadMaxVisitantes], [cantidadMaxPorGuia], [nombre], [id], [montoBase]) VALUES (120, 15, N'Sede Superior de Bellas Artes "Evita" | P.Ferreyra', 2, 150)
GO
INSERT [dbo].[Sede] ([cantidadMaxVisitantes], [cantidadMaxPorGuia], [nombre], [id], [montoBase]) VALUES (140, 10, N'Sede PROVINCIAL DE FOTOGRAFÍA PALACIO DIONISI', 3, 200)
GO
INSERT [dbo].[Sede] ([cantidadMaxVisitantes], [cantidadMaxPorGuia], [nombre], [id], [montoBase]) VALUES (160, 15, N'Sede Histórico Provincial Marqués de Sobremonte', 4, 300)
GO
INSERT [dbo].[Sede] ([cantidadMaxVisitantes], [cantidadMaxPorGuia], [nombre], [id], [montoBase]) VALUES (150, 10, N'Sede Provincial de Ciencias Naturales, UI', 5, 150)
GO
SET IDENTITY_INSERT [dbo].[Sede] OFF
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:19:34' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:20:24' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:26:09' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:27:59' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:31:09' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:32:43' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:33:29' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:36:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:37:55' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:38:46' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'07:40:23' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:41:57' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:42:25' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:42:41' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:45:00' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:46:09' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:47:27' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:51:08' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:51:47' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'08:59:27' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:03:55' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:05:13' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:06:07' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:18:44' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:23:23' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:46:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:48:59' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'09:50:20' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:42:45' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:44:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:45:28' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:52:49' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:53:14' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'10:54:01' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-27' AS Date), NULL, CAST(N'11:01:15' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:05:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:10:13' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:14:30' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:17:45' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:20:10' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:27:54' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:30:42' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:34:37' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:35:43' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:37:07' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:38:27' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:39:41' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:40:26' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:42:37' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:44:15' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:47:06' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:48:33' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:50:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:51:22' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:53:04' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:54:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:55:32' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:57:39' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:58:10' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:58:35' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:58:56' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'01:59:19' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:00:02' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:00:30' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:03:01' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:03:44' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:06:16' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:06:34' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:08:22' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:09:16' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:10:30' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:11:55' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:13:01' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:13:50' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:14:53' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:16:33' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:18:22' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'02:18:46' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'04:33:28' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'04:38:52' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'04:56:06' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'04:59:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:12:31' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:19:25' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:20:29' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:22:02' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:33:52' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:34:31' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:35:33' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:46:16' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:56:01' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:57:06' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:57:54' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'05:58:15' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:01:12' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:04:14' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:08:24' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:11:37' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:14:50' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:22:11' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:37:38' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:39:54' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:44:37' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:46:21' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'06:54:06' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:00:25' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:02:02' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:05:36' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:17:07' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:21:15' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:21:45' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:22:57' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:23:57' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:26:23' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:27:49' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'07:48:23' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:03:07' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:09:36' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:16:36' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:19:03' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:24:00' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:24:48' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:33:04' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:33:47' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:36:15' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:38:08' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:39:04' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:40:46' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:42:17' AS Time), NULL)
GO
INSERT [dbo].[Sesion] ([usuario], [fechaInicio], [fechaFin], [horaInicio], [horaFin]) VALUES (N'1', CAST(N'2021-06-28' AS Date), NULL, CAST(N'12:44:30' AS Time), NULL)
GO
INSERT [dbo].[Tarifa] ([fechaFinVigencia], [fechaInicioVigencia], [monto], [montoAdicionalGuia], [idTipoEntrada], [idTipoVisita], [idSede]) VALUES (NULL, CAST(N'2021-06-27' AS Date), 110, 50, 1, 1, 1)
GO
INSERT [dbo].[Tarifa] ([fechaFinVigencia], [fechaInicioVigencia], [monto], [montoAdicionalGuia], [idTipoEntrada], [idTipoVisita], [idSede]) VALUES (NULL, CAST(N'2021-06-27' AS Date), 108, 50, 1, 2, 1)
GO
INSERT [dbo].[Tarifa] ([fechaFinVigencia], [fechaInicioVigencia], [monto], [montoAdicionalGuia], [idTipoEntrada], [idTipoVisita], [idSede]) VALUES (NULL, CAST(N'2021-06-27' AS Date), 112, 50, 2, 1, 1)
GO
INSERT [dbo].[Tarifa] ([fechaFinVigencia], [fechaInicioVigencia], [monto], [montoAdicionalGuia], [idTipoEntrada], [idTipoVisita], [idSede]) VALUES (NULL, CAST(N'2021-06-27' AS Date), 110, 50, 2, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Entrada] ON 
GO
INSERT [dbo].[Tipo_Entrada] ([id], [nombre], [porcentaje]) VALUES (1, N'General', 0)
GO
INSERT [dbo].[Tipo_Entrada] ([id], [nombre], [porcentaje]) VALUES (2, N'No General', 0)
GO
INSERT [dbo].[Tipo_Entrada] ([id], [nombre], [porcentaje]) VALUES (3, N'Menores', 0)
GO
INSERT [dbo].[Tipo_Entrada] ([id], [nombre], [porcentaje]) VALUES (4, N'Estudiantes', 0)
GO
INSERT [dbo].[Tipo_Entrada] ([id], [nombre], [porcentaje]) VALUES (5, N'Jubilados', 0)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Entrada] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Exposicion] ON 
GO
INSERT [dbo].[Tipo_Exposicion] ([id], [nombre]) VALUES (1, N'Permanente')
GO
INSERT [dbo].[Tipo_Exposicion] ([id], [nombre]) VALUES (2, N'Temporal')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Exposicion] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Visita] ON 
GO
INSERT [dbo].[Tipo_Visita] ([id], [nombre], [porcentaje]) VALUES (1, N'Completa', 0)
GO
INSERT [dbo].[Tipo_Visita] ([id], [nombre], [porcentaje]) VALUES (2, N'Por exposición', 0)
GO
SET IDENTITY_INSERT [dbo].[Tipo_Visita] OFF
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña], [DNIEmpleado]) VALUES (N'1', N'1', 30000000)
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña], [DNIEmpleado]) VALUES (N'jmiguelsan', N'1111', 35000000)
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña], [DNIEmpleado]) VALUES (N'juanperez', N'1111', 38000000)
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña], [DNIEmpleado]) VALUES (N'malenaburgos', N'1111', 41000000)
GO
INSERT [dbo].[Usuario] ([nombre], [contraseña], [DNIEmpleado]) VALUES (N'robertogon', N'1111', 40000000)
GO
ALTER TABLE [dbo].[Cambio_Estado]  WITH CHECK ADD  CONSTRAINT [FK_Cambio_Estado_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([id])
GO
ALTER TABLE [dbo].[Cambio_Estado] CHECK CONSTRAINT [FK_Cambio_Estado_Estado]
GO
ALTER TABLE [dbo].[Cambio_Estado]  WITH CHECK ADD  CONSTRAINT [FK_Cambio_Estado_Reserva] FOREIGN KEY([numeroReserva])
REFERENCES [dbo].[Reserva] ([numero])
GO
ALTER TABLE [dbo].[Cambio_Estado] CHECK CONSTRAINT [FK_Cambio_Estado_Reserva]
GO
ALTER TABLE [dbo].[Detalle_Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Exposicion_Exposicion] FOREIGN KEY([idExposicion])
REFERENCES [dbo].[Exposicion] ([id])
GO
ALTER TABLE [dbo].[Detalle_Exposicion] CHECK CONSTRAINT [FK_Detalle_Exposicion_Exposicion]
GO
ALTER TABLE [dbo].[Detalle_Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Exposicion_Obra] FOREIGN KEY([idObra])
REFERENCES [dbo].[Obra] ([id])
GO
ALTER TABLE [dbo].[Detalle_Exposicion] CHECK CONSTRAINT [FK_Detalle_Exposicion_Obra]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Cargo] FOREIGN KEY([idCargo])
REFERENCES [dbo].[Cargo] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Cargo]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Sede]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Sede]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Tarifa] FOREIGN KEY([fechaInicioVigencia], [idTipoEntrada], [idTipoVisita], [idSede])
REFERENCES [dbo].[Tarifa] ([fechaInicioVigencia], [idTipoEntrada], [idTipoVisita], [idSede])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Tarifa]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Exposicion_Publico_Destino] FOREIGN KEY([idPublicoDestino])
REFERENCES [dbo].[Publico_Destino] ([nombre])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [FK_Exposicion_Publico_Destino]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Exposicion_Sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [FK_Exposicion_Sede]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Exposicion_Tipo_Exposicion] FOREIGN KEY([idTipo])
REFERENCES [dbo].[Tipo_Exposicion] ([id])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [FK_Exposicion_Tipo_Exposicion]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Sede]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_Usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuario] ([nombre])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_Usuario]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_Sede] FOREIGN KEY([idSede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_Sede]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_Tipo_Entrada] FOREIGN KEY([idTipoEntrada])
REFERENCES [dbo].[Tipo_Entrada] ([id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_Tipo_Entrada]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_Tipo_Visita] FOREIGN KEY([idTipoVisita])
REFERENCES [dbo].[Tipo_Visita] ([id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_Tipo_Visita]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([DNIEmpleado])
REFERENCES [dbo].[Empleado] ([DNI])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
