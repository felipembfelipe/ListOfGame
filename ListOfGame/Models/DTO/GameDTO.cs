namespace ListOfGame.Models.DTO
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string NomeDoGame { get; set; }
        public int? Tempo { get; set; }
        public bool PossuiOnline { get; set; }
        public int IdStatusGame { get; set; }
        public int? AnoConcluido { get; set; }
    }
}
