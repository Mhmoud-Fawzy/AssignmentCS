using Demo.DAL.Contexts;

namespace Demo.DAL.Repos
{
    public interface IDeptRepo
    {
        AppDbContext _appDbContext { get; }

        int Add(Department department);
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        int Remove(Department department);
        int Update(Department department);
    }
}