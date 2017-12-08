﻿using System;
using System.Threading.Tasks;
using BasicApp.Login.Models;

namespace BasicApp.Login.Services
{
    public interface ILoginService
    {
        Task LogUserAsync(LoginCredentials login);

        Task RecoverPasswordAsync(string email);

        Task RegisterUserAsync(User user);
    }
}
