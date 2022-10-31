using Microsoft.Extensions.Configuration;

using TestBackendCSharp.Application.Interfaces;
using TestBackendCSharp.Business.Models;
using TestCSharp.Database;

namespace TestBackendCSharp.Database
{
    public class ReportRepository : Repository<Report>, IReportRepository
    {
        public ReportRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
