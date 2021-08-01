-----------------------------------------
-- Usuarios
-----------------------------------------
USE [AOAStore]
GO

INSERT INTO [dbo].[Usuario]
           ([username]
           ,[password])
     VALUES
           ('user1'
           ,'123456')
GO

INSERT INTO [dbo].[Usuario]
           ([username]
           ,[password])
     VALUES
           ('user2'
           ,'123456')
GO

INSERT INTO [dbo].[Usuario]
           ([username]
           ,[password])
     VALUES
           ('user3'
           ,'123456')
GO
-----------------------------------------
-- Productos
-----------------------------------------
USE [AOAStore]
GO

INSERT INTO [dbo].[Producto]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 1'
           ,3.00
           ,'/estilos/img/product-1.jpg')
GO

INSERT INTO [dbo].[Producto]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 2'
           ,7.50
           ,'/estilos/img/product-2.jpg')
GO

INSERT INTO [dbo].[Producto]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 3'
           ,6.50
           ,'/estilos/img/product-3.jpg')
GO

INSERT INTO [dbo].[Producto]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 4'
           ,9.00
           ,'/estilos/img/product-4.jpg')
GO
-----------------------------------------
-- Productos Recientes
-----------------------------------------
USE [AOAStore]
GO

INSERT INTO [dbo].[ProductoReciente]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 5'
           ,4.00
           ,'/estilos/img/product-5.jpg')
GO

INSERT INTO [dbo].[ProductoReciente]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 6'
           ,11.00
           ,'/estilos/img/product-6.jpg')
GO

INSERT INTO [dbo].[ProductoReciente]
           ([descripcion]
           ,[precio]
           ,[imagen])
     VALUES
           ('Producto 7'
           ,16.50
           ,'/estilos/img/product-7.jpg')
GO
-----------------------------------------
-- Compras
-----------------------------------------
USE [AOAStore]
GO

DECLARE @userId bigint
SELECT @userId = id FROM Usuario WHERE username = 'user1'

INSERT INTO [dbo].[Compras]
SELECT TOP 4 id, @userId, 5 FROM [dbo].[Producto]
GO

