using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IWork
    {
        string GetWorkDetails(int employeeId);
    }

    public class SeniorEmployees : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }

    public class JuniorEmployees : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }
}
