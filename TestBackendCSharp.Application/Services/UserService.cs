using TestBackendCSharp.Application.ViewModel;
using TestCSharp.Application.Interfaces;
using TestCSharp.Business.Models;
using TestCSharp.ControllersDTO;
using TestCSharp.Models;

namespace TestCSharp.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> CreateUser(UserDTO userDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.Email))
                {
                    throw new Exception("userName and userEmail are required!");
                }

                var user = new User
                {
                    Name = userDto.Name,
                    Email = userDto.Email
                };

                var savedUser = await _userRepository.Create(user);

                var userViewModel = new UserViewModel
                {
                    Id = savedUser.Id,
                    Name = savedUser.Name,
                    Email = savedUser.Email
                };

                return userViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserViewModel> UpdateUser(Guid id, UserDTO userDto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.Email))
                {
                    throw new Exception("userName and userEmail are required!");
                }

                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                var user = new User
                {
                    Name = userDto.Name,
                    Email = userDto.Email
                };

                var savedUser = await _userRepository.Update(id, user);

                var userViewModel = new UserViewModel
                {
                    Id = id,
                    Name = savedUser.Name,
                    Email = savedUser.Email
                };

                return userViewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetUserViewModel> GetById(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("id is required!");
                }

                var user = await _userRepository.GetById(id);

                var userViewModel = new GetUserViewModel
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    CreatedAt = user.CreatedAt,
                    UpdatedAt = user.UpdatedAt
                };

                return userViewModel;
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

                await _userRepository.Delete(id);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
