using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeModel
    {
        private char gender;
        private string phoneNumber;
        private string department;

        public EmployeeModel(int EmpId, string Name, int Salary, string StartDate, char Gender, string PhoneNumber, string Department, string Address, int BasicPay, int Deduction, int TaxablePay, int Tax, int NetPay)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.Salary = Salary;
            this.StartDate = StartDate;
            gender = Gender;
            phoneNumber = PhoneNumber;
            department = Department;
            this.Address = Address;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;
        }

        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string StartDate { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public int Department { get; set; }
        public string Address { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
    }
}
