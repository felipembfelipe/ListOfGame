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
        private readonly IGameServices _gameServices;

        public frmTelaPrincipal(IUsuarioServices usuarioServices, IGameServices gameServices)
        {
            _usuarioServices = usuarioServices;
            _gameServices = gameServices;
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
            frmLogin formLogin = new frmLogin(_usuarioServices, _gameServices);
            formLogin.ShowDialog();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaGame formGame = new frmTelaGame(_usuarioServices, _gameServices);
            formGame.ShowDialog();
        }
    }
}
