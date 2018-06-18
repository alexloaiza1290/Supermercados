create database canje;
use canje;

create table categorias(
	id_categoria int not null auto_increment primary key,
	nombre varchar(30) null,
	descripcion varchar(300) null
);
insert into categorias (nombre, descripcion) values ('lacteo','Bebidas especiales con leche');

create table cargo(
id_cargo int not null auto_increment primary key,
nombre varchar(50) not null,
descripcion varchar(100) not null
);

insert into cargo (nombre, descripcion) values ('administrador','persona que podra realizar diferentes opciones');

create table cliente(
	id_cliente int not null primary key auto_increment,
	nombres varchar(100) null,
	apellidos varchar(100) null,
	direccion varchar(100) null,
	telefono varchar(10) null,
	dni varchar(8) null,
	email varchar(100) null,
	usuario varchar(45) null,
	clave varchar(45) null
    );
    
    insert into cliente (nombres, apellidos, direccion, telefono,dni,email,usuario, clave)
    values('alex','loaiza saldivar','san martin de porres','3423234','23232323','alexloaiza.90','alex','camila');

create table productos(
	id_producto int not null auto_increment primary key,
	nombre varchar(50) null,
	descripcion varchar(50) null,
	puntos int null,
	stock int null,
	foto varchar(100) null,
	id_categoria int null,
    foreign key (id_categoria) references categorias(id_categoria)
    on delete cascade
    );
    insert into productos (nombre, descripcion, puntos, stock, foto,id_categoria) 
    values ('leche evaporada','leche gloria de 500gr',1000,500,'pilsentrujillo.jpg',1);
create table empleado(
	id_empleado int not null primary key auto_increment,
	nombre varchar(50) null,
	apellidos varchar(50) null,
    id_cargo int not null,
    foreign key (id_cargo) references cargo(id_cargo)
    on delete cascade
    );
    
    insert into empleado (nombre, apellidos,id_cargo) values ('rolando','saldivar loaiza',1);
    
create table pedido(
	id_pedido int not null auto_increment primary key,
	id_cliente int null ,
	id_empleado int null,
	fecha_pedido date null,
	total_puntos float null,
    foreign key (id_cliente) references cliente(id_cliente)
    on delete cascade,
    foreign key (id_empleado) references empleado(id_empleado)
    on delete cascade
    );
    insert into pedido (id_cliente,id_empleado,fecha_pedido,total_puntos) values (1,1,'2018/12/12',500);

create table detalle_pedido(
	id_detalle int not null primary key auto_increment,
	id_pedido int null, 
	id_producto int null,
	cantidad int null,
	punto_canje int null,
	total_canje int null,
    foreign key (id_pedido) references pedido(id_pedido)
    on delete cascade,
    foreign key (id_producto) references productos(id_producto)
    on delete cascade
    );
    insert into detalle_pedido (id_pedido,id_producto,cantidad,punto_canje,total_canje) 
    values(1,1,4,500,2000);

create table usuarios(
	id_usuario int not null auto_increment primary key,
	login varchar(50) null,
	passwd varchar(50) null,
	id_empleado int null, 
    foreign key (id_empleado) references empleado(id_empleado)
    on delete cascade
    );
insert into usuarios (login, passwd,id_empleado) values ('admin','admin',1);