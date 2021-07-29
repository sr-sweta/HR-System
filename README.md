# HR-System
This is an HR-System which can be used to keep the employee details and employee categories in an organisation. Keeping in mind about my college staff management system I made it. Its backend is made using my system local SQL Server.

[![GitHub watchers](https://img.shields.io/github/watchers/sr-sweta/HR-System.svg?style=social&label=Watch&maxAge=2592000)](https://GitHub.com/sr-sweta/HR-System/watchers/)

**Made it using**
---
- ASP
- DOTNET
- C#
- Microsoft SQL Server 2019
- HTML
- CSS
- Bootstrap
- Javascript


## Login Credentials

Login can only be done by `User` i.e. the backend handler who has been given access.

It needs `username` and `Password` for login. 


![Screenshot (796)](https://user-images.githubusercontent.com/70569920/127445930-c184f748-e1cf-4b2d-b6b1-5a05d59e5fa8.png)



## Navbar

![Screenshot (798)](https://user-images.githubusercontent.com/70569920/127456231-3044318d-0b3e-4e04-a5a5-e0b4c096a5dd.png)



## Search Employee

After login the first page appears contains the search bar. 

- `Name` will help to show all names which contains the provided name string.
- `Type` dropdown lists all the types of employee.
- `Category` dropdown lists all the categories of employee.
- `Include Delete` checkbox will list all employees who is either no longer works in the college or whose account is not active.
- `New Employee` is to create new employees.


![Screenshot (797)](https://user-images.githubusercontent.com/70569920/127456933-5d0a000a-0f00-43ec-8795-1beaa8123935.png)





![Screenshot (799)](https://user-images.githubusercontent.com/70569920/127477095-de778d8a-8a44-40ab-b89f-8edbec8f6294.png)



## Insert New Employee

New employee creation needs all details of employee.
`IsActive` 
- If checked that means his/her account is active and it can be used by the employee for any purpose.
- If unchecked that means his/her account no longer exits in the system.
No employee data can be permanently deleted from the database. Only his/her account can be activate or inactive.
`Document upload` it for uploading the proofs a=or any credentials.


![Screenshot (800)](https://user-images.githubusercontent.com/70569920/127477856-10648406-b451-425e-aa71-da9ffac0eccd.png)



## Employee Types

New `Employee Type` can directly be inserted. And any employee type data can be altered.
`CreatedBy` is the id of the user who created it.
`LastUpdatedBy` is the id of the user who last updated that employee type data.


![Screenshot (801)](https://user-images.githubusercontent.com/70569920/127478952-2e15cff8-0d45-4f72-b43a-97059bf0d4d7.png)



## Employee Category

New `Employee Category` can directly be inserted. And any employee category data can be altered.
`CreatedBy` is the id of the user who created it.
`LastUpdatedBy` is the id of the user who last updated that employee category data.


![Screenshot (802)](https://user-images.githubusercontent.com/70569920/127479524-25b86502-d595-4de0-97a6-b26a7a1286c3.png)



## Document Type

New `Document Type` can directly be inserted. And any document type data can be altered.
`CreatedBy` is the id of the user who created it.
`LastUpdatedBy` is the id of the user who last updated that document type data.


![Screenshot (803)](https://user-images.githubusercontent.com/70569920/127479833-87afd9a4-0c0f-4595-a5a3-83115b7aab60.png)



## Updation

Any employee data can be updated in any way.


![Screenshot (805)](https://user-images.githubusercontent.com/70569920/127480807-95b23043-ccb6-4e4b-92fc-6e08c0060fd7.png)



Only `Name` and `IsActive` data can be updated for `Employee Type`, `Employee Category` and `Document Type`.


![Screenshot (804)](https://user-images.githubusercontent.com/70569920/127480176-a6967583-9860-4e80-945b-32dfc8e96a0b.png)




