
using TestBackendCSharp.Application.Dto;
using TestBackendCSharp.Application.Interfaces;
using TestBackendCSharp.Application.ViewModel;
using TestBackendCSharp.Business.Models;
using TestCSharp.Application.Interfaces;
using TestCSharp.Business.Models;
using TestCSharp.ControllersDTO;
using TestCSharp.Models;

namespace TestBackendCSharp.Application.Services
{
    public class ReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITestRepository _testRepository;
        private readonly ITransformatorRepository _tansformatorRepository;



        public ReportService(
            IReportRepository reportRepository,
            IUserRepository userRepository,
            ITestRepository testRepository,
            ITransformatorRepository tansformatorRepository)
        {
            _reportRepository = reportRepository;
            _userRepository = userRepository;
            _testRepository = testRepository;
            _tansformatorRepository = tansformatorRepository;
        }

        public async Task<ReportViewModel> CreateReport(ReportDTO reportDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(reportDto.Name))
                {
                    throw new Exception("Name is required!");
                }

                if (reportDto.Status == false)
                {
                    throw new Exception("Status = false: Report not released!");
                }

                var report = new Report
                {
                    Name = reportDto.Name,
                    Status = reportDto.Status
                };

                var savedReport = await _reportRepository.Create(report);

                var test = await _testRepository.GetById(report.TestId);

                var transformator = await _tansformatorRepository.GetById(report.TransformatorId);

                var user = await _userRepository.GetById(report.)

                var reportViewModel = new ReportViewModel
                {
                    Id = savedReport.Id,
                    Name = savedReport.Name,
                    Status = savedReport.Status
                    //Adicionar
                };

                return reportViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
