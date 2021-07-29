USE AOA;

CREATE TABLE usuario (
  id INT IDENTITY(1, 1) PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  apellido1 VARCHAR(100) NOT NULL,
  ntarjeta VARCHAR(100),
  email VARCHAR(100)
);

CREATE TABLE producto (
  id INT IDENTITY(1, 1) PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  descripcion VARCHAR(300) NOT NULL,
  precio FLOAT,
  categoria VARCHAR(100),
  genero VARCHAR(10),
  talla VARCHAR(5),
  marca VARCHAR(100)
);


CREATE TABLE pedido (
  id INT IDENTITY(1, 1) PRIMARY KEY,
  fecha DATE,
  sucursal VARCHAR(300),
  precio_total FLOAT,
  id_usuario INT NOT NULL,
  id_producto INT NOT NULL,
  id_ropa INT NOT NULL,
  FOREIGN KEY (id_usuario) REFERENCES usuario(id),
  FOREIGN KEY (id_producto) REFERENCES producto(id)
  FOREIGN KEY (id_ropa) REFERENCES producto(id)
);


/*
INSERT INTO usuario(nombre, apellido1, apellido2, email, password) VALUES('Aarón', 'Rivero', 'Gómez', 'aaronriv@gmail.com', 'Patosvolanto00');
INSERT INTO producto (nombre, descripcion, precio, categoria, genero, talla, marca) VALUES('Nike Fly Go Ease', 'Tenis sin agujetas', 699.60, 'Deportivo', 'Unisex', 40, 'Nike');
 

select * from usuario
select * from producto

*/


