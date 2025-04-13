using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using ListOfGame.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListOfGame.View
{
    public partial class frmLogin : Form
    {
        private readonly ILoginServices _loginServices;

        bool logado = false;
        DateTime data_hora;

        public frmLogin(ILoginServices loginServices)
        {
            _loginServices = loginServices;
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
            //SenhaPergunta1 se = new SenhaPergunta1();
            //se.ShowDialog();
        }

        private void linkTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //trocaSenha.ShowDialog();

            frmTrocaSenha trocaSenha = new frmTrocaSenha(_loginServices);
            this.Visible = false;
            trocaSenha.Visible = true;
            //novoLogin.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Autenticacao();
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticacao();
            }
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

        public async void Autenticacao()
        {
            //frmTelaPrincipal telaPrincipal = new frmTelaPrincipal();
            //frmLogin novoLogin = new frmLogin(_loginServices);

            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MostrarMensagem("Preencha os campos vazios!", MessageBoxIcon.Exclamation);
                logado = false;
                return;
            }

            using (var loading = new frmLoading())
            {
                loading.Show();
                loading.Refresh();

                try
                {
                    var usuario = await _loginServices.Login(login, senha);

                    if (usuario == null)
                    {
                        usuario = await _loginServices.ValidaUsuarioExistente(login);

                        MostrarMensagem(
                            usuario == null ? "Usuário inexistente!" : "Usuário e/ou senha incorreto",
                            MessageBoxIcon.Error
                        );

                        logado = false;
                        return;
                    }

                    if (!usuario.Ativo)
                    {
                        MostrarMensagem("Usuário desativado. Contate o Administrador.", MessageBoxIcon.Error);
                        logado = false;
                        return;
                    }

                    logado = true;

                    MostrarMensagem("Logado com Sucesso", MessageBoxIcon.Information);

                    AbrirTelaPrincipal(); // Separado para organização
                }
                catch (Exception ex)
                {
                    MostrarMensagem($"Erro inesperado: {ex.Message}", MessageBoxIcon.Error);
                    logado = false;
                }
                finally
                {
                    loading.Close();
                }
            }
        }
    }
}
