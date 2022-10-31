using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using TestCSharp.Application.Interfaces;
using TestCSharp.Models;

namespace TestCSharp.Database
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
