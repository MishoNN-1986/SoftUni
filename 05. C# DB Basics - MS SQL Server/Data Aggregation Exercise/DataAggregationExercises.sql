USE Gringotts

-- Problem 1. Records’ Count

SELECT COUNT(Id) AS [Count]
FROM WizzardDeposits 

-- Problem 2. Longest Magic Wand

SELECT MAX(MagicWandSize) AS [LongestMagicWand]
FROM WizzardDeposits 

-- Problem 3. Longest Magic Wand per Deposit Groups

SELECT w.DepositGroup,
		MAX(w.MagicWandSize) AS [LongestMagicWand]
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

--Problem 4. Smallest Deposit Group per Magic Wand Size

SELECT w.DepositGroup
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup
HAVING AVG(MagicWandSize) =
(
    SELECT MIN(WizAverageWandSize.averageWandSize)
    FROM
    (
        SELECT AVG(MagicWandSize) AS averageWandSize
        FROM WizzardDeposits
        GROUP BY DepositGroup
    ) AS WizAverageWandSize
)

-- Another solutiion

SELECT TOP(1) WITH TIES DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

-- Another solutiion

SELECT TOP(2) DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

-- Another solutiion

SELECT DepositGroup FROM (
				SELECT TOP(2) DepositGroup, AVG(MagicWandSize) AS [AvgSize]
				FROM WizzardDeposits
				GROUP BY DepositGroup
				ORDER BY [AvgSize]) AS [AvgSizeTable]



-- Problem 5. Deposits Sum

SELECT w.DepositGroup,
		SUM(w.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

-- Problem 6. Deposits Sum for Ollivander Family

SELECT w.DepositGroup,
		SUM(w.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup

-- Problem 7. Deposits Filter

SELECT w.DepositGroup,
		SUM(w.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY TotalSum DESC

-- Problem 8. Deposit Charge

SELECT w.DepositGroup,
		w.MagicWandCreator,
		MIN(w.DepositCharge) AS [MinDepositCharge]
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup,
		w.MagicWandCreator
ORDER BY w.MagicWandCreator,
		w.DepositGroup

-- Problem 9. Age Groups

SELECT CASE
           WHEN w.Age BETWEEN 0 AND 10
           THEN '[0-10]'
           WHEN w.Age BETWEEN 11 AND 20
           THEN '[11-20]'
           WHEN w.Age BETWEEN 21 AND 30
           THEN '[21-30]'
           WHEN w.Age BETWEEN 31 AND 40
           THEN '[31-40]'
           WHEN w.Age BETWEEN 41 AND 50
           THEN '[41-50]'
           WHEN w.Age BETWEEN 51 AND 60
           THEN '[51-60]'
           WHEN w.Age >= 61
           THEN '[61+]'
           ELSE 'N\A'
       END AS AgeGroup,
       COUNT(*) AS WizzardsCount
FROM WizzardDeposits AS w
GROUP BY CASE
             WHEN w.Age BETWEEN 0 AND 10
             THEN '[0-10]'
             WHEN w.Age BETWEEN 11 AND 20
             THEN '[11-20]'
             WHEN w.Age BETWEEN 21 AND 30
             THEN '[21-30]'
             WHEN w.Age BETWEEN 31 AND 40
             THEN '[31-40]'
             WHEN w.Age BETWEEN 41 AND 50
             THEN '[41-50]'
             WHEN w.Age BETWEEN 51 AND 60
             THEN '[51-60]'
             WHEN w.Age >= 61
             THEN '[61+]'
             ELSE 'N\A'
         END

-- Shorter solution

SELECT grouped.AgeGroup,
       COUNT(*) AS WizzardsCount
FROM
(
    SELECT CASE
               WHEN Age BETWEEN 0 AND 10
               THEN '[0-10]'
               WHEN Age BETWEEN 11 AND 20
               THEN '[11-20]'
               WHEN Age BETWEEN 21 AND 30
               THEN '[21-30]'
               WHEN Age BETWEEN 31 AND 40
               THEN '[31-40]'
               WHEN Age BETWEEN 41 AND 50
               THEN '[41-50]'
               WHEN Age BETWEEN 51 AND 60
               THEN '[51-60]'
               WHEN Age >= 61
               THEN '[61+]'
               ELSE 'N\A'
           END AS AgeGroup
    FROM WizzardDeposits
) AS grouped
GROUP BY grouped.AgeGroup; 

-- Problem 10. First Letter

SELECT LEFT(FirstName, 1) AS FirstLetter
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)
ORDER BY FirstLetter; 

-- Problem 11. Average Interest 

SELECT w.DepositGroup,
       w.IsDepositExpired,
       AVG(1.0 * w.DepositInterest) AS [AverageInterest]
FROM WizzardDeposits AS w
WHERE DepositStartDate > '01/01/1985'
GROUP BY w.DepositGroup,
         w.IsDepositExpired
ORDER BY w.DepositGroup DESC,
         w.IsDepositExpired; 

-- Problem 12. Rich Wizard, Poor Wizard

SELECT SUM(ws.Difference) AS [SumDifference]
FROM
(
    SELECT DepositAmount -
    (
        SELECT DepositAmount
        FROM WizzardDeposits AS wsd
        WHERE wsd.Id = wd.Id + 1
    ) AS Difference
    FROM WizzardDeposits AS wd
) AS ws; 

-- LEAD Solution

SELECT SUM(WizardDep.Difference) AS [SumDifference]
FROM
(
    SELECT FirstName,
           DepositAmount,
           LEAD(FirstName) OVER(ORDER BY Id) AS GuestWizard,
           LAG(FirstName) OVER(ORDER BY Id) AS GuestLagWizard,
           LEAD(DepositAmount) OVER(ORDER BY Id) AS GuestDeposit,
           LAG(DepositAmount) OVER(ORDER BY Id) AS GuestLagDeposit,
           DepositAmount - LEAD(DepositAmount) OVER(ORDER BY Id) AS Difference
		   --DepositAmount - LAG(DepositAmount) OVER (ORDER BY Id) AS Difference -- is same calculation BUT NEGATIVE

    FROM WizzardDeposits
) AS WizardDep

USE SoftUni

-- Problem 13. Departments Total Salaries

SELECT e.DepartmentID,
		SUM(e.Salary) AS [TotalSalary]
FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID

-- Problem 14. Employees Minimum Salaries

SELECT e.DepartmentID,
		MIN(e.Salary) AS [MinimumSalary]
FROM Employees AS e
WHERE DepartmentID = 2  -- LIKE '[2, 5, 7]'
		OR DepartmentID = 5
		OR DepartmentID = 7
		AND HireDate > '01/01/2000'
GROUP BY e.DepartmentID

-- Problem 15. Employees Average Salaries

SELECT * 
INTO NewTable
FROM Employees
WHERE Salary > 30000

DELETE 
FROM NewTable
WHERE ManagerID = 42

UPDATE NewTable
SET DepartmentID += 5000
WHERE DepartmentID = 1

SELECT n.DepartmentID,
		AVG(n.Salary) AS [AverageSalary]
FROM NewTable AS n
GROUP BY n.DepartmentID

/* One query
SELECT DepartmentID,
       AVG(CASE
               WHEN DepartmentID % 2 != 0
               THEN Salary + 5000
               ELSE Salary
           END) AS AverageSalary
FROM Employees
WHERE Salary > 30000
      AND ManagerID != 42
GROUP BY DepartmentID;
*/

-- Problem 16. Employees Maximum Salaries

SELECT e.DepartmentID,
		MAX(e.Salary) AS [MaxSalary]
FROM Employees AS e
WHERE Salary < 30000 OR Salary > 70000
GROUP BY e.DepartmentID
-- HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

-- Problem 17. Employees Count Salaries

SELECT COUNT(Salary) AS [Count]
FROM Employees 
WHERE ManagerID IS NULL

-- Problem 18. 3rd Highest Salary

SELECT salaries.DepartmentID,
       salaries.Salary
FROM
(
    SELECT DepartmentID,
           Salary, 
		 --DENSE_RANK() OVER(ORDER BY Salary DESC) AS Rank
           DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS Rank
    FROM Employees
    GROUP BY DepartmentID,
             Salary
) AS salaries
WHERE Rank = 3
GROUP BY salaries.DepartmentID,
         salaries.Salary;

-- Problem 19. Salary Challenge

SELECT TOP 10 FirstName,
		LastName,
		DepartmentID
FROM Employees AS e
WHERE Salary >
(
    SELECT AVG(Salary)
    FROM Employees AS em
    WHERE e.DepartmentID = em.DepartmentID
)
ORDER BY e.DepartmentID




 