using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ListOfGame.Models
{
    [Table("TB_LG_TIPO_USUARIO")]
    public class TipoUsuario
    {
        public TipoUsuario() { }

        [Key]
        [Required]
        [Column("ID_TIPO_USUARIO")]
        public int Id { get; set; }

        [Column("DS_TIPO_USUARIO")]
        public string TipoDoUsuario { get; set; }

    }
}
