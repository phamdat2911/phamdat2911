USE [HSBA]
GO

/****** Object:  Table [dbo].[Info_patient]    Script Date: 22/11/2021 2:24:50 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Info_patient](
	[mabn] [nchar](10) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nchar](10) NULL,
	[diachi] [nvarchar](100) NULL,
	[ngaysinh] [nchar](15) NULL,
	[cmnd] [nchar](10) NULL,
	[sdt] [nchar](10) NULL,
	[dantoc] [nvarchar](50) NULL,
	[job] [nvarchar](50) NULL,
	[doituong] [nvarchar](50) NULL,
	[nhommau] [nchar](3) NULL,
	[DiUngThuoc] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[maba] [nchar](10) NULL,
 CONSTRAINT [PK_Info_patient] PRIMARY KEY CLUSTERED 
(
	[mabn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


