
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

## 1667. Fix Names in a Table

```sql
Select user_id,
    CONCAT('', UPPER(SUBSTRING(name, 1, 1)), LOWER(SUBSTRING(name, 2, LEN(name)))) AS name
From Users
Order by user_id

##1517. Find Users With Valid E-Mails
````sql
SELECT *
FROM Users 
WHERE mail  LIKE '[a-zA-Z]%@leetcode.com' AND mail NOT LIKE '%[^a-zA-Z0-9_.-]%@leetcode.com'
