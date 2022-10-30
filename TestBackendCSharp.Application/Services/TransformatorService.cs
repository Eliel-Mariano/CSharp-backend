using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Interfaces;
using TestCSharp.Business.Models;
using TestCSharp.ControllersDTO;
using TestCSharp.Models;

namespace TestCSharp.Business.Business
{
    public class TransformatorService
    {
        private readonly ITransformatorRepository _tansformatorRepository;

        public TransformatorService(ITransformatorRepository tansformatorRepository)
        {
            _tansformatorRepository = tansformatorRepository;
        }

        public async Task<TransformatorViewModel> CreateTransformator(TransformatorDTO tansformatorDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tansformatorDto.transformatorName)
                    || tansformatorDto.internalNumber == 0)
                {
                    throw new Exception("transformatorName and internalNumber are required!");
                }

                var tansformator = new Transformator
                {
                    transformatorName = tansformatorDto.transformatorName,
                    internalNumber = tansformatorDto.internalNumber,
                    tensionClass = tansformatorDto.tensionClass,
                    potency = tansformatorDto.potency,
                    current = tansformatorDto.current
                };

                var savedTansformator = await _tansformatorRepository.Create(tansformator);

                var tansformatorViewModel = new TransformatorViewModel
                {
                    Id = savedTansformator.Id,
                    transformatorName = savedTansformator.transformatorName,
                    internalNumber = savedTansformator.internalNumber,
                    tensionClass = savedTansformator.tensionClass,
                    potency = savedTansformator.potency,
                    current = savedTansformator.current
                };

                return tansformatorViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TransformatorViewModel> UpdateTransformator(Guid id, TransformatorDTO tansformatorDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tansformatorDto.transformatorName)
                    || tansformatorDto.internalNumber == 0)
                {
                    throw new Exception("transformatorName and internalNumber are required!");
                }

                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                var tansformator = await _tansformatorRepository.GetById(id);

                tansformator.transformatorName = tansformatorDto.transformatorName;
                tansformator.internalNumber = tansformatorDto.internalNumber;
                tansformator.tensionClass = tansformatorDto.tensionClass;
                tansformator.potency = tansformatorDto.potency;
                tansformator.current = tansformatorDto.current;

                var savedTansformator = await _tansformatorRepository.Update(id, tansformator);

                var tansformatorViewModel = new TransformatorViewModel
                {
                    Id = savedTansformator.Id,
                    transformatorName = savedTansformator.transformatorName,
                    internalNumber = savedTansformator.internalNumber,
                    tensionClass = savedTansformator.tensionClass,
                    potency = savedTansformator.potency,
                    current = savedTansformator.current
                };

                return tansformatorViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetTransformatorViewModel> GetById(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                var tansformator = await _tansformatorRepository.GetById(id);

                var tansformatorViewModel = new GetTransformatorViewModel
                {
                    Id = tansformator.Id,
                    transformatorName = tansformator.transformatorName,
                    internalNumber = tansformator.internalNumber,
                    tensionClass = tansformator.tensionClass,
                    potency = tansformator.potency,
                    current = tansformator.current,
                    CreatedAt = tansformator.CreatedAt,
                    UpdatedAt = tansformator.UpdatedAt
                };

                return tansformatorViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteById(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                await _tansformatorRepository.Delete(id);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
