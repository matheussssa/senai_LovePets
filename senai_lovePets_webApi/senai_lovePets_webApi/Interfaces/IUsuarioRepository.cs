using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Busca os usuarios através do seu ID
        /// </summary>
        /// <param name="IdUsuario">ID do usuario que será buscado</param>
        /// <returns>Um usuario encontrado</returns>
        Usuario BuscarPorId(int IdUsuario);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto com as novas informações</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um usuario existente
        /// </summary>
        /// <param name="IdUsuario">ID do usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdUsuario, Usuario usuarioAtualizado);

        /// <summary>
        /// Deleta um usuario existente
        /// </summary>
        /// <param name="IdUsuario">ID do usuario que será deletado</param>
        void Deletar(int IdUsuario);
    }
}
