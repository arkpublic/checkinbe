CREATE TABLE FOOD(
	ID INT PRIMARY KEY  NOT NULL AUTO_INCREMENT,
	FOOD_ID VARCHAR (45) NOT NULL,
	FOOD_SUBTITLE VARCHAR (45) NOT NULL,
	FOOD_PRICE FLOAT NOT NULL,
	FOOD_SIZE INT(12) NOT NULL,
	FOOD_VISIBILITY INT NOT NULL,
	CONSTRAINT FOOD_ID_UNIQUE UNIQUE(FOOD_ID)
	);