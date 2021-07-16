using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ISituacaoRepository
    {
        /// <summary>
        /// Lista todas as situacoes
        /// </summary>
        /// <returns>Uma lista de situacoes</returns>
        List<Situacao> ListarTodos();

        /// <summary>
        /// Busca uma situacao através do seu ID
        /// </summary>
        /// <param name="IdSituacao">ID da situacao que será buscada</param>
        /// <returns>Uma situacao encontrada</returns>
        Situacao BuscarPorId(int IdSituacao);

        /// <summary>
        /// Cadastra uma nova situacao
        /// </summary>
        /// <param name="novoSituacao">Objeto com as novas informações</param>
        void Cadastrar(Situacao novoSituacao);

        /// <summary>
        /// Atualiza uma situacao existente
        /// </summary>
        /// <param name="IdSituacao">ID da situacao que será atualizada</param>
        /// <param name="situacaoAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdSituacao, Situacao situacaoAtualizado);

        /// <summary>
        /// Deleta uma situacao existente
        /// </summary>
        /// <param name="IdSituacao">ID da situacao que será deletada</param>
        void Deletar(int IdSituacao);
    }
}
