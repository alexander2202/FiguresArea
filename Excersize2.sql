-- Если у нас есть 2 таблицы Categories и Products, причём со связью "многие ко многим", 
-- то должна быть таблица связей, например, ProductCategories, которая будет хранить пары
--  ProductID - CategoryID

SELECT 
    p.ProductName AS 'Имя продукта', 
    c.CategoryName AS 'Имя категории'
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
ORDER BY p.ProductName, c.CategoryName;