Course Notes

- Download Docker
- Download Azure Data Studio or another client
- Run the following on the command line to pull Ms SQL
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Dometrain#123" -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest

create database podcasts

create table Podcasts
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Title NVARCHAR(MAX) NOT NULL
)

INSERT INTO Podcasts (Title)
VALUES
('Database podcast'),
('Docker podcast');
 