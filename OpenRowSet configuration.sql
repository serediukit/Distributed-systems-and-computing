EXEC sp_configure 'show advanced options', 1
RECONFIGURE WITH OVERRIDE
GO

EXEC sp_configure 'ad hoc distributed queries', 1
RECONFIGURE WITH OVERRIDE
GO

EXEC sp_linkedservers;
SELECT a.*
FROM OPENROWSET(
	'SQLNCLI',
	'SERVER=PC-XIAOMIPRO15; UID=PC-XIAOMIPRO15\Valik; PWD=Arinud83',
	'SELECT * FROM testdb.dbo.Profile'
) AS a;

