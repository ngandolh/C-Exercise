
1211. Queries Quality and Percentage

SELECT 
    query_name, 
    ROUND(SUM(CAST(rating AS FLOAT) / position) / COUNT(query_name), 2) AS quality,
    ROUND(SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) * 100.0 / COUNT(query_name), 2) AS poor_query_percentage
FROM Queries
GROUP BY query_name
ORDER BY poor_query_percentage DESC, quality DESC;

Runtime: 1766ms
