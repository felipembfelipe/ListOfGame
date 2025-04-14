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
    public partial class frmTelaPrincipal : Form
    {
        private readonly IUsuarioServices _usuarioServices;

        public frmTelaPrincipal(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa? ", "Mensagem do Sistema ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin formLogin = new frmLogin(_usuarioServices);
            formLogin.ShowDialog();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaGame formGame = new frmTelaGame(_usuarioServices);
            formGame.ShowDialog();
        }
    }
}
