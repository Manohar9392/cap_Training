using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServices
{
    public interface IEmployeeService
    {
        public string getname();
        public int getid();
    }

    public class Employee
    {
        private IEmployeeService _employeeService;
        public Employee(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public string DisplayEmployeeName()
        {
           return  _employeeService.getname();
        }
        public int DisplayEmployeeID()
        {
            return _employeeService.getid();
        }

    }
    public class   Employee1: IEmployeeService
    {
        

        public Employee1()
        {
            
        }

        public string getname ()
        {
            return $" version 1 Employee Name";
        }

        public int getid()
        {
            return 1;
        }

    }
    public class Employee2: IEmployeeService
    {
        

        public Employee2()
        {

        }

        public string getname()
        {
            return $"version 2 Employee Name";
        }

        public int getid()
        {
            return 2;
        }

    }

}
