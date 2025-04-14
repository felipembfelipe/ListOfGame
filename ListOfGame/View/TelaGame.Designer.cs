namespace ListOfGame.View
{
    partial class frmTelaGame
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNomeDoGame = new System.Windows.Forms.TextBox();
            this.lblNomeGame = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblOnline = new System.Windows.Forms.Label();
            this.checkOnline = new System.Windows.Forms.CheckBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblConcluido = new System.Windows.Forms.Label();
            this.checkConcluido = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(12, 180);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(94, 39);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // txtNomeDoGame
            // 
            this.txtNomeDoGame.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeDoGame.Location = new System.Drawing.Point(143, 32);
            this.txtNomeDoGame.Name = "txtNomeDoGame";
            this.txtNomeDoGame.Size = new System.Drawing.Size(594, 23);
            this.txtNomeDoGame.TabIndex = 11;
            // 
            // lblNomeGame
            // 
            this.lblNomeGame.AutoSize = true;
            this.lblNomeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeGame.Location = new System.Drawing.Point(12, 35);
            this.lblNomeGame.Name = "lblNomeGame";
            this.lblNomeGame.Size = new System.Drawing.Size(125, 20);
            this.lblNomeGame.TabIndex = 10;
            this.lblNomeGame.Text = "Nome do Game:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTempo.Location = new System.Drawing.Point(12, 86);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(247, 20);
            this.lblTempo.TabIndex = 13;
            this.lblTempo.Text = "Tempo necesário para Zerar (Hs):";
            // 
            // txtTempo
            // 
            this.txtTempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTempo.Location = new System.Drawing.Point(265, 83);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(69, 23);
            this.txtTempo.TabIndex = 14;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOnline.Location = new System.Drawing.Point(566, 129);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(109, 20);
            this.lblOnline.TabIndex = 15;
            this.lblOnline.Text = "Possui Online:";
            // 
            // checkOnline
            // 
            this.checkOnline.AutoSize = true;
            this.checkOnline.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOnline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkOnline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkOnline.Location = new System.Drawing.Point(681, 127);
            this.checkOnline.Name = "checkOnline";
            this.checkOnline.Size = new System.Drawing.Size(56, 25);
            this.checkOnline.TabIndex = 16;
            this.checkOnline.Text = "SIM";
            this.checkOnline.UseVisualStyleBackColor = false;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAno.Location = new System.Drawing.Point(522, 86);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(143, 20);
            this.lblAno.TabIndex = 17;
            this.lblAno.Text = "Ano de Conclusão:";
            // 
            // txtAno
            // 
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAno.Location = new System.Drawing.Point(671, 83);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(64, 23);
            this.txtAno.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Status do Andamento da Platina:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // lblConcluido
            // 
            this.lblConcluido.AutoSize = true;
            this.lblConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConcluido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConcluido.Location = new System.Drawing.Point(342, 86);
            this.lblConcluido.Name = "lblConcluido";
            this.lblConcluido.Size = new System.Drawing.Size(87, 20);
            this.lblConcluido.TabIndex = 21;
            this.lblConcluido.Text = "Concluído: ";
            // 
            // checkConcluido
            // 
            this.checkConcluido.AutoSize = true;
            this.checkConcluido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkConcluido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkConcluido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkConcluido.Location = new System.Drawing.Point(435, 84);
            this.checkConcluido.Name = "checkConcluido";
            this.checkConcluido.Size = new System.Drawing.Size(56, 25);
            this.checkConcluido.TabIndex = 22;
            this.checkConcluido.Text = "SIM";
            this.checkConcluido.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(127, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 39);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(240, 180);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 39);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(358, 180);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 39);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::ListOfGame.Properties.Resources.check_mark_8_24;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(641, 180);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 39);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(723, 366);
            this.dataGridView1.TabIndex = 27;
            // 
            // frmTelaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.checkConcluido);
            this.Controls.Add(this.lblConcluido);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.checkOnline);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNomeDoGame);
            this.Controls.Add(this.lblNomeGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela do Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TextBox txtNomeDoGame;
        public System.Windows.Forms.Label lblNomeGame;
        public System.Windows.Forms.Label lblTempo;
        public System.Windows.Forms.TextBox txtTempo;
        public System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.CheckBox checkOnline;
        public System.Windows.Forms.Label lblAno;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label lblConcluido;
        private System.Windows.Forms.CheckBox checkConcluido;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}