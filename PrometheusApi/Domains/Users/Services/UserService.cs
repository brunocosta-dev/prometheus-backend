using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrometheusApi.Domains.Users.Repositorys;

namespace PrometheusApi.Domains.Users.Services
{
    public class UserService
    {
        private readonly UsersRepository _repository;

        public UserService(UsersRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> CreateUser(string? name, string? email, string? passwordHash)
        {
            var user = new User(name, email, BCrypt.Net.BCrypt.HashPassword(passwordHash));
            return await _repository.UserCreate(user);
        }
    }
}