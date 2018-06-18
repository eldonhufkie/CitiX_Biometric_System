using System;
using System.Collections.Generic;
using System.Data;
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
            return empAccess.UpdateStatusAndAddClockIn(emp);
        }
        public bool UpdateStatusAndAddClockOut(Employee_DAL emp)
        {
            return empAccess.UpdateStatusAndAddClockOut(emp);
        }
        public DataTable DtGetAllEmployees()
        {
            return empAccess.DtGetAllEmployees();
        }
        public DataTable DtGetAllEmployeesLoggedIn()
        {
            return empAccess.DtGetAllEmployeesLoggedIn();
        }
        public DataTable DtGetAllEmployeesLoggedOut()
        {
            return empAccess.DtGetAllEmployeesLoggedOut();
        }

    }
}
