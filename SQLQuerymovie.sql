CREATE TABLE Movie
(
MID int NOT NULL AUTO INCREAMENT ,
MName varchar(50) PRIMARY KEY,
FOREIGN KEY ('MActor') REFERENCES Actor (aName'),
FOREIGN KEY (MProducer) REFERENCES Producer (pName) 
);

INSERT INTO Movie (MID,MName,MActor,MProducer) VALUES (1,'Lagaan','Amir Khan','Amir Khan'); 
INSERT INTO Movie (MID,MName,MActor,MProducer) VALUES (2,'Taare Zameen Par','Amir Khan','Amir Khan'); 
INSERT INTO Movie (MID,MName,MActor,MProducer) VALUES (3,'Taare Zameen Par','Darsheel Safary','Amir Khan'); 
INSERT INTO Movie (MID,MName,MActor,MProducer) VALUES (4,'Agantuk','Utpal Dutt','Satyajit Ray'); 
INSERT INTO Movie (MID,MName,MActor,MProducer) VALUES (5,'Hirak Rajar Deshe','Utpal Dutt','Govt. of WB'); 
