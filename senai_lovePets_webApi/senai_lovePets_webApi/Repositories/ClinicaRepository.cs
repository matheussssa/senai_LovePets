using senai_lovePets_webApi.Interfaces;
using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories {
    public class ClinicaRepository:IClinicaRepository
        {
        /// <summary>
        /// Instancia o objeto ctx utilizando a classe lovePetsContext
        /// </summary>
        lovePetsContext ctx = new lovePetsContext();


        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="IdClinica">ID da clinica que será atualizada</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        public void Atualizar(int IdClinica, Clinica ClinicaAtualizada) {
            Clinica Clinicabuscada = BuscarPorId(IdClinica);

            if(ClinicaAtualizada.RazaoSocial != null) {
                Clinicabuscada.RazaoSocial = ClinicaAtualizada.RazaoSocial;
            }

            if(ClinicaAtualizada.Cnpj != null) {
                Clinicabuscada.Cnpj = ClinicaAtualizada.Cnpj;
            }

            if(ClinicaAtualizada.Endereco > 0) {
                atendimentoBuscado.IdSituacao = atendimentoAtualizado.IdSituacao;
            }

            if(atendimentoAtualizado.Descricao != null) {
                atendimentoBuscado.Descricao = atendimentoAtualizado.Descricao;
            }

            if(atendimentoAtualizado.DataAtendimento >= DateTime.Now) {
                atendimentoBuscado.DataAtendimento = atendimentoAtualizado.DataAtendimento;
            }

            ctx.Atendimentos.Update(atendimentoBuscado);

            ctx.SaveChanges();
        }

        private Clinica BuscarPorId(int idClinica) {
            throw new NotImplementedException();
        }
    }
