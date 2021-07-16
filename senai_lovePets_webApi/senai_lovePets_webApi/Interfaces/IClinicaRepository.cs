using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IClinicaRepository
    {
        /// <summary>
        /// Lista todas as clinicas
        /// </summary>
        /// <returns>Uma lista de clinicas/returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Busca uma clinica através do seu ID
        /// </summary>
        /// <param name="IdClinica">ID da clinica que será buscada</param>
        /// <returns>Uma clinica encontrada</returns>
        Clinica BuscarPorId(int IdClinica);

        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto com as novas informações</param>
        void Cadastrar(Clinica novaClinica);

        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="IdClinica">ID da clinica que será atualizada</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        void Atualizar(int IdClinica, Clinica ClinicaAtualizada);

        /// <summary>
        /// Deleta uma clinica existente
        /// </summary>
        /// <param name="IdClinica">ID da clinica que será deletada</param>
        void Deletar(int IdClinica);
    }
}
