using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface iDonoRepository

    {
        /// <summary>
        /// Lista todos os donos de pets
        /// </summary>
        /// <returns>Uma lista dos Donos</returns>
        List<Dono> ListarTodos();

        /// <summary>
        /// Busca um dono através do seu ID
        /// </summary>
        /// <param name="IdDono">ID do dono que será buscado</param>
        /// <returns>Um dono encontrado</returns>
        Dono BuscarPorId(int IdDono);

        /// <summary>
        /// Cadastra um novo dono
        /// </summary>
        /// <param name="novoDono">Objeto com as novas informações</param>
        void Cadastrar(Dono novoDono);

        /// <summary>
        /// Atualiza um dono existente
        /// </summary>
        /// <param name="IdDono">ID do Dono que será atualizado</param>
        /// <param name="donoAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdDono, Dono donoAtualizado);

        /// <summary>
        /// Deleta um dono existente
        /// </summary>
        /// <param name="IdDono">ID do dono que será deletado</param>
        void Deletar(int IdDono);

    
}
    }
}
