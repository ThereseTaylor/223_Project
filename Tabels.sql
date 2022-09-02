USE dbPUKKI_RENTAL
GO

CREATE TABLE VEHICLE_COLOUR(
    ColourID int IDENTITY(1,1) PRIMARY KEY,
    Colour_Name varchar(10)
);

CREATE TABLE VEHICLE_TYPE(
    TypeID int IDENTITY(1,1) PRIMARY KEY,
    Type_Description varchar(35)
);

CREATE TABLE VEHICLE_MODEL(
    ModelID int IDENTITY(1,1) PRIMARY KEY,
    Model_Description varchar(25)
);

CREATE TABLE VEHICLE(
    VehicleID int IDENTITY(1,1) PRIMARY KEY,
    TypeID int FOREIGN KEY REFERENCES VEHICLE_TYPE(TypeID),
    ModelID int FOREIGN KEY REFERENCES VEHICLE_MODEL(ModelID),
    ColourID int FOREIGN KEY REFERENCES VEHICLE_COLOUR(ColourID),
    Registration_Plate varchar(10),
    Purchase_Price money,
    Purchase_Date date,
    Rental_Price mone,
    Rental_Status int
);

CREATE TABLE TOWN(
   TownID int IDENTITY(1,1) PRIMARY KEY,
   Town_Name varchar(35)
);

CREATE TABLE ADDRESS(
    AddressID int IDENTITY(1,1) PRIMARY KEY,
    TownID int FOREIGN KEY REFERENCES TOWN(TownID),
    Street_Number varchar(5),
    Street_Name varchar(35)
);

CREATE TABLE CLIENT(
    ClientID int IDENTITY(1,1) PRIMARY KEY,
    ClientLN varchar(35),
    ClientFN varchar(35),
    ClientID_Number char(13),
    Tel_Number varchar(10),
    Email varchar(35),
    AddressID int FOREIGN KEY REFERENCES ADDRESS(AddressID),
);

CREATE TABLE RENTAL_TRANSACTION(
    TransactionID int IDENTITY(1,1) PRIMARY KEY,
    VehicleID int FOREIGN KEY REFERENCES VEHICLE(VehicleID),
    ClientID int FOREIGN KEY REFERENCES CLIENT(ClientID),
    Transaction_Price money,
    Transaction_Date date,
    Return_Date date,
    Return_Status char(1)
);
