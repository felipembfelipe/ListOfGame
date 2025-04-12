using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListOfGame.Models
{
    [Table("TB_LG_USUARIO")]
    public class Usuario
    {
        public Usuario() { }

        [Key]
        [Required]
        [Column("ID_USUARIO")]
        public int Id { get; set; }

        [Column("DS_LOGIN")]
        public string LoginUsuario { get; set; }

        [Column("DS_SENHA")]
        public string SenhaUsuario { get; set; }

        [Column("DT_CRIACAO")]
        public DateTime DataCriacao { get; set; }

        [Column("DT_ALTERACAO")]
        public DateTime? DataAlteracao { get; set; }

        [Column("ST_FLG_ATIVO")]
        public bool Ativo { get; set; }

        [Column("DS_EMAIL")]
        public string? EmailLogin { get; set; }


    }
}
