create table dbo.Product
(
	ProductId int primary key,
	ProductName nvarchar(128) not null,
)

insert into dbo.Product(ProductId, ProductName) values
	('1', 'Молоко'),
	('2', 'Сыр'),
	('3', 'Хлеб'),
	('4', 'Телефон')

create table dbo.Category
(
	CategoryId int primary key,
	CategoryName nvarchar(128) not null,
)

insert into dbo.Category(CategoryId, CategoryName) values
	('1', 'Молочные продукты'),
	('2', 'Выпечка'),
	('3', 'Напитки')

create table dbo.ProductsCategories
(
	ProductId int foreign key references dbo.Product(ProductId),
	CategoryId int foreign key references dbo.Category(CategoryId),
	primary key(ProductId, CategoryId)
)

insert into dbo.ProductsCategories(ProductId, CategoryId) values (1, 1)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (2, 1)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (3, 2)


--Вывод всех пар продукт-категория. Даже если у продукта нет категории.
select P.ProductName, C.CategoryName
from Product as P 
left join ProductsCategories as PC ON P.ProductId = PC.ProductId
left join Category as C ON C.CategoryId = PC.CategoryId
