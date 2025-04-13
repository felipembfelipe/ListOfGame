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
    public partial class frmEsqueciSenha : Form
    {
        private readonly IUsuarioServices _usuarioServices;

        public frmEsqueciSenha(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (!ValidarEmail(email))
            {
                MostrarMensagem("E-mail inválido. Verifique e tente novamente.", MessageBoxIcon.Error);
                return;
            }

            using var loading = new frmLoading();
            loading.Show();
            loading.Refresh();

            try
            {
                var emailEnviado = await _usuarioServices.ObterUsuarioPorLoginEEmail(usuario, email);

                if (emailEnviado)
                {
                    MostrarMensagem("E-mail de recuperação enviado com sucesso!", MessageBoxIcon.Information);
                    LimpaForm();
                }
                else
                    MostrarMensagem("E-mail não encontrado ou falha no envio.", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MostrarMensagem("Erro ao tentar enviar o e-mail.", MessageBoxIcon.Error);
            }
            finally
            {
                loading.Close();
            }
        }

        private bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        private void MostrarMensagem(string mensagem, MessageBoxIcon icone)
        {
            MessageBox.Show(mensagem, "Mensagem do Sistema", MessageBoxButtons.OK, icone);
        }

        private void LimpaForm()
        {
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin formLogin = new frmLogin(_usuarioServices);
            formLogin.ShowDialog();
        }
    }
}
