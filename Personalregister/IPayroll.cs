
namespace Personalregister;

internal interface IPayroll
{
    void AddEmployee(string name, uint salary);
    IEnumerable<Employee> GetEmployees();
}