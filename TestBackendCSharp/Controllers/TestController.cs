using Microsoft.AspNetCore.Mvc;
using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Services;
using TestCSharp.Business.Business;
using TestCSharp.ControllersDTO;

namespace TestCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly TestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }

        [HttpPost]
        public async Task<ActionResult<TestViewModel>> CreateTest(TestDTO testDto)
        {
            try
            {
                var test = await _testService.CreateTest(testDto);

                return Ok(test);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<TestViewModel>> UpdateTest(Guid id, TestDTO testDto)
        {
            try
            {
                var test = await _testService.UpdateTest(id, testDto);

                return Ok(test);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult<GetTestViewModel>> GetById(Guid id)
        {
            try
            {
                var test = await _testService.GetById(id);

                return Ok(test);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            try
            {
                await _testService.DeleteById(id);

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
