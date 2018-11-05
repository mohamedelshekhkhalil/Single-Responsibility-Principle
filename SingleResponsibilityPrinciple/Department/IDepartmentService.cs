using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleResponsibilityPrinciple.Department
{
    public interface IDepartmentService
    {
        // The Meaning Of Single Responsibility Principle is that all functions must be related to the class
        void Insert(DepartmentDTO Department);
        void Update(DepartmentDTO Department);
        void Delete(DepartmentDTO Department);
        DepartmentDTO GetDepartmentById(long Id);

        // You cannot add any functions that access the employee service because this is a Single Responsibility Principle
    }
}