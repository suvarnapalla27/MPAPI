using Microsoft.Data.SqlClient;

namespace APIProject.Models;


    public class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employees, string cstring)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employees, string cstring)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(Employee employees, string cstring)
        {
            throw new NotImplementedException();
        }

        public Employee GetDetails(int id, string cstring)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees(string cstring)
        {
            List<Employee> _employees = new List<Employee>();
            //establish the connection
            SqlConnection con = new SqlConnection(cstring);
            //open the connection
            con.Open();
            //write the sql command
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            //execute the command
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employee empobj = new Employee();
                empobj.EmpId = Convert.ToInt32(dr["EmpId"]);
                empobj.EmpName = dr["EmpName"].ToString();
                empobj.Address = dr["Address"].ToString();
                empobj.CompanyName = dr["CompanyName"].ToString();
                empobj.Designation = dr["Designation"].ToString();
                empobj.salary = Convert.ToSingle(dr["salary"]);
                _employees.Add(empobj);
            }
            //close the connection
            con.Close();
            return _employees;
        }
    }
