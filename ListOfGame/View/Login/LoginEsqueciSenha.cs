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
                MostrarStatus("E-mail inválido. Verifique e tente novamente.", Color.Red);
                return;
            }

            using var loading = new frmLoading();
            loading.Show();
            loading.Refresh();

            try
            {
                var emailEnviado = await _usuarioServices.ObterUsuarioPorLoginEEmail(usuario, email);

                if (emailEnviado)
                    MostrarStatus("E-mail de recuperação enviado com sucesso!", Color.Green);
                else
                    MostrarStatus("E-mail não encontrado ou falha no envio.", Color.Red);
            }
            catch (Exception ex)
            {
                MostrarStatus("Erro ao tentar enviar o e-mail.", Color.Red);
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

        private void MostrarStatus(string mensagem, Color cor)
        {
            lblStatus.Text = mensagem;
            lblStatus.ForeColor = cor;
            lblStatus.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin formLogin = new frmLogin(_usuarioServices);
            formLogin.ShowDialog();
        }
    }
}
