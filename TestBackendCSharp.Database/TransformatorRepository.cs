using Microsoft.Extensions.Configuration;
using TestCSharp.Application.Interfaces;
using TestCSharp.Business.Models;
using TestCSharp.Database;

namespace TestBackendCSharp.Database
{
    public class TransformatorRepository : Repository<Transformator>, ITransformatorRepository
    {
        public TransformatorRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
