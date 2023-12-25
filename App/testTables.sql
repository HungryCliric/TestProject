CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255)
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Categories (CategoryID, CategoryName) VALUES
    (1, 'Категория1'),
    (2, 'Категория2'),
    (3, 'Категория3');

INSERT INTO Products (ProductID, ProductName) VALUES
    (101, 'Продукт1'),
    (102, 'Продукт2'),
    (103, 'Продукт3'),
    (104, 'Продукт4');

INSERT INTO ProductCategory (ProductID, CategoryID) VALUES
    (101, 1),
    (101, 2),
    (102, 2),
    (103, 3),
    (104, 1),
    (104, 3);

SELECT Products.ProductName, ISNULL(Categories.CategoryName, 'Без категории') AS CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;