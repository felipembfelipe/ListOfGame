using ListOfGame.Enum;
using ListOfGame.View.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListOfGame.Models
{
    [Table("TB_LG_GAME")]
    public class Game
    {
        public Game() { }

        [Key]
        [Required]
        [Column("ID_GAME")]
        public int Id { get; set; }

        [Column("DS_GAME")]
        public string NomeDoGame { get; set; }

        [Column("VL_TEMPO")]
        public int? Tempo { get; set; }

        [Column("FLG_POSSUI_ONLINE")]
        public bool PossuiOnline { get; set; }

        [Column("ID_STATUS_GAME")]
        public int IdStatusGame { get; set; }

        [Column("VL_ANO_CONCLUIDO")]
        public int? AnoConcluido { get; set; }

        [Column("FLG_GAME_CONCLUIDO")]
        public bool GameConcluido { get; set; }


        [ForeignKey("IdStatusGame")]
        public StatusGame StatusGame { get; set; }

        // Propriedade só pra exibição no DataGridView
        [NotMapped]
        public string StatusPlatinaDescricao => EnumUtils.GetEnumDescription((EStatusGame)IdStatusGame);

    }
}
