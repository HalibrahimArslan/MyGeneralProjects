--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='Paris'

--case insentive
Select * from Products where CategoryID=1 or CategoryID=3

--<> Farklı demek
Select * from Products where CategoryID=1 and UnitPrice>10

Select *from Products where CategoryID=1 order by UnitPrice ---ascending ---descending

Select count(*) Adet from Products where CategoryID=2

Select CategoryID,count(*) from Products where UnitPrice>20 
group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
order by UnitPrice asc

---DTO data transformation object

Select *from Products p left join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID


Select * from Customers c left join Orders od
on c.CustomerID = od.CustomerID
where od.CustomerID is null













	

