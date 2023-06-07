EXEC sp_serveroption
	@server = 'PC-XIAOMIPRO15',
	@optname = 'DATA ACCESS',
	@optvalue = 'TRUE';

SET STATISTICS TIME ON;

SELECT * FROM OPENQUERY(
	[PC-XIAOMIPRO15],
	'SELECT firstname, lastname, phone_number, salary
	FROM FOOD_DELIVERY_MAIN_OFFICE.dbo.employee
	WHERE salary > 5000
	UNION
	SELECT firstname, lastname, phone_number, salary
	FROM [PC-XIAOMIPRO15\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.employee
	WHERE salary < 1000;'
);