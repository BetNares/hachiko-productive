﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nama_Tugas] NVARCHAR(100) NOT NULL,
	[Matkul] NVARCHAR(100) NOT NULL,
	[Deadline] DATETIME NULL,
	[Deskripsi] NVARCHAR(500) NULL

)
