BACKUP DATABASE SoftUni TO DISK = 'C:\SoftUni\Databases Basics - MS SQL Server - September 2019\Data Definition and Datatypes Exercise\softuni-backup.bak';

USE CarRental;

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni FROM DISK = 'C:\SoftUni\Databases Basics - MS SQL Server - September 2019\Data Definition and Datatypes Exercise\softuni-backup.bak';