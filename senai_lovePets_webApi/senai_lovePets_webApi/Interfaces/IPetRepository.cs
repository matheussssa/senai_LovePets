using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IPetRepository
    {
        /// <summary>
        /// Lista todos os pets
        /// </summary>
        /// <returns>Uma lista de pets</returns>
        List<Pet> ListarTodos();

        /// <summary>
        /// Busca um Pet através do seu ID
        /// </summary>
        /// <param name="IdPet">ID do pet que será buscado</param>
        /// <returns>Um pet encontrado</returns>
        Pet BuscarPorId(int IdPet);

        /// <summary>
        /// Cadastra um novo pet
        /// </summary>
        /// <param name="novoPet">Objeto com as novas informações</param>
        void Cadastrar(Pet novoPet);

        /// <summary>
        /// Atualiza um Pet existente
        /// </summary>
        /// <param name="IdPet">ID do pet que será atualizado</param>
        /// <param name="petAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdPet, Pet petAtualizado);

        /// <summary>
        /// Deleta um pet existente
        /// </summary>
        /// <param name="IdPet">ID do pet que será deletado</param>
        void Deletar(int IdPet);


    }
}
