 create database TECHNET
GO
use TECHNET
 
SET ANSI_NULLS ON
GO
 
SET QUOTED_IDENTIFIER ON
GO
 
CREATE TABLE [dbo].[Articoli](
    [IdArticolo] [int] IDENTITY(1,1) NOT NULL,
    [CodArt] [nvarchar](25) NOT NULL,
    [DesArt] [nvarchar](50) NOT NULL,
    [CodFamiglia] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Articoli] PRIMARY KEY CLUSTERED
(
    [IdArticolo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
 
GO
ALTER TABLE [dbo].[Articoli] ADD  CONSTRAINT [DF_Articoli_CodArt]  DEFAULT ('') FOR [CodArt]
GO
 
ALTER TABLE [dbo].[Articoli] ADD  CONSTRAINT [DF_Articoli_DesArt]  DEFAULT ('') FOR [DesArt]
GO
 
ALTER TABLE [dbo].[Articoli] ADD  CONSTRAINT [DF_Articoli_CodFamiglia]  DEFAULT ('') FOR [CodFamiglia]
GO
 
CREATE TABLE [dbo].[Famiglie](
    [CodFamiglia] [nvarchar](6) NOT NULL,
    [DesFamiglia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Famiglie] PRIMARY KEY CLUSTERED
(
    [CodFamiglia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
 
GO

INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART001', 'ARTICOLO TEST' , 'FAM01')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART002', 'PRODOTTO PROVA', 'FAM01')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART003', 'ART. 003', 'FAM02')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART004', 'ART. 004', 'FAM02')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART005', 'ART. 005', 'FAM02')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART006', 'ART. 006', 'FAM02')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART007', 'ART. 007', 'FAM03')
INSERT INTO Articoli(CodArt, DesArt, CodFamiglia) VALUES ('ART008', 'ART. 008', 'FAM04')
 
INSERT INTO Famiglie(CodFamiglia, DesFamiglia) VALUES ('FAM01', 'PROD. MECCANICI')
INSERT INTO Famiglie(CodFamiglia, DesFamiglia) VALUES ('FAM02', 'PROD. ELETTRONICI')
INSERT INTO Famiglie(CodFamiglia, DesFamiglia) VALUES ('FAM03', 'RICAMBI')
INSERT INTO Famiglie(CodFamiglia, DesFamiglia) VALUES ('FAM04', 'IMPORT')


