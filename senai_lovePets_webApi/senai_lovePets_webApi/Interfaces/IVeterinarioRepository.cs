using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IVeterinarioRepository
    {
        /// <summary>
        /// Lista todos os veterinarios
        /// </summary>
        /// <returns>Uma lista de veterinarios</returns>
        List<Veterinario> ListarTodos();

        /// <summary>
        /// Busca um veterinario através do seu ID
        /// </summary>
        /// <param name="IdVeterinario">ID do veterinario que será buscado</param>
        /// <returns>Um veterinario encontrado</returns>
        Veterinario BuscarPorId(int IdVeterinario);

        /// <summary>
        /// Cadastra um novo veterinario
        /// </summary>
        /// <param name="novoVeterinario">Objeto com as novas informações</param>
        void Cadastrar(Veterinario novoVeterinario);

        /// <summary>
        /// Atualiza um veterinario existente
        /// </summary>
        /// <param name="IdVeterinario">ID do veterinario que será atualizado</param>
        /// <param name="veterinarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdVeterinario, Veterinario veterinarioAtualizado);

        /// <summary>
        /// Deleta um veterinario existente
        /// </summary>
        /// <param name="IdVeterinario">ID do veterinario que será deletado</param>
        void Deletar(int IdVeterinario);
    }
}
