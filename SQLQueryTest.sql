--Create database CalculatorTests

use CalculatorTests
go

--INSERT INTO tests(expression, result)
--VALUES ('2 + 3 * 4', '14'),
--	('3*(4+2)', '18'),
--	('$100 + 50', '&Error'),
--	('2 + 3) * 4', '&Error'),
--	('',''),
--	('1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20', '$Error'),
--	('2+', '$Error'),
--	('3 + 4 - -5', '12'),
--	('2 + * 3', '&Error')
    

select top (1000) [expression]
	,[result]
from [CalculatorTests].[dbo].[tests]

--delete from tests