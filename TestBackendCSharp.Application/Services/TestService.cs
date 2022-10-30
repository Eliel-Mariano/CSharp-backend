using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Interfaces;
using TestCSharp.Business.Models;
using TestCSharp.ControllersDTO;
using TestCSharp.Models;

namespace TestCSharp.Business.Business
{
    public class TestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<TestViewModel> CreateTest(TestDTO testDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(testDto.testName))
                {
                    throw new Exception("testName is required!");
                }

                if (testDto.testStatus == false)
                {
                    throw new Exception("testStatus = false: Test not released!");
                }

                if (testDto.testDurationInSeconds == 0)
                {
                    throw new Exception("testDurationInSeconds = 0: Test not released!");
                }

                var test = new Test
                {
                    testName = testDto.testName,
                    testStatus = testDto.testStatus,
                    testDurationInSeconds = testDto.testDurationInSeconds,
                    TransformatorId = testDto.TransformatorId
                };

                var savedTest = await _testRepository.Create(test);

                var testViewModel = new TestViewModel
                {
                    Id = savedTest.Id,
                    testName = savedTest.testName,
                    testStatus = savedTest.testStatus,
                    testDurationInSeconds = savedTest.testDurationInSeconds,
                    TransformatorId = savedTest.TransformatorId
                };

                return testViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TestViewModel> UpdateTest(Guid id, TestDTO testDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(testDto.testName))
                {
                    throw new Exception("testName is required!");
                }

                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                if (testDto.testStatus == false)
                {
                    throw new Exception("testStatus = false: Test not released!");
                }

                if (testDto.testDurationInSeconds == 0)
                {
                    throw new Exception("testDurationInSeconds = 0: Test not released!");
                }

                var test = await _testRepository.GetById(id);

                test.testName = testDto.testName;
                test.testStatus = testDto.testStatus;
                test.testDurationInSeconds = testDto.testDurationInSeconds;

                var savedTest = await _testRepository.Update(id, test);

                var testViewModel = new TestViewModel
                {
                    Id = id,
                    testName = savedTest.testName,
                    testStatus = savedTest.testStatus,
                    testDurationInSeconds = savedTest.testDurationInSeconds,
                    TransformatorId = savedTest.TransformatorId
                };

                return testViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetTestViewModel> GetById(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                var test = await _testRepository.GetById(id);

                var testViewModel = new GetTestViewModel
                {
                    Id = test.Id,
                    testName = test.testName,
                    testStatus = test.testStatus,
                    testDurationInSeconds = test.testDurationInSeconds,
                    CreatedAt = test.CreatedAt,
                    UpdatedAt = test.UpdatedAt,
                    TransformatorId = test.TransformatorId
                };

                return testViewModel;
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

                await _testRepository.Delete(id);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
