Select first_name, incentive amount from employee and incentives table for all employed even if they didn't get incentives:
csharp
Copy code
var query = from employee in EmployeesData
            join incentive in Incentives on employee.ID equals incentive.ID into joined
            from j in joined.DefaultIfEmpty()
            select new
            {
                employee.FirstName,
                IncentiveAmount = j == null ? 0 : j.IncentiveAmount
            };
Select first_name, incentive amount from employee and incentives table for all employees even if they didn't get incentives and set incentive amount as 0 for those employees who didn't get incentives:
This query is the same as the previous one.

Select first_name, incentive amount from employee and incentives table for all employees who got incentives using left join:
csharp
Copy code
var query = from employee in EmployeesData
            join incentive in Incentives on employee.ID equals incentive.ID into joined
            from j in joined
            select new
            {
                employee.FirstName,
                j.IncentiveAmount
            };
Select TOP 2 salary from employee table:
csharp
Copy code
var query = EmployeesData.OrderByDescending(e => e.Salary).Take(2).Select(e => e.Salary);
Select TOP N salary from employee table:
This would require passing the value of N as a variable.

Select 2nd Highest salary from employee table:
csharp
Copy code
var secondHighestSalary = EmployeesData.OrderByDescending(e => e.Salary).Skip(1).Take(1).Select(e => e.Salary).FirstOrDefault();
Select Nth Highest salary from employee table:
Similarly to TOP N, this would require passing the value of N as a variable.

Select First_Name, LAST_NAME from employee table as separate rows:
csharp
Copy code
var query = from employee in EmployeesData
            select new
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };
What is the difference between UNION and UNION ALL?
UNION combines the results of two queries and removes duplicates, while UNION ALL combines the results of two queries but does not remove duplicates.

Select employee details from employee table if data exists in incentive table:
csharp
Copy code
var query = from employee in EmployeesData
            join incentive in Incentives on employee.ID equals incentive.ID
            select employee;
How to fetch data that are common in two query results?
You can use the Intersect method in LINQ to find the common elements between two sequences.

Get Employee ID's of those employees who didn't receive incentives without using subquery?
csharp
Copy code
var query = EmployeesData.Where(emp => !Incentives.Select(inc => inc.ID).Contains(emp.ID)).Select(emp => emp.ID);
Select 20 % of salary from John, 10% of Salary for Roy and for other 15 % of salary from employee table:
csharp
Copy code
var query = from employee in EmployeesData
            select new
            {
                employee.FirstName,
                PercentageSalary = employee.FirstName == "John" ? employee.Salary * 0.2 :
                                    employee.FirstName == "Roy" ? employee.Salary * 0.1 :
                                    employee.Salary * 0.15
            };
Select Banking as 'Bank Dept', Insurance as 'Insurance Dept' and Services as 'Services Dept' from employee table:
csharp
Copy code
var query = from employee in EmployeesData
            select new
            {
                Department = employee.Deparment == "Banking" ? "Bank Dept" :
                             employee.Deparment == "Insurance" ? "Insurance Dept" :
                             "Services Dept"
            };
These LINQ queries should help you achieve the desired results based on the provided questions. Let me know if you need further clarification or assistance with any specific query.







