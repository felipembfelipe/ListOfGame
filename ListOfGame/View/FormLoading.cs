using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListOfGame.View
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            // Hook para centralizar depois do carregamento
            this.Load += frmLoading_Load;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            // Centraliza com base na resolução da tela principal
            var screen = Screen.PrimaryScreen.WorkingArea;

            // Captura a área de trabalho do monitor onde o cursor está
            //var screen = Screen.FromPoint(Cursor.Position).WorkingArea;

            this.Location = new Point(
                screen.Left + (screen.Width - this.Width) / 2,
                screen.Top + (screen.Height - this.Height) / 2
            );
        }
    }
}
