USE [LMS]
GO

/****** Object:  Table [dbo].[Issued]    Script Date: 9/2/2017 8:57:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Issued](
	[Reg_No] [int] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Date_Issued] [varchar](50) NOT NULL,
	[Return_Date] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Reg_No] ASC,
	[ISBN] ASC,
	[Date_Issued] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Issued]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO

ALTER TABLE [dbo].[Issued]  WITH CHECK ADD FOREIGN KEY([Reg_No])
REFERENCES [dbo].[Student] ([Reg_No])
GO

