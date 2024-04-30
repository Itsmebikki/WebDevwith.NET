# WebDevwith.NET
1. WWW early 1990s
2. ASP-MS, JSP-SUN
3. .NET Framework -early 2000 - supported windows only,last version 4.8
4. ASP.NET(Web Forms)
5. MVC (Model View Controller)-2006-7 ,-introduced in .Net 3.5
6. ASP.NET MVC -2008

7. 2015/16 - .NET Core(cross  platform support,opensource)
8. ASP.NET Core
9. 2020 - .NET 5, 2021 - .NET 6,2022 - .NET 7,2023 - .NET 8

# SDLC
## Environments(Physical Server and app URLs)
CollegeMonitor -https://collegemonitor.com

1. Developer - Local : Dev environment(localhost)
2. QA - Code changes deployed, Test(Tst) Environment(https://tst.collegemonitor.com)
3. INT - All Code Changes, Integration environment(https:://int.collegemonitor.com)
4. UAT - PO/TPO/BA, User Acceptance Testing (https:://uat.collegemonitor.com)
5. PROD - Production Environment(https://collegemonitor.com)

### JQuery is the javascript library 

### CollegeMonitor Requirements

## Entities/Tables/Model
1. Session - Id, Title, Startdate, Duration
2. Course - Id, Name, Textbook, CreditHrs
3. Student - Id, Name, Address, Program, Semester
4. Faculty - Id, Name, Department

>Course has multiple classes(one to many). 
>Student can take multiple courses and a course  can have multiple students(many to    many).
