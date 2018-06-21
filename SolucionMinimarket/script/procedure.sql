use canje;

-- procedimiento de autenticacion
create procedure sp_autenticar_clientes(
p_usuario varchar(45),
p_clave varchar(45)
)
select nombres,apellidos from cliente where usuario=p_usuario and clave=p_clave;


 


create procedure sp_autenticar_usuarios(
p_login varchar(50),
p_password varchar(50)
)
select u.login,u.passwd, e.nombre, e.apellidos from usuarios u
inner join empleado e on e.id_empleado = u.id_empleado
where login=p_login and passwd=p_password;


select p.id_producto,p.nombre, p.descripcion,p.puntos,p.foto,p.stock,c.nombre
from productos p
inner join categorias c
on p.id_categoria=c.id_categoria;

select * from empleado;
select * from usuarios;
-- Procedimientos almacenados para CRUD categoria
create procedure sp_insertar_categoria(
p_nombre varchar(50),
p_descripcion varchar(100)
)
insert into categorias (nombre, descripcion) values (p_nombre,p_descripcion);

create procedure sp_actualizar_categoria(
p_id_categoria int,
p_nombre varchar(50),
p_descripcion varchar(100)
)
update categorias set nombre=p_nombre, descripcion=p_descripcion
where id_categoria=p_id_categoria;

create procedure sp_listar_categoria_codigo(
p_id_categoria int)
select id_categoria, nombre, descripcion from categorias 
where id_categoria = p_id_categoria;


create procedure sp_listar_categoria()
select id_categoria, nombre, descripcion from categorias;


create procedure sp_generar_codigo_categoria()
select max(id_categoria)+1 as cod_categoria from categorias;

create procedure sp_eliminar_categoria(
p_id_categoria int)
delete from categorias where id_categoria=p_id_categoria;

-- Procedimientos para CRUD cliente
select * from cliente;
create procedure sp_insertar_cliente(
p_nombre varchar(50),
p_apellido varchar(100),
p_direccion varchar(100),
p_telefono varchar(20),
p_dni varchar(20),
p_email varchar(50),
p_usuario varchar(50),
p_clave varchar(100)
)
insert into cliente (nombres, apellidos,direccion, telefono,dni,email,usuario,clave) 
values (p_nombre,p_apellido,p_direccion,p_telefono,p_dni,p_email,p_usuario,p_clave);


create procedure sp_actualizar_cliente(
p_id int,
p_nombre varchar(50),
p_apellido varchar(100),
p_direccion varchar(100),
p_telefono varchar(20),
p_dni varchar(20),
p_email varchar(50),
p_usuario varchar(50),
p_clave varchar(100)
)
update cliente set nombres =p_nombre, apellidos=p_apellido,direccion=p_direccion, 
telefono=p_telefono,dni=p_dni,email=p_email,usuario=p_usuario,clave=p_clave
where id_cliente = p_id;

create procedure sp_listar_cliente_codigo(
p_id int)
select id_cliente, nombres, apellidos, direccion,telefono,dni,email,usuario,clave from cliente 
where id_cliente = p_id;


create procedure sp_generar_codigo_cliente()
select max(id_cliente)+1 as cod_cliente from cliente;

create procedure sp_eliminar_cliente(
p_id int)
delete from cliente where id_cliente=p_id;

create procedure sp_listar_cliente()
select id_cliente, nombres, apellidos, direccion,telefono,dni,email,usuario,clave from cliente;

create procedure sp_buscar_cliente_codigo(
in p_id int)
select id_cliente, nombres, apellidos, direccion,telefono,dni,email,usuario,clave from cliente
where id_cliente=p_id;

-- procedimiento para productos

create procedure sp_listar_catalogo_productos()
select p.id_producto,p.nombre, p.descripcion,p.puntos,p.foto,p.stock,c.nombre
from productos p
inner join categorias c
on p.id_categoria=c.id_categoria;

create procedure sp_listar_productos()
select id_producto,nombre, descripcion,puntos,stock from productos;



create procedure sp_insertar_producto(
p_nombre varchar(100),
p_descripcion varchar(100),
p_puntos int,
p_stock int,
p_foto varchar(100),
p_id_categoria int
)
insert into productos(nombre, descripcion,puntos,stock,foto,id_categoria) 
values (p_nombre,p_descripcion, p_puntos, p_stock, p_foto, p_id_categoria);

create procedure sp_actualizar_producto(
p_id int,
p_nombre varchar(100),
p_descripcion varchar(100),
p_puntos int,
p_stock int,
p_foto varchar(100),
p_id_categoria int
)
update productos set nombre=p_nombre, descripcion=p_descripcion,puntos=p_puntos,
stock=p_stock,foto=p_foto,id_categoria=p_id_categoria 
where id_producto=p_id;




select * from productos;
create procedure sp_consultar_stock_producto
(p_id int,
out p_stock int)
set p_stock = (select stock from productos where id_producto=p_id);
use canje;
select * from detalle_pedido ;
create procedure sp_insertar_pedido(
p_id_cliente int,
p_id_empleado int,
p_fecha_pedido datetime,
p_total_puntos int)
insert into pedido (id_cliente, id_empleado,fecha_pedido, total_puntos) 
values (p_id_cliente,p_id_empleado,p_fecha_pedido,p_total_puntos);
select * from detalle_pedido;
create procedure sp_insertar_detalle_pedido(
p_id_pedido int,
p_id_producto int,
p_cantidad int,
p_punto_canje int,
p_total_canje int
)
insert into detalle_pedido(id_producto,id_pedido,cantidad,punto_canje,total_canje) 
values(p_id_producto,p_id_pedido,p_cantidad,p_punto_canje,p_total_canje);

create procedure sp_actualizar_stock(
p_id_producto int,
p_cantidad int)
update productos set stock = (stock - p_cantidad)
where id_producto = p_id_producto;

select * from productos;
call sp_actualizar_stock(2,200); 

select * from usuarios;

create procedure sp_consultar_producto_codigo(
p_id int)
select * from productos where id_producto=p_id;