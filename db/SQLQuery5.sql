CREATE TABLE Fines (
    FineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    std_enroll INT NOT NULL,
    FineAmount DECIMAL(10, 2) NOT NULL,
    FineDate DATETIME NOT NULL,
    fine_paid bit NOT NULL,
	);

ALTER TABLE Fines
ADD CONSTRAINT DF_paid DEFAULT(0) FOR fine_paid

insert into Fines (std_enroll,FineAmount,FineDate,fine_paid)
Values (69420,500,21-05-2024,0);


