using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
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
            //SenhaNova sn = new SenhaNova();
            //sn.ShowDialog();
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

        public async void Autenticacao()
        {
            frmTelaPrincipal telaPrincipal = new frmTelaPrincipal();
            frmLogin novoLogin = new frmLogin(_loginServices);

            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Chama o método Login do serviço injetado
                Usuario usuario = await _loginServices.Login(login, senha);

                // Valida autenticação
                if (usuario == null)
                {
                    usuario = await _loginServices.ValidaUsuarioExistente(login);
                    if(usuario == null)
                    {
                        MessageBox.Show("Usuário inexistente!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logado = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorreto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logado = false;
                    }
                }
                else if(usuario.Ativo == false)
                {
                    MessageBox.Show("Usuário Desativado!\nPor favor entre em contato com o Administrador!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logado = false;
                }
                else
                {
                    this.Visible = false;
                    MessageBox.Show("Logado com Sucesso","Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telaPrincipal.Visible = true;
                    novoLogin.Close();
                }
            }
        }
    }
}
