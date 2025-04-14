namespace ListOfGame.View
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(391, 123);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 39);
            this.btnSair.TabIndex = 15;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(93, 29);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(136, 50);
            this.btnGame.TabIndex = 21;
            this.btnGame.Text = "Cadastrar Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cadastrar Usuário";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 123);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 39);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 174);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnVoltar;
    }
}