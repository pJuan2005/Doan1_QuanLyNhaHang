-- Tạo database và sử dụng
CREATE DATABASE RM;
GO
USE RM;
GO

-- Bảng người dùng
CREATE TABLE users (
    userID INT PRIMARY KEY IDENTITY,
    username VARCHAR(50) NOT NULL,
    upass VARCHAR(10) NOT NULL,
    uName VARCHAR(50) NOT NULL,
    uPhone VARCHAR(20)
);
INSERT INTO users VALUES ('admin', '123', 'User 1', '84-123456789');

-- Bảng danh mục món
CREATE TABLE category (
    catID INT PRIMARY KEY IDENTITY,
    catName VARCHAR(50)
);

-- Bảng bàn
CREATE TABLE tables (
    tableID INT PRIMARY KEY IDENTITY,
    tableName VARCHAR(15)
);

-- Bảng nhân viên
CREATE TABLE staff (
    staffID INT PRIMARY KEY IDENTITY,
    sName NVARCHAR(50),
    sPhone VARCHAR(50),
    sRole NVARCHAR(50)
);

-- Bảng sản phẩm
CREATE TABLE products (
    pID INT PRIMARY KEY IDENTITY,
    pName NVARCHAR(50),
    pPrice FLOAT,
    CategoryID INT FOREIGN KEY REFERENCES category(catID),
    pImage IMAGE
);

-- Bảng khách hàng
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    CustName NVARCHAR(50),
    CustPhone VARCHAR(50)
);

-- Bảng hóa đơn chính
CREATE TABLE tblMain (
    MainID INT PRIMARY KEY IDENTITY,
    aDate DATE,
    aTime VARCHAR(15),
    TableName VARCHAR(10),
    WaiterName NVARCHAR(100),
    status VARCHAR(15),
    orderType VARCHAR(15),
    total FLOAT,
    received FLOAT,
    change FLOAT,

    -- Khóa ngoại đến bảng Customers
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),

    -- Khóa ngoại đến bảng staff (tài xế giao hàng)
    DriverID INT FOREIGN KEY REFERENCES staff(staffID)
);

-- Bảng chi tiết hóa đơn
CREATE TABLE tblDetails (
    DetailID INT PRIMARY KEY IDENTITY,
    MainID INT FOREIGN KEY REFERENCES tblMain(MainID),
    proID INT FOREIGN KEY REFERENCES products(pID),
    qty INT,
    price FLOAT,
    amount FLOAT
);

-- Truy vấn mẫu
SELECT 
    pID, pName, pPrice, CategoryID, c.catName 
FROM 
    products p 
    INNER JOIN category c ON c.catID = p.CategoryID;

SELECT 
    * 
FROM 
    tblMain m 
    INNER JOIN tblDetails d ON m.MainID = d.MainID;

