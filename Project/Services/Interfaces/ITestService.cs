using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface ITestService
    {
        Task AddTest(Test test);
        Task<Test> Test(int id);
        Task<IQueryable<Test>> GetAllTests();
        Task DeleteTest(int id);
        Task UpdateTest(Test test);
    }
}
