CREATE DATABASE FOOD_DELIVERY_MAIN_OFFICE;

USE FOOD_DELIVERY_MAIN_OFFICE;

CREATE TABLE position (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(100) NOT NULL
);

CREATE TABLE department (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(100) NOT NULL
);

CREATE TABLE branche (
	id INT IDENTITY(1,1) PRIMARY KEY,
	_name VARCHAR(100) NOT NULL,
	adress VARCHAR(150) NOT NULL
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
		ON UPDATE CASCADE,
	id_branche INT FOREIGN KEY
		REFERENCES branche(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE payment_info (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_employee INT FOREIGN KEY
		REFERENCES employee(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	payer VARCHAR(50) NOT NULL,
	payer_bank VARCHAR(200) NOT NULL,
	recipient VARCHAR(50) NOT NULL,
	recipient_bank VARCHAR(200) NOT NULL,
	assignment VARCHAR(100),
	amount INT NOT NULL
);

CREATE TABLE act_of_employment (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_employee INT NOT NULL,
	id_department INT FOREIGN KEY
		REFERENCES department(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_position INT FOREIGN KEY
		REFERENCES position(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	id_branche INT FOREIGN KEY
		REFERENCES branche(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	salary INT NOT NULL,
	_date DATE,
	time_graphic VARCHAR(500) NOT NULL
);

CREATE TABLE act_of_dismissal (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_employee INT FOREIGN KEY
		REFERENCES employee(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	reason VARCHAR(200),
	_date DATE
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

CREATE TABLE _order (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_client INT FOREIGN KEY
		REFERENCES client(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	order_list VARCHAR(500) NOT NULL,
	destination_adress VARCHAR(150) NOT NULL,
	phone_number VARCHAR(13) NOT NULL,
	payment_amount INT NOT NULL
);

CREATE TABLE act_of_order (
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_order INT NOT NULL,
	id_employee INT NOT NULL,
	id_branche INT NOT NULL,
	_date DATE,
	payment_amount INT NOT NULL,
	is_done BIT DEFAULT 0
);