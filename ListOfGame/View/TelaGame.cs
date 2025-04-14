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
    public partial class frmTelaGame : Form
    {
        private readonly IUsuarioServices _usuarioServices;

        public frmTelaGame(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaPrincipal formTelaPrincipal = new frmTelaPrincipal(_usuarioServices);
            formTelaPrincipal.ShowDialog();
        }
    }
}
