using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface ITestService
    {
        Task AddTest(Test test);
        Task<Test> GetTest(int id);
        Task<IQueryable<Test>> GetAllTests();
        Task DeleteTest(int id);
        Task UpdateTest(Test test);
    }
}
