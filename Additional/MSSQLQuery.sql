SELECT product_name, category_name FROM [dbo].[products]
CROSS JOIN [dbo].[categories]
UNION
SELECT product_name, '' AS category_name FROM [dbo].[products]