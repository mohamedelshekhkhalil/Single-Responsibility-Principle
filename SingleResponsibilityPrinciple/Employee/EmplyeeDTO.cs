using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleResponsibilityPrinciple.Employee
{
    public class EmplyeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}