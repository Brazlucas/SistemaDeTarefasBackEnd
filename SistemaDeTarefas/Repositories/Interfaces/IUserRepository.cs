﻿using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> BuscarTodosUsuarios();
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Adicionar(UserModel usuario);
        Task<UserModel> Atualizar(UserModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
