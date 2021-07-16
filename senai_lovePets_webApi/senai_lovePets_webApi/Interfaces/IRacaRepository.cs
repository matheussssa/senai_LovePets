using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IRacaRepository
    {
        /// <summary>
        /// Lista todas as racas
        /// </summary>
        /// <returns>Uma lista de racas</returns>
        List<Raca> ListarTodos();

        /// <summary>
        /// Busca uma raca através do seu ID
        /// </summary>
        /// <param name="IdRaca">ID da raca que será buscada</param>
        /// <returns>Uma raca encontrada</returns>
        Raca BuscarPorId(int IdRaca);

        /// <summary>
        /// Cadastra uma nova raca
        /// </summary>
        /// <param name="novoRaca">Objeto com as novas informações</param>
        void Cadastrar(Raca novoRaca);

        /// <summary>
        /// Atualiza uma raca existente
        /// </summary>
        /// <param name="IdRaca">ID da raca que será atualizada</param>
        /// <param name="racaAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdRaca, Raca racaAtualizado);

        /// <summary>
        /// Deleta uma raca existente
        /// </summary>
        /// <param name="IdRaca">ID da raca que será deletada</param>
        void Deletar(int IdRaca);
    }
}
