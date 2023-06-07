EXEC sp_linkedservers;

EXEC sp_addlinkedserver
	@server = N'PC-XIAOMIPRO15\MSSQLSERVER2',
	@srvproduct = N'SQL server';

EXEC sp_addlinkedsrvlogin 'PC-XIAOMIPRO15\MSSQLSERVER2', 'false', 'serediuk', 'serediuk', 'Arinud83';

EXEC sp_linkedservers;