EXEC sp_serveroption
	@server = 'PC-XIAOMIPRO15',
	@optname = 'DATA ACCESS',
	@optvalue = 'TRUE';

SET STATISTICS TIME ON;

SELECT * FROM OPENQUERY(
	[PC-XIAOMIPRO15],
	'SELECT p.pos, AVG(p.average) AS "Average"
	FROM ( 
		SELECT posit._name AS pos, AVG(e.salary) AS average
		FROM FOOD_DELIVERY_MAIN_OFFICE.dbo.position AS posit
		JOIN FOOD_DELIVERY_MAIN_OFFICE.dbo.employee AS e
		ON posit.id = e.id_position
		GROUP BY posit._name
		UNION
		SELECT posit._name AS pos, AVG(e.salary) AS average
		FROM [PC-XIAOMIPRO15\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.position AS posit
		JOIN [PC-XIAOMIPRO15\MSSQLSERVER2].FOOD_DELIVERY_BRANCHE.dbo.employee AS e
		ON posit.id = e.id_position
		GROUP BY posit._name
	) as p
	GROUP BY p.pos;'
);