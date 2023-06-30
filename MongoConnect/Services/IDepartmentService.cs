using MongoConnect.Models;

namespace MongoConnect.Services
{
    public interface IDepartmentService
    {
        List<Department> GetDepartments();
        Department GetDepartmentById(string id);
    }
}
