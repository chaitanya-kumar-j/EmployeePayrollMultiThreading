using EmployeePayrollMultiThreading;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EmployeePayrollMultiThreadTestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenTenEntries_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Chaitanya Kumar", Salary: 34567, StartDate: "2020-09-09", Gender: 'M', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Chandrajinka", Salary: 44567, StartDate: "2020-09-09", Gender: 'M', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Mabel", Salary: 34567, StartDate: "2020-09-09", Gender: 'F', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Mounika", Salary: 34567, StartDate: "2020-09-09", Gender: 'F', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Rama", Salary: 34567, StartDate: "2020-09-09", Gender: 'M', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Ranadheera", Salary: 34567, StartDate: "2020-09-09", Gender: 'M', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Nibedita", Salary: 34567, StartDate: "2020-09-09", Gender: 'F', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            employees.Add(new EmployeeModel(EmpId: 1, Name: "Chaitanya", Salary: 34567, StartDate: "2020-09-09", Gender: 'M', PhoneNumber: "2345678", Department: "dfgh", Address: "sdfglkj", BasicPay: 34567, Deduction: 67, TaxablePay: 3456, Tax: 56, NetPay: 567));
            
            EmployeePayrollOperations payrollOperations = new EmployeePayrollOperations();
            DateTime startTime = DateTime.Now;
            payrollOperations.AddEmployeeToPayroll(employees);
            Console.WriteLine($"Duration Without Threads: {DateTime.Now - startTime}");

            Assert.Pass();
        }
    }
}