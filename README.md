# Bookish
This .NET application allows you to keep track of books and members and to allow a member to checkout a book. It uses a postgresql database.

## Setup
You will need to have PostgreSQL and PGAdmin installed

To create the database run the following two commands

dotnet ef migrations add BookishDB
dotnet ef database update

## Running the Application
To run this application, run the command dotnet run