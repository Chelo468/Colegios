USE [Colegios]
GO
/****** Object:  Table [dbo].[Estado_Temario]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado_Temario](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Estado_Temario] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado_Examen]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado_Examen](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Estado_Examen] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado_Asistencia]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado_Asistencia](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Estado_Asistencia] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Materia](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[id_colegio] [int] NULL,
	[descripcion] [varchar](200) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[nivel] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pagina]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pagina](
	[id_pagina] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[menu] [varchar](80) NULL,
	[controlador] [varchar](80) NULL,
	[accion] [varchar](255) NULL,
	[orden] [int] NULL,
	[icono] [varchar](50) NULL,
 CONSTRAINT [PK_Pagina] PRIMARY KEY CLUSTERED 
(
	[id_pagina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](200) NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Usuario_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pagina_Perfil]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagina_Perfil](
	[id_pagina] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Pagina_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_pagina] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barrio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[nombre_usuario] [varchar](100) NULL,
	[password] [varchar](100) NULL,
	[habilitado] [bit] NULL,
	[email] [varchar](100) NULL,
	[celular] [varchar](50) NULL,
	[password_recovery] [varchar](100) NULL,
	[id_barrio] [int] NULL,
	[id_localidad] [int] NULL,
	[id_provincia] [int] NULL,
	[id_pais] [int] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[id_perfil] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plan]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plan](
	[id_plan] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[cantidad_alumnos] [int] NULL,
	[habilitado] [bit] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED 
(
	[id_plan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temario]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temario](
	[id_tema] [int] IDENTITY(1,1) NOT NULL,
	[id_materia] [int] NULL,
	[año] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[observaciones] [varchar](255) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Temario] PRIMARY KEY CLUSTERED 
(
	[id_tema] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol_Usuario](
	[id_rol] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Rol_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC,
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colegio]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colegio](
	[id_colegio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[calle] [varchar](100) NULL,
	[calle_nro] [varchar](10) NULL,
	[id_barrio] [int] NULL,
	[id_localidad] [int] NULL,
	[id_provincia] [int] NULL,
	[id_pais] [int] NULL,
	[id_plan] [int] NULL,
	[fecha_suscripcion] [datetime] NULL,
	[habilitado] [bit] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Colegio] PRIMARY KEY CLUSTERED 
(
	[id_colegio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contacto_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contacto_Colegio](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[id_colegio] [int] NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[celular] [varchar](50) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Contacto_Colegio] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colegio_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colegio_Usuario](
	[id_colegio] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Colegio_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_colegio] ASC,
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[habilitado] [bit] NULL,
	[capacidad_alumnos] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[id_colegio] [int] NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turno](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[id_colegio] [int] NULL,
	[codigo] [varchar](10) NULL,
	[descripcion] [varchar](100) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reunion]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reunion](
	[id_reunion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reunion] [datetime] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[id_colegio] [int] NULL,
	[descripcion] [varchar](100) NULL,
	[observaciones] [varchar](150) NULL,
 CONSTRAINT [PK_Reunion] PRIMARY KEY CLUSTERED 
(
	[id_reunion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Participante_Reunion]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participante_Reunion](
	[id_reunion] [int] NOT NULL,
	[id_participante] [int] NOT NULL,
	[confirma_presencia] [bit] NULL,
	[fecha_confirmacion] [datetime] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Participante_Reunion] PRIMARY KEY CLUSTERED 
(
	[id_reunion] ASC,
	[id_participante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[id_aula] [int] NULL,
	[id_profesor] [int] NULL,
	[año] [int] NULL,
	[id_turno] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[nivel] [int] NULL,
	[id_preceptor] [int] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materia_Curso]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia_Curso](
	[id_materia] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Materia_Curso] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[id_examen] [int] IDENTITY(1,1) NOT NULL,
	[id_curso] [int] NULL,
	[id_materia] [int] NULL,
	[id_estado] [int] NULL,
	[año] [int] NULL,
	[fecha_examen] [datetime] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Examen] PRIMARY KEY CLUSTERED 
(
	[id_examen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[id_asistencia] [int] IDENTITY(1,1) NOT NULL,
	[id_curso] [int] NULL,
	[id_alumno] [int] NULL,
	[fecha_asistencia] [datetime] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED 
(
	[id_asistencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_Curso]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Curso](
	[id_alumno] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Alumno_Curso] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tema_Examen]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tema_Examen](
	[id_examen] [int] NOT NULL,
	[id_tema] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Tema_Examen] PRIMARY KEY CLUSTERED 
(
	[id_examen] ASC,
	[id_tema] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_Examen]    Script Date: 07/19/2019 16:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Examen](
	[id_alumno] [int] NOT NULL,
	[id_examen] [int] NOT NULL,
	[nota] [int] NULL,
	[fecha_alta] [datetime] NULL,
	[usuario_alta] [int] NULL,
	[fecha_baja] [datetime] NULL,
	[usuario_baja] [int] NULL,
 CONSTRAINT [PK_Alumno_Examen] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC,
	[id_examen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Alumno_Curso_Alumno]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Curso_Alumno] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Curso] CHECK CONSTRAINT [FK_Alumno_Curso_Alumno]
GO
/****** Object:  ForeignKey [FK_Alumno_Curso_Curso]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Curso_Curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Curso] ([id_curso])
GO
ALTER TABLE [dbo].[Alumno_Curso] CHECK CONSTRAINT [FK_Alumno_Curso_Curso]
GO
/****** Object:  ForeignKey [FK_Alumno_Curso_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Curso_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Curso] CHECK CONSTRAINT [FK_Alumno_Curso_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Alumno_Curso_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Curso_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Curso] CHECK CONSTRAINT [FK_Alumno_Curso_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Alumno_Examen_Examen]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Examen_Examen] FOREIGN KEY([id_examen])
REFERENCES [dbo].[Examen] ([id_examen])
GO
ALTER TABLE [dbo].[Alumno_Examen] CHECK CONSTRAINT [FK_Alumno_Examen_Examen]
GO
/****** Object:  ForeignKey [FK_Alumno_Examen_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Examen_Usuario] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Examen] CHECK CONSTRAINT [FK_Alumno_Examen_Usuario]
GO
/****** Object:  ForeignKey [FK_Alumno_Examen_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Examen_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Examen] CHECK CONSTRAINT [FK_Alumno_Examen_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Alumno_Examen_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Alumno_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Examen_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Alumno_Examen] CHECK CONSTRAINT [FK_Alumno_Examen_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Asistencia_Alumno]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Alumno] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Alumno]
GO
/****** Object:  ForeignKey [FK_Asistencia_Curso]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Curso] ([id_curso])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Curso]
GO
/****** Object:  ForeignKey [FK_Asistencia_Estado_Asistencia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Estado_Asistencia] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado_Asistencia] ([id_estado])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Estado_Asistencia]
GO
/****** Object:  ForeignKey [FK_Asistencia_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Asistencia_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Aula_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD  CONSTRAINT [FK_Aula_Colegio] FOREIGN KEY([id_colegio])
REFERENCES [dbo].[Colegio] ([id_colegio])
GO
ALTER TABLE [dbo].[Aula] CHECK CONSTRAINT [FK_Aula_Colegio]
GO
/****** Object:  ForeignKey [FK_Aula_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD  CONSTRAINT [FK_Aula_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Aula] CHECK CONSTRAINT [FK_Aula_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Aula_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD  CONSTRAINT [FK_Aula_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Aula] CHECK CONSTRAINT [FK_Aula_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Barrio_Localidad]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Barrio_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Barrio_Localidad]
GO
/****** Object:  ForeignKey [FK_Colegio_Barrio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_Barrio]
GO
/****** Object:  ForeignKey [FK_Colegio_Localidad]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_Localidad]
GO
/****** Object:  ForeignKey [FK_Colegio_Pais]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Pais] ([id])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_Pais]
GO
/****** Object:  ForeignKey [FK_Colegio_Plan]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Plan] FOREIGN KEY([id_plan])
REFERENCES [dbo].[Plan] ([id_plan])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_Plan]
GO
/****** Object:  ForeignKey [FK_Colegio_Provincia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_Provincia]
GO
/****** Object:  ForeignKey [FK_Colegio_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Colegio_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Colegio] CHECK CONSTRAINT [FK_Colegio_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Colegio_Usuario_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Usuario_Colegio] FOREIGN KEY([id_colegio])
REFERENCES [dbo].[Colegio] ([id_colegio])
GO
ALTER TABLE [dbo].[Colegio_Usuario] CHECK CONSTRAINT [FK_Colegio_Usuario_Colegio]
GO
/****** Object:  ForeignKey [FK_Colegio_Usuario_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Usuario_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Colegio_Usuario] CHECK CONSTRAINT [FK_Colegio_Usuario_Usuario]
GO
/****** Object:  ForeignKey [FK_Colegio_Usuario_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Usuario_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Colegio_Usuario] CHECK CONSTRAINT [FK_Colegio_Usuario_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Colegio_Usuario_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Colegio_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Colegio_Usuario_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Colegio_Usuario] CHECK CONSTRAINT [FK_Colegio_Usuario_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Contacto_Colegio_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Contacto_Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Contacto_Colegio_Colegio] FOREIGN KEY([id_colegio])
REFERENCES [dbo].[Colegio] ([id_colegio])
GO
ALTER TABLE [dbo].[Contacto_Colegio] CHECK CONSTRAINT [FK_Contacto_Colegio_Colegio]
GO
/****** Object:  ForeignKey [FK_Contacto_Colegio_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Contacto_Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Contacto_Colegio_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Contacto_Colegio] CHECK CONSTRAINT [FK_Contacto_Colegio_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Contacto_Colegio_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Contacto_Colegio]  WITH CHECK ADD  CONSTRAINT [FK_Contacto_Colegio_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Contacto_Colegio] CHECK CONSTRAINT [FK_Contacto_Colegio_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Curso_Aula]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[Aula] ([id_aula])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Aula]
GO
/****** Object:  ForeignKey [FK_Curso_Profesor]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Profesor] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Profesor]
GO
/****** Object:  ForeignKey [FK_Curso_Turno]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Turno] FOREIGN KEY([id_turno])
REFERENCES [dbo].[Turno] ([id_turno])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Turno]
GO
/****** Object:  ForeignKey [FK_Curso_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Curso_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Curso_UsuarioPreceptor]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_UsuarioPreceptor] FOREIGN KEY([id_preceptor])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_UsuarioPreceptor]
GO
/****** Object:  ForeignKey [FK_Examen_Curso]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Curso] ([id_curso])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Curso]
GO
/****** Object:  ForeignKey [FK_Examen_Estado_Examen]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Estado_Examen] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado_Examen] ([id_estado])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Estado_Examen]
GO
/****** Object:  ForeignKey [FK_Examen_Materia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[Materia] ([id_materia])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Materia]
GO
/****** Object:  ForeignKey [FK_Examen_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Examen_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Localidad_Provincia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
/****** Object:  ForeignKey [FK_Materia_Curso_Curso]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Materia_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Curso_Curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Curso] ([id_curso])
GO
ALTER TABLE [dbo].[Materia_Curso] CHECK CONSTRAINT [FK_Materia_Curso_Curso]
GO
/****** Object:  ForeignKey [FK_Materia_Curso_Materia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Materia_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Curso_Materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[Materia] ([id_materia])
GO
ALTER TABLE [dbo].[Materia_Curso] CHECK CONSTRAINT [FK_Materia_Curso_Materia]
GO
/****** Object:  ForeignKey [FK_Materia_Curso_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Materia_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Curso_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Materia_Curso] CHECK CONSTRAINT [FK_Materia_Curso_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Materia_Curso_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Materia_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Curso_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Materia_Curso] CHECK CONSTRAINT [FK_Materia_Curso_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Pagina_Perfil_Pagina]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Pagina_Perfil]  WITH CHECK ADD  CONSTRAINT [FK_Pagina_Perfil_Pagina] FOREIGN KEY([id_pagina])
REFERENCES [dbo].[Pagina] ([id_pagina])
GO
ALTER TABLE [dbo].[Pagina_Perfil] CHECK CONSTRAINT [FK_Pagina_Perfil_Pagina]
GO
/****** Object:  ForeignKey [FK_Pagina_Perfil_Perfil]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Pagina_Perfil]  WITH CHECK ADD  CONSTRAINT [FK_Pagina_Perfil_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Pagina_Perfil] CHECK CONSTRAINT [FK_Pagina_Perfil_Perfil]
GO
/****** Object:  ForeignKey [FK_Participante_Reunion_Reunion]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Participante_Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Reunion_Reunion] FOREIGN KEY([id_reunion])
REFERENCES [dbo].[Reunion] ([id_reunion])
GO
ALTER TABLE [dbo].[Participante_Reunion] CHECK CONSTRAINT [FK_Participante_Reunion_Reunion]
GO
/****** Object:  ForeignKey [FK_Participante_Reunion_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Participante_Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Reunion_Usuario] FOREIGN KEY([id_participante])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Participante_Reunion] CHECK CONSTRAINT [FK_Participante_Reunion_Usuario]
GO
/****** Object:  ForeignKey [FK_Participante_Reunion_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Participante_Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Reunion_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Participante_Reunion] CHECK CONSTRAINT [FK_Participante_Reunion_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Participante_Reunion_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Participante_Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Reunion_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Participante_Reunion] CHECK CONSTRAINT [FK_Participante_Reunion_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Plan_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Plan]  WITH CHECK ADD  CONSTRAINT [FK_Plan_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Plan] CHECK CONSTRAINT [FK_Plan_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Plan_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Plan]  WITH CHECK ADD  CONSTRAINT [FK_Plan_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Plan] CHECK CONSTRAINT [FK_Plan_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Provincia_Pais]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Pais] ([id])
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Pais]
GO
/****** Object:  ForeignKey [FK_Reunion_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Reunion_Colegio] FOREIGN KEY([id_colegio])
REFERENCES [dbo].[Colegio] ([id_colegio])
GO
ALTER TABLE [dbo].[Reunion] CHECK CONSTRAINT [FK_Reunion_Colegio]
GO
/****** Object:  ForeignKey [FK_Reunion_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Reunion_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Reunion] CHECK CONSTRAINT [FK_Reunion_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Reunion_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Reunion]  WITH CHECK ADD  CONSTRAINT [FK_Reunion_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Reunion] CHECK CONSTRAINT [FK_Reunion_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_Rol]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_Rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[Rol] ([id_rol])
GO
ALTER TABLE [dbo].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_Rol]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_Usuario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_Usuario]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Rol_Usuario_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Tema_Examen_Examen]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Tema_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Tema_Examen_Examen] FOREIGN KEY([id_examen])
REFERENCES [dbo].[Examen] ([id_examen])
GO
ALTER TABLE [dbo].[Tema_Examen] CHECK CONSTRAINT [FK_Tema_Examen_Examen]
GO
/****** Object:  ForeignKey [FK_Tema_Examen_Temario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Tema_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Tema_Examen_Temario] FOREIGN KEY([id_tema])
REFERENCES [dbo].[Temario] ([id_tema])
GO
ALTER TABLE [dbo].[Tema_Examen] CHECK CONSTRAINT [FK_Tema_Examen_Temario]
GO
/****** Object:  ForeignKey [FK_Tema_Examen_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Tema_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Tema_Examen_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Tema_Examen] CHECK CONSTRAINT [FK_Tema_Examen_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Tema_Examen_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Tema_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Tema_Examen_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Tema_Examen] CHECK CONSTRAINT [FK_Tema_Examen_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Temario_Estado_Temario]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Temario]  WITH CHECK ADD  CONSTRAINT [FK_Temario_Estado_Temario] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado_Temario] ([id_estado])
GO
ALTER TABLE [dbo].[Temario] CHECK CONSTRAINT [FK_Temario_Estado_Temario]
GO
/****** Object:  ForeignKey [FK_Temario_Materia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Temario]  WITH CHECK ADD  CONSTRAINT [FK_Temario_Materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[Materia] ([id_materia])
GO
ALTER TABLE [dbo].[Temario] CHECK CONSTRAINT [FK_Temario_Materia]
GO
/****** Object:  ForeignKey [FK_Temario_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Temario]  WITH CHECK ADD  CONSTRAINT [FK_Temario_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Temario] CHECK CONSTRAINT [FK_Temario_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Temario_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Temario]  WITH CHECK ADD  CONSTRAINT [FK_Temario_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Temario] CHECK CONSTRAINT [FK_Temario_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Turno_Colegio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Colegio] FOREIGN KEY([id_colegio])
REFERENCES [dbo].[Colegio] ([id_colegio])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Colegio]
GO
/****** Object:  ForeignKey [FK_Turno_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Turno_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_UsuarioBaja]
GO
/****** Object:  ForeignKey [FK_Usuario_Barrio]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Barrio]
GO
/****** Object:  ForeignKey [FK_Usuario_Localidad]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Localidad]
GO
/****** Object:  ForeignKey [FK_Usuario_Pais]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Pais] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Pais]
GO
/****** Object:  ForeignKey [FK_Usuario_Perfil]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
/****** Object:  ForeignKey [FK_Usuario_Provincia]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Provincia]
GO
/****** Object:  ForeignKey [FK_Usuario_UsuarioAlta]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_UsuarioAlta] FOREIGN KEY([usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_UsuarioAlta]
GO
/****** Object:  ForeignKey [FK_Usuario_UsuarioBaja]    Script Date: 07/19/2019 16:46:45 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_UsuarioBaja] FOREIGN KEY([usuario_baja])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_UsuarioBaja]
GO
