using Microsoft.AspNetCore.Mvc;
using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Services;
using TestCSharp.Business.Business;
using TestCSharp.ControllersDTO;

namespace TestCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransformatorController : ControllerBase
    {
        private readonly TransformatorService _transformatorService;

        public TransformatorController(TransformatorService transformatorService)
        {
            _transformatorService = transformatorService;
        }

        [HttpPost]
        public async Task<ActionResult<TransformatorViewModel>> CreateTransformator(TransformatorDTO transformatorDTO)
        {
            try
            {
                var transformator = await _transformatorService.CreateTransformator(transformatorDTO);

                return Ok(transformator);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult<TransformatorViewModel>> UpdateTransformator(Guid id, TransformatorDTO transformatorDTO)
        {
            try
            {
                var transformator = await _transformatorService.UpdateTransformator(id, transformatorDTO);

                return Ok(transformator);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public async Task<ActionResult<TransformatorViewModel>> GetById(Guid id)
        {
            try
            {
                var transformator = await _transformatorService.GetById(id);

                return Ok(transformator);
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
                await _transformatorService.DeleteById(id);

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
