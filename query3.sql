GO

SET STATISTICS TIME ON;

SELECT a.*
FROM OPENROWSET(
	'SQLNCLI',
	'Server=PC-XIAOMIPRO15; Trusted_Connection=yes;',
	'SELECT CONCAT(firstname, lastname) AS fullname, address, phone_number, salary 
	FROM FOOD_DELIVERY_MAIN_OFFICE.dbo.employee 
	WHERE salary > 5000
	UNION
	SELECT CONCAT(firstname, lastname) AS fullname, address, phone_number, salary 
	FROM [PC-XIAOMIPRO15\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.employee 
	WHERE salary < 1000'
) AS a;

SET STATISTICS TIME OFF;
GO
