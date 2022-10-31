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
                    Name = tansformatorDto.transformatorName,
                    InternalNumber = tansformatorDto.internalNumber,
                    TensionClass = tansformatorDto.tensionClass,
                    Potency = tansformatorDto.potency,
                    Current = tansformatorDto.current,
                    UserId = tansformatorDto.UserId
                };

                var savedTansformator = await _tansformatorRepository.Create(tansformator);

                var tansformatorViewModel = new TransformatorViewModel
                {
                    Id = savedTansformator.Id,
                    transformatorName = savedTansformator.Name,
                    internalNumber = savedTansformator.InternalNumber,
                    tensionClass = savedTansformator.TensionClass,
                    potency = savedTansformator.Potency,
                    current = savedTansformator.Current,
                    UserId = savedTansformator.UserId
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

                tansformator.Name = tansformatorDto.transformatorName;
                tansformator.InternalNumber = tansformatorDto.internalNumber;
                tansformator.TensionClass = tansformatorDto.tensionClass;
                tansformator.Potency = tansformatorDto.potency;
                tansformator.Current = tansformatorDto.current;

                var savedTansformator = await _tansformatorRepository.Update(id, tansformator);

                var tansformatorViewModel = new TransformatorViewModel
                {
                    Id = savedTansformator.Id,
                    transformatorName = savedTansformator.Name,
                    internalNumber = savedTansformator.InternalNumber,
                    tensionClass = savedTansformator.TensionClass,
                    potency = savedTansformator.Potency,
                    current = savedTansformator.Current,
                    UserId = savedTansformator.UserId
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
                    transformatorName = tansformator.Name,
                    internalNumber = tansformator.InternalNumber,
                    tensionClass = tansformator.TensionClass,
                    potency = tansformator.Potency,
                    current = tansformator.Current,
                    CreatedAt = tansformator.CreatedAt,
                    UpdatedAt = tansformator.UpdatedAt,
                    UserId = tansformator.UserId
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
