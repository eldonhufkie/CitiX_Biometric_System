using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CitiX_Biometric_DAL;

namespace CitiX_Biometric_BLL
{
    public class Employee
    {
        EmployeeDBAccess empAccess = new EmployeeDBAccess();

        public bool UpdateStatus(Employee_DAL emp)
        {
            return empAccess.UpdateStatus(emp);
        }
    }
}
