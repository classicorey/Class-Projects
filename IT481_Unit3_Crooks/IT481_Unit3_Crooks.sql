Use Northwind

CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole;

GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT SELECT ON dbo.Employees TO HRRole;
GRANT SELECT ON dbo.Orders TO CEORole;
GRANT SELECT ON dbo.Customers TO CEORole
GRANT SELECT ON dbo.Employees TO CEORole

CREATE USER User_Sales;
CREATE USER User_HR;
CREATE USER User_CEO;

CREATE LOGIN User_Sales WITH PASSWORD = 'securepassword';
CREATE LOGIN User_HR WITH PASSWORD = 'securepassword';
CREATE LOGIN User_CEO WITH PASSWORD = 'securepassword';

EXEC sp_addrolemember 'SalesRole', 'User_Sales';
EXEC sp_addrolemember 'HRRole', 'User_HR';
EXEC sp_addrolemember 'CEORole', 'User_CEO';