using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ListOfGame.View.Login
{
    public partial class frmTrocaSenha : Form
    {
        private readonly ILoginServices _loginServices;

        public frmTrocaSenha(ILoginServices loginServices)
        {
            _loginServices = loginServices;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin formLogin = new frmLogin(_loginServices);
            formLogin.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ValidaUsuario();
        }

        private async void ValidaUsuario()
        {
            string usuarioLogin = txtUsuario.Text;
            string senhaAntiga = txtSenha.Text;
            string senhaNova = txtNovaSenha.Text;
            string senhaNova2 = txtNovaSenha2.Text;

            if (string.IsNullOrWhiteSpace(usuarioLogin) ||
                string.IsNullOrWhiteSpace(senhaAntiga) ||
                string.IsNullOrWhiteSpace(senhaNova) ||
                string.IsNullOrWhiteSpace(senhaNova2))
            {
                MostrarMensagem("Preencha os campos vazios!", MessageBoxIcon.Exclamation);
                return;
            }

            if (!SenhaEhValida(senhaNova))
            {
                MostrarMensagem("A nova senha deve conter pelo menos 8 caracteres, incluindo letras e números.", MessageBoxIcon.Warning);
                return;
            }

            if (senhaNova != senhaNova2)
            {
                MostrarMensagem("As senhas não coincidem!", MessageBoxIcon.Warning);
                return;
            }

            if (senhaNova == senhaAntiga)
            {
                MostrarMensagem("A nova senha não pode ser igual à senha antiga.", MessageBoxIcon.Warning);
                return;
            }

            using (var loading = new frmLoading())
            {
                loading.Show();
                loading.Refresh();

                try
                {
                    var usuario = await _loginServices.Login(usuarioLogin, senhaAntiga);

                    if (usuario == null)
                    {
                        usuario = await _loginServices.ValidaUsuarioExistente(usuarioLogin);
                        MostrarMensagem(
                            usuario == null ? "Usuário inexistente!" : "Usuário e/ou senha incorreto",
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (!usuario.Ativo)
                    {
                        MostrarMensagem("Usuário desativado. Contate o administrador.", MessageBoxIcon.Error);
                        return;
                    }

                    usuario.SenhaUsuario = senhaNova;
                    bool sucesso = await _loginServices.TrocaSenha(usuario);

                    MostrarMensagem(
                        sucesso ? "Senha alterada com sucesso!" : "Erro ao alterar a senha.",
                        sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (sucesso)
                        LimpaForm();
                }
                catch (Exception ex)
                {
                    MostrarMensagem($"Erro inesperado: {ex.Message}", MessageBoxIcon.Error);
                }
                finally
                {
                    loading.Close();
                }
            }
        }


        private void LimpaForm()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNovaSenha.Text = "";
            txtNovaSenha2.Text = "";
            txtUsuario.Focus();
        }

        private void MostrarMensagem(string mensagem, MessageBoxIcon icone)
        {
            MessageBox.Show(mensagem, "Mensagem do Sistema", MessageBoxButtons.OK, icone);
        }

        private bool SenhaEhValida(string senha)
        {
            //var regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            //return regex.IsMatch(senha);

            return true;
        }
    }
}
