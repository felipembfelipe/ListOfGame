using System.ComponentModel;

namespace ListOfGame.Enum
{
    public enum ETipoStatusGame
    {
        [Description("Concluído")]
        CONCLUIDO = 1,

        [Description("Em Andamento")]
        EM_ANDAMENTO = 2,
        
        [Description("Backlogged")]
        BACKLOGGED = 3,

        [Description("Próximo a platinar")]
        PROXIMOS_A_PLATINAR = 4,

        [Description("Garapa")]
        GARAPA = 5,

        [Description("Impossíveis")]
        IMPOSSIVEIS = 6,

        [Description("Criar Coragem")]
        CRIAR_CORAGEM = 7
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
