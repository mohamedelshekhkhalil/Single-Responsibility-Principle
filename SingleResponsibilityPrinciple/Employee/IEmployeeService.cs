using SingleResponsibilityPrinciple.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleResponsibilityPrinciple.Department
{
    public interface IEmployeeService
    {
        // The Meaning Of Single Responsibility Principle is that all functions must be related to the class
        void Insert(EmplyeeDTO Emplyee);
        void Update(EmplyeeDTO Emplyee);
        void Delete(EmplyeeDTO Emplyee);
        EmplyeeDTO GetEmplyeeById(long Id);

        // You cannot add ant functions tha access the deparment service because this is a Single Responsibility Principle
    }
}