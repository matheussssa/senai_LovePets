using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de usuarios
        /// </summary>
        /// <returns>Uma lista de tipos de usuarios</returns>
        List<TipoUsuario> ListarTodos();

        /// <summary>
        /// Busca os tipos de usuarios através do seu ID
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipo de usuario que será buscado</param>
        /// <returns>Um tipo de usuario encontrado</returns>
        TipoUsuario BuscarPorId(int IdTipoUsuario);

        /// <summary>
        /// Cadastra um novo tipo de usuario
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto com as novas informações</param>
        void Cadastrar(TipoUsuario novoTipoUsuario);

        /// <summary>
        /// Atualiza um tipo de usuario existente
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipo de usuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdTipoUsuario, TipoUsuario tipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuario existente
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipo de usuario que será deletado</param>
        void Deletar(int IdTipoUsuario);
    }
}
