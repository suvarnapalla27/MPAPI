namespace APIProject.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees(string cstring);
        void AddEmployee(Employee employees, string cstring);
        void EditEmployee(Employee employees, string cstring);
        void DeleteEmployee(Employee employees, string cstring);
        Employee GetDetails(int id, string cstring);
    }
}
