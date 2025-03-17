# LeetCode SQL Solutions

## 176. Second Highest Salary
```sql
SELECT (
    SELECT DISTINCT salary 
    FROM Employee
    ORDER BY salary DESC
    OFFSET 1 ROW FETCH NEXT 1 ROW ONLY
) AS SecondHighestSalary;
```
## 180. Consecutive Numbers
```sql
Select DISTINCT l1.num AS ConsecutiveNums
FROM Logs l1
JOIN Logs l2 ON l1.num = l2.num AND l1.id = l2.id - 1
JOIN Logs l3 ON l2.num = l3.num AND l2.id = l3.id - 1
```

## 610. Triangle Judgement
```sql
SELECT x, y, z, 
       IIF(x + y > z AND y + z > x AND z + x > y, 'Yes', 'No') AS triangle
FROM Triangle;
```

## 619. Biggest Single Number
```sql
WITH rank_function AS (
    SELECT num, 
           RANK() OVER (ORDER BY num DESC) AS rn
    FROM (
        SELECT num
        FROM MyNumbers
        GROUP BY num
        HAVING COUNT(*) = 1
    ) AS SingleNumbers
)
SELECT MAX(num) AS num
FROM rank_function
WHERE rn = 1;
```
## 1045. Customers Who Bought All Products
```sql
select customer_id
from customer
group by customer_id
having count(distinct product_key) =
(select count(distinct product_key) from Product)
```

## 1211. Queries Quality and Percentage
```sql
SELECT 
    query_name, 
    ROUND(SUM(CAST(rating AS FLOAT) / position) / COUNT(query_name), 2) AS quality,
    ROUND(SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) * 100.0 / COUNT(query_name), 2) AS poor_query_percentage
FROM Queries
GROUP BY query_name
ORDER BY poor_query_percentage DESC, quality DESC;
```

## 1321. Restaurant Growth
```sql
WITH RollingSums AS (
    SELECT visited_on, SUM(amount) AS amount
    FROM Customer
    GROUP BY visited_on
)
SELECT visited_on, 
           SUM(amount) OVER (ORDER BY visited_on ASC ROWS BETWEEN 6 PRECEDING AND CURRENT ROW) AS amount,
           ROUND(AVG(amount * 1.0) OVER (
                ORDER BY visited_on ASC ROWS BETWEEN 6 PRECEDING AND CURRENT ROW
            ), 2) AS average_amount
FROM RollingSums
Order by visited_on 
OFFSET 6 rows
```

## 1517. Find Users With Valid E-Mails
```sql
SELECT *
FROM Users 
WHERE mail LIKE '[a-zA-Z]%@leetcode.com' 
AND mail NOT LIKE '%[^a-zA-Z0-9_.-]%@leetcode.com';
```

## 1667. Fix Names in a Table
```sql
SELECT user_id,
       CONCAT('', UPPER(SUBSTRING(name, 1, 1)), LOWER(SUBSTRING(name, 2, LEN(name)))) AS name
FROM Users
ORDER BY user_id;
```

## 1978. Employees Whose Manager Left the Company
```sql
SELECT e.employee_id
FROM Employees e
WHERE salary < 30000 
AND e.manager_id IS NOT NULL
AND NOT EXISTS (
    SELECT 1
    FROM Employees m
    WHERE m.employee_id = e.manager_id
)
ORDER BY employee_id ASC;
```

