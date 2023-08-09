using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class TestService : Repository<Test>, ITestService
    {
        public TestService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddTest(Test test)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTest(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Test>> GetAllTests()
        {
            throw new NotImplementedException();
        }

        public Task<Test> Test(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTest(Test test)
        {
            throw new NotImplementedException();
        }
    }
}
