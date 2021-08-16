Test #2:

SELECT p.name, c.name 
FROM products AS p 
LEFT OUTER JOIN productscategories AS pc ON pc.product = p.id 
LEFT OUTER JOIN categories AS c ON pc.category = c.id 
