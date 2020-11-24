using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace WebServiceByJavascript
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod(Description ="Get Employeed By Id")]
        public Employee GetEmpById(int empId)
        {
            Employee emp = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Sp_Emp_By_EmpId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@EmpId", empId);
            cmd.Parameters.Add(param);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                emp.EmployeeId = Convert.ToInt32(dr["EmployeeID"]);
                emp.FirstName = Convert.ToString(dr["FirstName"]);
                emp.LastName = Convert.ToString(dr["LastName"]);
                emp.Title = Convert.ToString(dr["Title"]);
            }

            return emp;
        }
    }
}
