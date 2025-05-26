create database EShop

CREATE TABLE Customer
(
  Id INT NOT NULL,
  Name INT NOT NULL,
  Email INT NOT NULL,
  Address INT NOT NULL,
  CustomerId INT NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE OrderT
(
  Id INT NOT NULL,
  order_date INT NOT NULL,
  total_price INT NOT NULL,
  CustomerId_ INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (CustomerId_) REFERENCES Customer(Id)
);

CREATE TABLE Shipping_Address
(
  street_address INT NOT NULL,
  city INT NOT NULL,
  state INT NOT NULL,
  country INT NOT NULL,
  postal_code INT NOT NULL,
  CustomerId_ INT NOT NULL,
  FOREIGN KEY (CustomerId_) REFERENCES Customer(Id)
);

CREATE TABLE Payment_Information
(
  Id INT NOT NULL,
  payment_method INT NOT NULL,
  card_number INT NOT NULL,
  expiration_date INT NOT NULL,
  CVV INT NOT NULL,
  CustomerId_ INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (CustomerId_) REFERENCES Customer(Id)
);

CREATE TABLE Categorie
(
  Id INT NOT NULL,
  Name INT NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE Phone
(
  Id INT NOT NULL,
  PhoneNumber INT NOT NULL,
  CustomerId INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
);

CREATE TABLE Product
(
  Id INT NOT NULL,
  Name INT NOT NULL,
  Description INT NOT NULL,
  Price INT NOT NULL,
  Quantity INT NOT NULL,
  CategoryId INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (CategoryId) REFERENCES Categorie(Id)
);

CREATE TABLE Order_Item
(
  Id INT NOT NULL,
  Quantity INT NOT NULL,
  price INT NOT NULL,
  OrderId INT NOT NULL,
  ProductId INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (OrderId) REFERENCES OrderT(Id),
  FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

CREATE TABLE Review
(
  Rating INT NOT NULL,
  Id INT NOT NULL,
  Comments INT NOT NULL,
  ProductId INT NOT NULL,
  CustomerId INT NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (ProductId) REFERENCES Product(Id),
  FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
);