using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollMultiThreading
{
    public class EmployeePayrollOperations
    {
        public List<EmployeeModel> employees = new List<EmployeeModel>();

        public void AddEmployeeToPayroll(List<EmployeeModel> employees)
        {
            foreach (EmployeeModel employee in employees)
            {
                this.AddEmployeePayroll(employee);
            }
        }
        public void AddEmployeePayroll(EmployeeModel employee)
        {
            employees.Add(employee);
        }
    }
}
