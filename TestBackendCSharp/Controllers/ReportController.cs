using Microsoft.AspNetCore.Mvc;
using TestBackendCSharp.Application.Dto;
using TestBackendCSharp.Application.Services;
using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Services;
using TestCSharp.ControllersDTO;

namespace TestBackendCSharp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public async Task<ActionResult<ReportViewModel>> CreateReport(ReportDTO reportDto)
        {
            try
            {
                var report = await _reportService.CreateReport(reportDto);

                return Ok(report);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public async Task<ActionResult<GetReportViewModel>> GetById(Guid id)
        {
            try
            {
                var report = await _reportService.GetById(id);

                return Ok(report);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
