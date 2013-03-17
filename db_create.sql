-- Trevor Marsh
-- 3/16/13
-- Database creation setup

USE master

IF EXISTS (SELECT * FROM sys.databases d WHERE d.name = 'CLEANCODE')
DROP DATABASE CLEANCODE

GO

USE master