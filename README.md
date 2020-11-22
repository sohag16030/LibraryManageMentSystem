# Library Mangement System

In this project you will build a Library Management System (LMS) for a university. This must be a web app hosted in the cloud. The primary language you use for server implementation must be C#. You do not have to use Spring, but you need to exercise the principles, patterns, and methodologies that you learn in the class, such as DI, AOP, MVC, ORM, and transactions. You must use either a relational database, or Datastore if you choose AppEngine.


If any feature described below is unclear or ambiguous, and you fail to get a clear answer from the instructor or TA, you can use your best judgement to interpret and add the missing details, provided that you clearly document and explain your reasoning in the product report.

## Functional Requirements

This app manages many aspects of a university library system, including cataloging, search, circulation, and waiting list. The interface must be web based, and the server needs to be hosted on the cloud, and accessible from anywhere with Internet connection.

## Users and Authentication

There are two roles of users, librarian.

1. A librarian manages cataloging, and can assist circulation as well.
2. A patron is a customer of the library. He can search for books, borrow and returns books.
3. For simplicity, we allow any user with any email address to be able to create his account using an email as the username, and password of his choice. The user also needs to provide a university ID of 6 digits.
4. Your app must send an email to the user with a verification code. The user needs to use that verification code to complete his account registration. A registered user cannot really use features in the system until his account is verified. A confirmation email must be sent to the user after completion of account verification.
5. For simplicity, we only and automatically register any user with an SJSU email account (@sjsu.edu) to be a librarian.  A librarian cannot be a patron, which means he has to use a different email to register if he needs a patron account as well.
6. No two patrons can have the same university ID, neither can two librarians.

## Applies 
	 ● Repository, Unit Of Work Design pattern.
     ● DataTable with ajax, Theme Integration  AdminLTE. 
     ● Asp.net Core, Entity Framework Core, Autofac for  Dependency Injection.

## Official Documentation of Framework

Documentation for the framework can be found on the 
[asp.net core  website](https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-5.0&tabs=windows)

## Contribution for the project

    1. Fork it
    2. Create your feature branch (git checkout -b my-new-feature)
    3. Make your changes
    4. Run the tests, adding new ones for your own code if necessary (phpunit)
    5. Commit your changes (git commit -am 'Added some feature')
    6. Push to the branch (git push origin my-new-feature)
    7. Create new Pull Request


## Security Vulnerabilities of framework

If you discover a security vulnerability within asp.net core, please send an e-mail to Taylor Otwell at shohag.mbstu.it16030@gmail.com. All security vulnerabilities will be promptly addressed.

## Security Vulnerabilities of project

If you discover a security vulnerability within the project, please send an e-mail to MD Shohag at sohag.mbstu.it16030@gmail.com. All security vulnerabilities will be promptly addressed.


## Project License

The project is available to be used freely for personal and educational purposes, cloning the project does not gives you any rights to sell it online/offline.

## System Requirement
System Requirements
The following topic describes the system requirements for Syncfusion ASP.NET Core platform.

### Operating Systems

Windows 7 SP1 and later
Windows 8.1
Windows 10 Version 1607 and later
Windows Server 2008 R2 SP1 (Full Server or Server Core)
Windows Server 2012 SP1 (Full Server or Server Core)
Windows Server 2012 R2 (Full Server or Server Core)
Windows Server 2016 (Full Server, Server Core, or Nano Server)
Mac OS X 10.11, 10.12*
Red Hat Enterprise Linux 7
Ubuntu 14.04, 16.04, 17

### Hardware Environment
Processor: x86 or x64
RAM : 512 MB (minimum), 1 GB (recommended)
Hard disk: up to 2 GB of available space may be required. However, 300 MB free space is required in boot drive even if you are installing in other drive.

### Development Environment
Microsoft Visual Studio 2015 Update 3 (minimum) , 2017 version latest (15.6.4), 2019.
.NET Framework : Minimum .NET 4.5.1 upto .NET 4.7 .
Command Line (Optional. Necessary for command line deployment)
Visual Studio Code (optional text-editor)
SQL Server 2008 Express (optional)

## How can I support developers ?
* Star our GitHub repo :star:
* Create pull requests, submit bugs, suggest new features or documentation updates :wrench:
* Hire us for your next project :heart:

## Installation

It is preferred to have git setup installed on your local system.

If you have git on your local, run git clone https://github.com/sohag16030/LibraryManageMentSystem
