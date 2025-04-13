using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using ListOfGame.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfGame.View
{
    public partial class frmLogin : Form
    {
        private readonly IUsuarioServices _usuarioServices;

        bool logado = false;
        DateTime data_hora;

        public frmLogin(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkEsqueci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var esqueceu = new frmEsqueciSenha(_usuarioServices);
            esqueceu.ShowDialog();
        }

        private void linkTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTrocaSenha trocaSenha = new frmTrocaSenha(_usuarioServices);
            this.Visible = false;
            trocaSenha.Visible = true;
        }

        private async void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool autenticado = await AutenticacaoAsync();

                if (autenticado)
                    AbrirTelaPrincipal();
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool autenticado = await AutenticacaoAsync();

            if (autenticado)
                AbrirTelaPrincipal();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa? ", "Mensagem do Sistema ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lblDataAgora.Text = data_hora.ToLongDateString();
            lblHoraAgora.Text = data_hora.ToLongTimeString();
        }

        private void AbrirTelaPrincipal()
        {
            this.Hide(); // Oculta o login atual
            var telaPrincipal = new frmTelaPrincipal();
            telaPrincipal.FormClosed += (s, e) => this.Close(); // Fecha login ao fechar principal
            telaPrincipal.Show();
        }

        private void MostrarMensagem(string texto, MessageBoxIcon icone)
        {
            MessageBox.Show(texto, "Mensagem do Sistema", MessageBoxButtons.OK, icone);
        }

        public async Task<bool> AutenticacaoAsync()
        {
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MostrarMensagem("Preencha os campos vazios!", MessageBoxIcon.Exclamation);
                return false;
            }

            using (var loading = new frmLoading())
            {
                loading.Show();
                loading.Refresh();

                try
                {
                    var usuario = await _usuarioServices.ObterUsuarioPorLoginESenha(login, senha);

                    if (usuario == null)
                    {
                        usuario = await _usuarioServices.ObterUsuarioPorLogin(login);

                        MostrarMensagem(
                            usuario == null ? "Usuário inexistente!" : "Usuário e/ou senha incorreto",
                            MessageBoxIcon.Error
                        );

                        return false;
                    }

                    if (!usuario.Ativo)
                    {
                        MostrarMensagem("Usuário desativado. Contate o Administrador.", MessageBoxIcon.Error);
                        return false;
                    }

                    MostrarMensagem("Logado com Sucesso", MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    MostrarMensagem($"Erro inesperado: {ex.Message}", MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    loading.Close();
                }
            }
        }
    }
}
