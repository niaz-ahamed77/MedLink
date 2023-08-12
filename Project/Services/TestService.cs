using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository<Test> _testRepository;

        public TestService(IRepository<Test> testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task AddTest(Test test)
        {
            await _testRepository.AddAsync(test);
        }

        public async Task DeleteTest(int id)
        {
            await _testRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Test>> GetAllTests()
        {
            return await _testRepository.GetAll();
        }

        public Task<Test> GetTest(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTest(Test test)
        {
            await _testRepository.UpdateAsync(test);
        }
    }
}
