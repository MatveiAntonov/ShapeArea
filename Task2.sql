-- Create products table
CREATE TABLE products (
    Id int PRIMARY KEY,
    ProductName nvarchar(255)
);

-- Create categories table
CREATE TABLE categories (
    Id int PRIMARY KEY,
    CategoryName nvarchar(255)
);

-- Create products_categories m2m table
CREATE TABLE products_categories (
    ProductId int,
    CategoryId int,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

-- Insert data into products table
INSERT INTO Products (Id, ProductName)
VALUES
    (1, 'Product 1'),
    (2, 'Product 2'),
    (3, 'Product 3');

-- Insert data into categories table
INSERT INTO Categories (Id, CategoryName)
VALUES
    (1, 'Category 1'),
    (2, 'Category 2'),
    (3, 'Category 3');

-- Insert data into products_categories table
INSERT INTO products_categories (ProductId, CategoryId)
VALUES
    (1, 1),
    (1, 2),
    (2, 2),
    (2, 1),
    (2, 3);

-- Query
SELECT 
    p.ProductName,
    COALESCE(c.CategoryName, 'No Category') AS CategoryName
FROM products p
LEFT JOIN products_categories pc ON p.Id = pc.ProductId
LEFT JOIN categories c ON pc.CategoryId = c.Id
ORDER BY p.ProductName, c.CategoryName;
