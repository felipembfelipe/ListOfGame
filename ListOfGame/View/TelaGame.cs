using ListOfGame.Enum;
using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using ListOfGame.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ListOfGame.View
{
    public partial class frmTelaGame : Form
    {
        private readonly IUsuarioServices _usuarioServices;
        private readonly IGameServices _gameServices;

        private string IdGame = null;

        public frmTelaGame(IUsuarioServices usuarioServices, IGameServices gameServices)
        {
            _usuarioServices = usuarioServices;
            _gameServices = gameServices;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaPrincipal formTelaPrincipal = new frmTelaPrincipal(_usuarioServices, _gameServices);
            formTelaPrincipal.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var game = new Game
            {
                NomeDoGame = txtNomeDoGame.Text,
                Tempo = !String.IsNullOrEmpty(txtTempo.Text) ? int.Parse(txtTempo.Text) : (int?)null,
                GameConcluido = checkConcluido.Checked,
                AnoConcluido = !String.IsNullOrEmpty(txtAno.Text) ? int.Parse(txtAno.Text) : (int?)null,
                PossuiOnline = checkOnline.Checked,
                IdStatusGame = (int)(ETipoStatusGame)comboBoxStatus.SelectedValue
            };

            // Aqui você chama um método para inserir no banco
            bool salvado = await _gameServices.Salvar(game, IdGame);

            if (salvado)
            {
                CarregarDados();
                LimpaForm();
            }
            else
            {
                MessageBox.Show("Erro ao persistir game.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;

                IdGame = row.Cells["Id"]?.Value?.ToString() ?? "";
                txtNomeDoGame.Text = row.Cells["NomeDoGame"]?.Value?.ToString() ?? "";
                txtTempo.Text = row.Cells["Tempo"]?.Value?.ToString() ?? "";
                checkConcluido.Checked = row.Cells["GameConcluido"]?.Value != null && (bool)row.Cells["GameConcluido"].Value;
                txtAno.Text = row.Cells["AnoConcluido"]?.Value?.ToString() ?? "";
                checkOnline.Checked = row.Cells["PossuiOnline"]?.Value != null && (bool)row.Cells["PossuiOnline"].Value;

                if (row.Cells["IdStatusGame"]?.Value != null)
                {
                    var status = (ETipoStatusGame)System.Enum.Parse(typeof(ETipoStatusGame), row.Cells["IdStatusGame"].Value.ToString());
                    SelecionarValorEnumNoComboBox(comboBoxStatus, status);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var resultado = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //Excluir(id);
                    CarregarDados();
                }
            }
        }

        private void frmTelaGame_Load(object sender, EventArgs e)
        {
            CarregarComboBoxStatus();
            CarregarDados();
            LimpaForm();
            txtAno.KeyPress += txtTempo_KeyPress;
            txtTempo.KeyPress += txtAno_KeyPress;
        }

        private async void CarregarDados()
        {
            var lista = await _gameServices.ObterJogosDoBanco();
            dataGridView1.DataSource = lista.OrderBy(x => x.NomeDoGame).ToList();

            // 1. Substitui CheckBox por TextBox
            GridDecorator.ConverterColunasBooleansParaTexto(dataGridView1, "PossuiOnline", "GameConcluido");

            // 2. Aplica formatação geral
            GridUtils.FormatarColunasGrid(dataGridView1);

            // 3. Registra eventos
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.DataError += dataGridView1_DataError;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridDecorator.AplicarEstiloBooleano(dataGridView1, e, "PossuiOnline", "GameConcluido");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            GridDecorator.TratarDataError(sender, e);
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos (0-9) e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos (0-9) e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void LimpaForm()
        {
            IdGame = null;
            txtNomeDoGame.Clear();
            txtTempo.Clear();
            checkConcluido.Checked = false;
            txtAno.Clear();
            checkOnline.Checked = false;
            comboBoxStatus.SelectedIndex = 0;
            txtNomeDoGame.Focus();
        }

        private bool ValidarCampos()
        {
            // Nome do jogo
            if (string.IsNullOrWhiteSpace(txtNomeDoGame.Text))
            {
                MessageBox.Show("Informe o nome do jogo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeDoGame.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTempo.Text) &&
                !int.TryParse(txtTempo.Text, out _))
            {
                MessageBox.Show("Informe um tempo válido (em horas).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTempo.Focus();
                return false;
            }

            // Ano de conclusão
            if (!string.IsNullOrWhiteSpace(txtAno.Text) &&
                (txtAno.Text.Length != 4) || !int.TryParse(txtAno.Text, out _))
            {
                MessageBox.Show("Informe um ano válido com 4 dígitos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAno.Focus();
                return false;
            }

            // Status da platina
            if (comboBoxStatus.SelectedValue == null)
            {
                MessageBox.Show("Selecione o status da platina.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxStatus.Focus();
                return false;
            }

            return true;
        }

        #region ComboBox Utils
        private void CarregarComboBoxStatus()
        {
            var lista = new List<ComboBoxItem>
            {
                new ComboBoxItem { Text = "Selecione o Status", Value = null }
            };

            foreach (var status in System.Enum.GetValues(typeof(ETipoStatusGame)))
            {
                lista.Add(new ComboBoxItem { Text = status.ToString(), Value = status });
            }

            comboBoxStatus.DisplayMember = "Text";
            comboBoxStatus.ValueMember = "Value";
            comboBoxStatus.DataSource = lista;
            comboBoxStatus.SelectedIndex = 0;
        }

        public void SelecionarValorEnumNoComboBox<TEnum>(ComboBox comboBox, TEnum valor) where TEnum : System.Enum
        {
            foreach (var item in comboBox.Items)
            {
                if (item is ComboBoxItem comboItem && comboItem.Value is TEnum enumValue)
                {
                    if (EqualityComparer<TEnum>.Default.Equals(enumValue, valor))
                    {
                        comboBox.SelectedItem = comboItem;
                        return;
                    }
                }
            }
        }

        #endregion
    }
}
