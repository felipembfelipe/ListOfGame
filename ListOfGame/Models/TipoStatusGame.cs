using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListOfGame.Models
{
    [Table("TB_LG_STATUS_GAME")]
    public class TipoStatusGame
    {
        [Key]
        [Required]
        [Column("ID_STATUS_GAME")]
        public int Id { get; set; }

        [Column("DS_STATUS_GAME")]
        public string StatusGame { get; set; }
    }
}
