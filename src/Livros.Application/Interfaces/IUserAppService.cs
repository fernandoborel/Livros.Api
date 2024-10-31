﻿using Livros.Application.Dtos;
using Livros.Domain;

namespace Livros.Application.Interfaces;

public interface IUserAppService : IDisposable
{
    void CriarUser(CriarUserDto dto);
    List<User> ListarUsers();
}