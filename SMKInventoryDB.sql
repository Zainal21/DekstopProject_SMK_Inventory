USE [SMKInventoryDB]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Barang](
	[id_barang] [varchar](10) NOT NULL,
	[nama_barang] [varchar](50) NULL,
	[kondisi] [varchar](50) NULL,
	[status_barang] [varchar](50) NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Member]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[id_user] [int] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[nama] [varchar](50) NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pengambalian]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pengambalian](
	[id_kembali] [int] NOT NULL,
	[id_barang] [varchar](50) NULL,
	[nama_barang] [varchar](50) NULL,
	[nama_peminjam] [varchar](50) NULL,
	[kondisi] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[tanggal_pinjam] [varchar](50) NULL,
	[tanggal_kembali] [varchar](50) NULL,
 CONSTRAINT [PK_pengambalian] PRIMARY KEY CLUSTERED 
(
	[id_kembali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pinjaman]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pinjaman](
	[id_pinjam] [int] NOT NULL,
	[id_barang] [varchar](10) NULL,
	[nama_barang] [varchar](50) NULL,
	[nama_peminjam] [varchar](50) NULL,
	[kondisi] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[tanggal_pinjam] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[role]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[role](
	[id] [int] NOT NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ruang]    Script Date: 1/28/2020 7:05:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ruang](
	[id_ruang] [varchar](10) NOT NULL,
	[nama_ruang] [nchar](10) NULL,
	[id_barang] [varchar](10) NULL,
 CONSTRAINT [PK_Ruang] PRIMARY KEY CLUSTERED 
(
	[id_ruang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'KM1', N'Meja KM1', N'Bagus', N'Tersedia')
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'KM123', N'Kursi 1', N'Bagus', N'Tersedia')
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'KOMP123', N'Komputer', N'Buruk', N'Tersedia')
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'MK123', N'nhsbda', N'Bagus', N'Tersedia')
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'RTSA6787', N'hhhhhh', N'Bagus', N'Tidak Tersedia')
INSERT [dbo].[Barang] ([id_barang], [nama_barang], [kondisi], [status_barang]) VALUES (N'TRD871329', N'slaslaf', N'Bagus', N'Tersedia')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (1, N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'zainal arifin', N'Adminstrator')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (2, N'afin', N'010da539706778c54dbb32f0c3f4affc', N'afin', N'Peminjam')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (3, N'hendra', N'a04cca766a885687e33bc6b114230ee9', N'hendra agil', N'Operator')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (4, N'hamdan', N'5eda958ce0a8c250ad09b1c610a85e1d', N'hamdan', N'Owner')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (5, N'Adinda', N'994a22ecb0e2d17f21068c1a337e5197', N'Adinda', N'Peminjam')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (54, N'aku', N'89ccfac87d8d06db06bf3211cb2d69ed', N'aku', N'Adminstrator')
INSERT [dbo].[Member] ([id_user], [username], [password], [nama], [role]) VALUES (2131, N'yusuf', N'dd2eb170076a5dec97cdbbbbff9a4405', N'ucup', N'Peminjam')
INSERT [dbo].[pengambalian] ([id_kembali], [id_barang], [nama_barang], [nama_peminjam], [kondisi], [status], [tanggal_pinjam], [tanggal_kembali]) VALUES (89965, N'KM123', N'Kursi 1', N'Zainal Arifin', N'Bagus', N'Tersedia', N'Saturday, January 25, 2020', N'Saturday, January 25, 2020')
INSERT [dbo].[pengambalian] ([id_kembali], [id_barang], [nama_barang], [nama_peminjam], [kondisi], [status], [tanggal_pinjam], [tanggal_kembali]) VALUES (231441, N'KM123', N'Kursi 1', N'zainal', N'Bagus', N'Tersedia', N'Wednesday, January 15, 2020', N'Wednesday, January 15, 2020')
INSERT [dbo].[pinjaman] ([id_pinjam], [id_barang], [nama_barang], [nama_peminjam], [kondisi], [status], [tanggal_pinjam]) VALUES (42121, N'RTSA6787', N'hhhhhh', N'Adinda', N'Bagus', N'Tersedia', N'Saturday, January 25, 2020')
