CREATE DATABASE FOOD_DELIVERY_BRANCHE;

CREATE TABLE position (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(100) NOT NULL
);

CREATE TABLE department (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(100) NOT NULL
);

CREATE TABLE employee (
	id INT IDENTITY(1,1) PRIMARY KEY,
	firstname VARCHAR(20) NOT NULL,
	middlename VARCHAR(20),
	lastname VARCHAR(20) NOT NULL,
	adress VARCHAR(150),
	phone_number VARCHAR(13) NOT NULL,
	salary INT NOT NULL,
	id_department INT FOREIGN KEY
		REFERENCES department(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_position INT FOREIGN KEY
		REFERENCES position(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE client (
	id INT IDENTITY(1,1) PRIMARY KEY,
	firstname VARCHAR(20) NOT NULL,
	middlename VARCHAR(20),
	lastname VARCHAR(20) NOT NULL,
	default_adress VARCHAR(150),
	default_phone_number VARCHAR(13) NOT NULL,
	preferences VARCHAR(500)
);

CREATE TABLE restaurant (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(50) NOT NULL,
	adress VARCHAR(150) NOT NULL,
	menu VARCHAR(2000),
	_description VARCHAR(200)
);

CREATE TABLE _order (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_client INT FOREIGN KEY
		REFERENCES client(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_restaurant INT FOREIGN KEY
		REFERENCES restaurant(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	order_list VARCHAR(500) NOT NULL,
	destination_adress VARCHAR(150) NOT NULL,
	phone_number VARCHAR(13) NOT NULL,
	payment_amount INT NOT NULL
);

CREATE TABLE act_of_order (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_order INT FOREIGN KEY
		REFERENCES _order(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_employee INT FOREIGN KEY
		REFERENCES employee(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	_date DATE,
	payment_amount INT NOT NULL,
	is_done BIT DEFAULT 0
);

CREATE TABLE receipt (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_order INT FOREIGN KEY
		REFERENCES _order(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	order_list VARCHAR(500) NOT NULL,
	destination_adress VARCHAR(150),
	phone_number VARCHAR(13),
	payment_amount INT NOT NULL
);

CREATE TABLE feedback (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_client INT FOREIGN KEY
		REFERENCES client(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_order INT FOREIGN KEY
		REFERENCES _order(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	evaluation INT NOT NULL,
	feedback VARCHAR(100)
);