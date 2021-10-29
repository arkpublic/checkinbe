﻿CREATE TABLE RESTAURANT(
		ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT ,
		RESTAURANT_ID VARCHAR (10) NOT NULL,
		RESTAURANT_NAME VARCHAR(45) NOT NULL,
		RESTAURANT_PHONE VARCHAR (45),
		RESTAURANT_ADDRESS VARCHAR (100), 
		RESTAURANT_VISIBILITY INT NOT NULL,
		CONSTRAINT RESTAURANT_ID_UNIQUE UNIQUE (RESTAURANT_ID)
);