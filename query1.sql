SET STATISTICS TIME ON;

SELECT firstname, lastname, phone_number, salary
FROM FOOD_DELIVERY_MAIN_OFFICE.dbo.employee
WHERE salary > 5000
UNION
SELECT firstname, lastname, phone_number, salary
FROM [PC-XIAOMIPRO15\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.employee
WHERE salary < 1000;

SET STATISTICS TIME OFF;
GO