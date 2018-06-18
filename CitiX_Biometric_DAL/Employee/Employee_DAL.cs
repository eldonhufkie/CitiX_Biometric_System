using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CitiX_Biometric_DAL
{
    public class Employee_DAL
    {
        //Employee
        public string PIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMailAddress { get; set; }
        public string CellNumber { get; set; }
        public string Region { get; set; }
        //Employee Type
        public int EmployeeTypeID { get; set; }
        public string EmployeeTypeDescription { get; set; }
    }
}
