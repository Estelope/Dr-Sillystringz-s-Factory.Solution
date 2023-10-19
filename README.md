# HairSalon
MVC application connected to a MySQL database using EF core w/ migrations 

 #### By Estevan Lopez

## Technologies Used
* Github
* C#
* ASP.NET Core MVC framework
* VS Code
* MySQL
* EF Core


## Description
The application utilizes the .NET Core MVC framework to create a system for monitoring a Factory and its machinists who handle different machines. It features two interconnected classes (many to many) to display and record the data effectively as well as a connected database using EF core to communicate with MySQL


### Set Up and Run Project

Git instructions:
1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Within the production directory "Factory", run `dotnet ef database update` in the terminal.

 create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Factory;uid=[yourid];pwd=[yourpw];"
  }
}
```

5. Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. 

## Known Bugs

* If it crashes clone the repository and start again
* email the host if there are re-occuring issues or any questions

## licensing info 
*Copyright (c) 10/18/2023 Estevan Lopez
*MIT license 