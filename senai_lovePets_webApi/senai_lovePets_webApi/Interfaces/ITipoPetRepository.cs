using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoPetRepository
    {
        /// <summary>
        /// Lista todos os tipos de pets
        /// </summary>
        /// <returns>Uma lista de tipos de pets</returns>
        List<TipoPet> ListarTodos();

        /// <summary>
        /// Busca os tipos de pets através do seu ID
        /// </summary>
        /// <param name="IdTipoPet">ID do tipo de pet que será buscado</param>
        /// <returns>Um tipo de pet encontrado</returns>
        TipoPet BuscarPorId(int IdTipoPet);

        /// <summary>
        /// Cadastra um novo tipo de pet
        /// </summary>
        /// <param name="novoTipoPet">Objeto com as novas informações</param>
        void Cadastrar(TipoPet novoTipoPet);

        /// <summary>
        /// Atualiza um tipo de pet existente
        /// </summary>
        /// <param name="IdTipoPet">ID do tipo de pet que será atualizado</param>
        /// <param name="tipoPetAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdTipoPet, TipoPet tipoPetAtualizado);

        /// <summary>
        /// Deleta um tipo de pet existente
        /// </summary>
        /// <param name="IdTipoPet">ID do tipo de pet que será deletado</param>
        void Deletar(int IdTipoPet);
    }
}
