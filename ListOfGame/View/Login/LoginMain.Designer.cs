namespace ListOfGame.View
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.linkEsqueci = new System.Windows.Forms.LinkLabel();
            this.linkTrocar = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHoraAgora = new System.Windows.Forms.Label();
            this.lblDataAgora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 224);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::ListOfGame.Properties.Resources.contacts_24;
            this.picUsuario.Location = new System.Drawing.Point(288, 25);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(27, 28);
            this.picUsuario.TabIndex = 1;
            this.picUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(321, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenha.Location = new System.Drawing.Point(321, 78);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(395, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(395, 75);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // linkEsqueci
            // 
            this.linkEsqueci.AutoSize = true;
            this.linkEsqueci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkEsqueci.LinkColor = System.Drawing.Color.White;
            this.linkEsqueci.Location = new System.Drawing.Point(285, 122);
            this.linkEsqueci.Name = "linkEsqueci";
            this.linkEsqueci.Size = new System.Drawing.Size(91, 15);
            this.linkEsqueci.TabIndex = 7;
            this.linkEsqueci.TabStop = true;
            this.linkEsqueci.Text = "Esqueci a Senha";
            this.linkEsqueci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEsqueci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueci_LinkClicked);
            // 
            // linkTrocar
            // 
            this.linkTrocar.AutoSize = true;
            this.linkTrocar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkTrocar.LinkColor = System.Drawing.Color.White;
            this.linkTrocar.Location = new System.Drawing.Point(423, 122);
            this.linkTrocar.Name = "linkTrocar";
            this.linkTrocar.Size = new System.Drawing.Size(74, 15);
            this.linkTrocar.TabIndex = 8;
            this.linkTrocar.TabStop = true;
            this.linkTrocar.Text = "Trocar Senha";
            this.linkTrocar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkTrocar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTrocar_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnLogin.Location = new System.Drawing.Point(288, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(426, 156);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 39);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(287, 213);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(39, 15);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Location = new System.Drawing.Point(287, 236);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 15);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoraAgora
            // 
            this.lblHoraAgora.AutoSize = true;
            this.lblHoraAgora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHoraAgora.Location = new System.Drawing.Point(322, 213);
            this.lblHoraAgora.Name = "lblHoraAgora";
            this.lblHoraAgora.Size = new System.Drawing.Size(0, 13);
            this.lblHoraAgora.TabIndex = 13;
            // 
            // lblDataAgora
            // 
            this.lblDataAgora.AutoSize = true;
            this.lblDataAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataAgora.Location = new System.Drawing.Point(322, 236);
            this.lblDataAgora.Name = "lblDataAgora";
            this.lblDataAgora.Size = new System.Drawing.Size(0, 15);
            this.lblDataAgora.TabIndex = 14;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(523, 258);
            this.Controls.Add(this.lblDataAgora);
            this.Controls.Add(this.lblHoraAgora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkTrocar);
            this.Controls.Add(this.linkEsqueci);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.PictureBox picUsuario;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.LinkLabel linkEsqueci;
        public System.Windows.Forms.LinkLabel linkTrocar;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblHoraAgora;
        public System.Windows.Forms.Label lblDataAgora;
    }
}