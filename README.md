\#  Clinic Management System



A fully functional Windows Forms application built with C# and SQL Server to manage clinic operations including patient records, visits, doctors, and activity logs.



This project demonstrates database handling, UI management, state control, and structured application architecture in a real-world scenario.



---



\##  System Overview



The system allows clinic administrators to:



 Register and manage patients

 Drop and restore patients

 Record and manage patient visits

 Track doctors

 Monitor real-time dashboard statistics

 Log system activity

 Manage secure admin login



---



\##  Technical Highlights



 Custom form loading system with form caching

 Dashboard counters auto-update

Soft-delete system (Drop/Restore patients)

Activity logging implementation

Reusable UserControls

SQL Server database integration

Connection handling via `DBaccess` class

Session management using `UserSession`



---



\ Tech Stack



| Technology | Purpose |

|------------|----------|

C# | Application Logic 

 .NET Framework | Application Runtime |

 Windows Forms | UI |

 SQL Server | Database |

 ADO.NET  Database Communication |



---



\##  Architecture Approach



Separation of concerns (UI, DB access, session management)

Reusable components (UserControls)

Encapsulated database operations

Centralized dashboard logic

Controlled state transitions (Drop/Restore patients)



---



\##  Key Components



PatientsForm – Patient operations

PatientVisitControl – Visit recording

DoctorsForm – Doctor management

Dashboard – System statistics

DBaccess – All database operations

UserSession – User tracking

ActivityForm – Logs system activity



---



\##  Drop \& Restore Logic



Instead of permanently deleting patients, the system:

Moves dropped patients to a DroppedPatients table

Allows restoration with integrity checks

Prevents duplicate patient keys

Prompts the user before restoring



This demonstrates data integrity awareness and real-world system design.



---



\##  How To Run



1\. Open ClinicManagementProject.sln in Visual Studio

2\. Restore NuGet packages if required

3\. Set up SQL Server database

4\. Update the connection string in App.config

5\. Run the application



---



\##  What This Project Demonstrates



 Database CRUD operations  

 Business rule implementation  

 State management  

 UI control \& navigation logic  

 Basic system architecture design  

 Error handling  

 Logging mechanisms  



---



\##  Author



Developed by \*\*Thabiso Kgole\*\*



---



\##  Future Improvements



\- Role-based access control

\- Export reports to PDF

\- Enhanced UI styling

\- Data validation framework

\- LINQ / Entity Framework version



---



\##  License



This project is built for learning and portfolio demonstration purposes.



