
## 610. Triangle Judgement
```sql
Select x, y, z, IIF(x + y > z AND
                    y + z > x AND
                    z + x > y, 'Yes', 'No') as triangle
From Triangle

## 1211 Queries Quality and Percentage

```sql
SELECT 
    query_name, 
    ROUND(SUM(CAST(rating AS FLOAT) / position) / COUNT(query_name), 2) AS quality,
    ROUND(SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) * 100.0 / COUNT(query_name), 2) AS poor_query_percentage
FROM Queries
GROUP BY query_name
ORDER BY poor_query_percentage DESC, quality DESC;

Runtime: 1766ms


##1517. Find Users With Valid E-Mails
````sql
SELECT *
FROM Users 
WHERE mail  LIKE '[a-zA-Z]%@leetcode.com' AND mail NOT LIKE '%[^a-zA-Z0-9_.-]%@leetcode.com'

## 1667. Fix Names in a Table

```sql
Select user_id,
    CONCAT('', UPPER(SUBSTRING(name, 1, 1)), LOWER(SUBSTRING(name, 2, LEN(name)))) AS name
From Users
Order by user_id


##1978. Employees Whose Manager Left the Company
````sql
Select  e.employee_id
FROM Employees e
Where salary < 30000 AND e.manager_id IS NOT NULL
AND NOT EXISTS(
    Select 1
    From Employees m
    Where m.employee_id = e.manager_id
)
ORDER BY employee_id ASC

