<H1>Задача для C#</H1>
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
<br><br>Дополнительно:<br>
- Юнит-тесты<br>
- Легкость добавления других фигур<br>
- Вычисление площади фигуры без знания типа фигуры<br>
- Проверку на то, является ли треугольник прямоугольным<br>

<h3>Решение задачи</h3>
Разеделенно по классам. Решение: <a href="https://github.com/Anton31312/HHTestSkill/tree/master/HHTestSkill">перейти</a>
<br>UnitTest: <a href="https://github.com/Anton31312/HHTestSkill/blob/master/TestProject/UnitTest.cs">перейти</a></br>



<H1>Задача для MSSQL</H1>
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
<h3>Создание таблиц</h3>
<pre><code>CREATE TABLE Product (ID INT PRIMARY KEY, ProductName NVARCHAR(250) NOT NULL);
CREATE TABLE Category (ID INT PRIMARY KEY, CategoryName NVARCHAR(250) NOT NULL);
CREATE TABLE ProductCategory (IDProduct INT NOT NULL, IDCategory INT NOT NULL);</code></pre>

<h3>Заполнение таблиц данными</h3>
<pre><code>INSERT INTO Product VALUES (1, 'Картофель'), (2, 'Ручка'), (3,'Блюдце'), (4, 'Морковь'), (5, 'Лукошко');
INSERT INTO Category VALUES (1, 'Овощи'), (2, 'Канцелярия'), (3,'Столовая посуда');
INSERT INTO ProductCategory VALUES (1, 1), (2, 2), (3,3), (4, 1);</code></pre>

<h3>Выполнение запроса</h3>
<pre><code>SELECT p.ProductName, c.CategoryName
FROM Product p LEFT JOIN ProductCategory pc ON p.ID = pc.IDProduct 
				LEFT JOIN Category c ON c.ID = pc.IDCategory
ORDER BY p.ProductName;</code></pre>

![image](https://user-images.githubusercontent.com/24476910/179791756-6a54c999-3637-4b08-87ea-260eaae94582.png)

