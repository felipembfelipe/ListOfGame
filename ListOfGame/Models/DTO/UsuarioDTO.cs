using System;

namespace ListOfGame.Models.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
        public string EmailLogin { get; set; }
        public int IdTipoUsuario { get; set; }
    }
}
