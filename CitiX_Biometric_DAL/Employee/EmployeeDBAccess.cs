using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CitiX_Biometric_DAL
{
    public class EmployeeDBAccess
    {

        public bool AddNewEmployee(Employee_DAL emp)
        {
            SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@pin", emp.PIN),
            new SqlParameter("@lastName", emp.LastName),
            new SqlParameter("@firstName", emp.FirstName),
            new SqlParameter("@email",emp.EMailAddress),
            new SqlParameter("@region", emp.Region),
            new SqlParameter("@employeeIdType", emp.EmployeeTypeID),
        };
            return SqlDBHelper.ExecuteNonQuery("usp_AddEmployee", CommandType.StoredProcedure, parameters);
        }
        //public bool UpdateNewEmployee(Employee_DAL emp)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //          new SqlParameter("@addressLine1", emp.Address),
        //    new SqlParameter("@email",emp.Email),
        //    new SqlParameter("@suburb", emp.Suburb),
        //    new SqlParameter("@postalCode", emp.ZipCode),
        //     new SqlParameter("@profilePicture", emp.Image),
        //    };
        //    return SqlDBHelper.ExecuteNonQuery("usp_UpdateEmployee", CommandType.StoredProcedure, parameters);
        //}

        //public bool DeleteEmployee(Employee_DAL emp)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@employeeid",emp.EmployeeID)
        //    };
        //    return SqlDBHelper.ExecuteNonQuery("usp_DeleteEmployee", CommandType.StoredProcedure, parameters);
        //}
        public DataTable dtGetEmployeeList()
        {
            DataTable dtempList = SqlDBHelper.ExecuteSelectCommand("usp_GetAllEmployees", CommandType.StoredProcedure);
            return dtempList;
        }
        public DataTable dtGetCredentialsForLogin()
        {
            DataTable dtcred = SqlDBHelper.ExecuteSelectCommand("usp_GetLoginDetails", CommandType.StoredProcedure);
            return dtcred;
        }
        public bool UpdateStatus(Employee_DAL emp)
        {
            bool updated;
            SqlParameter[] pars = new SqlParameter[]
            {
                new  SqlParameter("@",emp.PIN)
            };
            updated = SqlDBHelper.ExecuteNonQuery("usp_UpdateStatus", CommandType.StoredProcedure, pars);
            return updated;
        }
    }
}