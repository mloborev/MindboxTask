Исполняемый файл находится в папке MindBoxTask, библиотека в CalculateArea и тесты в MindBoxTask.Tests

Ответ на второй вопрос:
SELECT Products.productName, Categories.categoryName
FROM Products LEFT JOIN Categories ON Products.categoryId = Categories.categoryId;
