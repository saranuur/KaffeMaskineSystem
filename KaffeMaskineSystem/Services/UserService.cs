using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KaffeMaskineSystem.Models;
using BCrypt.Net;
using KaffeMaskineSystem.Repository;

namespace KaffeMaskineSystem.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(User user, string password)
        {
            if (await _userRepository.GetUserByEmailAsync(user.Email) != null)
            {
                throw new InvalidOperationException("Email already exists");
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            await _userRepository.AddUserAsync(user);
            return user;
        }

        public async Task<bool> AuthenticateUserAsync(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            return user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserAsync(id);
        }
    }
}
