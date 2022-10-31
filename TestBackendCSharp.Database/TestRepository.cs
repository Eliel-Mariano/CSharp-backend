using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using TestCSharp.Application.Interfaces;
using TestCSharp.Models;

namespace TestCSharp.Database
{
    public class TestRepository : Repository<Test>, ITestRepository
    {
        public TestRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
