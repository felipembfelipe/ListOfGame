using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListOfGame.View.Utils
{
    public static class GridDecorator
    {
        /// <summary>
        /// Substitui colunas booleanas do tipo CheckBox por colunas de texto, permitindo customização visual.
        /// Deve ser chamado logo após atribuir o DataSource ao grid.
        /// </summary>
        public static void ConverterColunasBooleansParaTexto(DataGridView grid, params string[] colunas)
        {
            foreach (var coluna in colunas)
            {
                if (grid.Columns.Contains(coluna) && grid.Columns[coluna] is DataGridViewCheckBoxColumn)
                {
                    var original = grid.Columns[coluna];

                    var novaColuna = new DataGridViewTextBoxColumn
                    {
                        Name = coluna,
                        HeaderText = original.HeaderText,
                        DataPropertyName = coluna,
                        Width = original.Width,
                        DisplayIndex = original.DisplayIndex,
                        DefaultCellStyle = original.DefaultCellStyle
                    };

                    int index = original.Index;
                    grid.Columns.RemoveAt(index);
                    grid.Columns.Insert(index, novaColuna);
                }
            }
        }

        /// <summary>
        /// Aplica estilo "SIM/NÃO" em colunas booleanas com cor, negrito e centralização.
        /// Deve ser chamado no evento CellFormatting.
        /// </summary>
        public static void AplicarEstiloBooleano(DataGridView grid, DataGridViewCellFormattingEventArgs e, params string[] colunas)
        {
            string nomeColuna = grid.Columns[e.ColumnIndex].Name;

            if (Array.Exists(colunas, c => c.Equals(nomeColuna, StringComparison.OrdinalIgnoreCase)))
            {
                if (e.Value is bool valor)
                {
                    e.Value = valor ? "SIM" : "NÃO";
                    e.CellStyle.ForeColor = valor ? Color.Green : Color.Red;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    e.FormattingApplied = true;
                }
            }
        }

        /// <summary>
        /// Suprime erros de formatação de células (ex: tipo incorreto ao exibir valor formatado).
        /// Deve ser chamado no evento DataError.
        /// </summary>
        public static void TratarDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
