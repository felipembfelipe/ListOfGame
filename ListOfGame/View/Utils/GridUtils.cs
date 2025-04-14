using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListOfGame.View.Utils
{
    public static class GridUtils
    {
        public static void FormatarColunasGrid(DataGridView grid)
        {
            // Oculta colunas desnecessárias
            if (grid.Columns.Contains("Id"))
                grid.Columns["Id"].Visible = false;

            if (grid.Columns.Contains("TipoStatusGame"))
                grid.Columns["TipoStatusGame"].Visible = false;

            if (grid.Columns.Contains("IdStatusGame"))
                grid.Columns["IdStatusGame"].Visible = false;

            // Renomeia os cabeçalhos
            if (grid.Columns.Contains("NomeDoGame"))
                grid.Columns["NomeDoGame"].HeaderText = "Nome do Jogo";

            if (grid.Columns.Contains("Tempo"))
                grid.Columns["Tempo"].HeaderText = "Tempo (h)";

            if (grid.Columns.Contains("GameConcluido"))
                grid.Columns["GameConcluido"].HeaderText = "Zerado?";

            if (grid.Columns.Contains("AnoConcluido"))
                grid.Columns["AnoConcluido"].HeaderText = "Ano";

            if (grid.Columns.Contains("PossuiOnline"))
                grid.Columns["PossuiOnline"].HeaderText = "Tem Online?";

            // Centraliza valores de colunas
            if (grid.Columns.Contains("AnoConcluido"))
                grid.Columns["AnoConcluido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (grid.Columns.Contains("Tempo"))
                grid.Columns["Tempo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajusta larguras
            if (grid.Columns.Contains("NomeDoGame"))
                grid.Columns["NomeDoGame"].Width = 200;

            // Ajusta Descrição do Enum
            if (grid.Columns.Contains("StatusPlatinaDescricao"))
            {
                grid.Columns["StatusPlatinaDescricao"].HeaderText = "Status da Platina";
                grid.Columns["StatusPlatinaDescricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns["StatusPlatinaDescricao"].Width = 150;
            }

            // Definir ordem das colunas
            if (grid.Columns.Contains("NomeDoGame"))
                grid.Columns["NomeDoGame"].DisplayIndex = 0;

            if (grid.Columns.Contains("StatusPlatinaDescricao"))
                grid.Columns["StatusPlatinaDescricao"].DisplayIndex = 1;

            if (grid.Columns.Contains("Tempo"))
                grid.Columns["Tempo"].DisplayIndex = 2;

            if (grid.Columns.Contains("PossuiOnline"))
                grid.Columns["PossuiOnline"].DisplayIndex = 3;

            if (grid.Columns.Contains("GameConcluido"))
                grid.Columns["GameConcluido"].DisplayIndex = 4;

            if (grid.Columns.Contains("AnoConcluido"))
                grid.Columns["AnoConcluido"].DisplayIndex = 5;


            // Centralizar cabeçalho com padding e layout refinado
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(0);
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // Ajuste automático do tamanho das colunas com base no conteúdo
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Impede redimensionamento manual das colunas
            grid.AllowUserToResizeColumns = false;
        }
    }
}
