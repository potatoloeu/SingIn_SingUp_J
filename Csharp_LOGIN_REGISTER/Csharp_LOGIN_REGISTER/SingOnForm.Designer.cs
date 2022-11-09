namespace Csharp_LOGIN_REGISTER
{
    partial class SingOnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingOnForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSenhaconf = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.Oliveira = new System.Windows.Forms.PictureBox();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelclose = new System.Windows.Forms.Label();
            this.labelregister = new System.Windows.Forms.Label();
            this.labelGoLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.labelGoLogin);
            this.panel1.Controls.Add(this.textBoxSenhaconf);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxSobrenome);
            this.panel1.Controls.Add(this.Oliveira);
            this.panel1.Controls.Add(this.buttonentrar);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.labelclose);
            this.panel1.Controls.Add(this.labelregister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 377);
            this.panel1.TabIndex = 1;
            // 
            // textBoxSenhaconf
            // 
            this.textBoxSenhaconf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaconf.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSenhaconf.Location = new System.Drawing.Point(45, 262);
            this.textBoxSenhaconf.Name = "textBoxSenhaconf";
            this.textBoxSenhaconf.Size = new System.Drawing.Size(312, 25);
            this.textBoxSenhaconf.TabIndex = 13;
            this.textBoxSenhaconf.Text = "Confirme a senha";
            this.textBoxSenhaconf.Enter += new System.EventHandler(this.textBoxSenhaconf_Enter);
            this.textBoxSenhaconf.Leave += new System.EventHandler(this.textBoxSenhaconf_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(45, 197);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(312, 25);
            this.textBoxUsername.TabIndex = 12;
            this.textBoxUsername.Text = "Usuário";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(45, 166);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(312, 25);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSobrenome.Location = new System.Drawing.Point(204, 135);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(153, 25);
            this.textBoxSobrenome.TabIndex = 10;
            this.textBoxSobrenome.Text = "Sobrenome";
            this.textBoxSobrenome.Enter += new System.EventHandler(this.textBoxSobrenome_Enter);
            this.textBoxSobrenome.Leave += new System.EventHandler(this.textBoxSobrenome_Leave);
            // 
            // Oliveira
            // 
            this.Oliveira.Image = ((System.Drawing.Image)(resources.GetObject("Oliveira.Image")));
            this.Oliveira.Location = new System.Drawing.Point(1, 0);
            this.Oliveira.Name = "Oliveira";
            this.Oliveira.Size = new System.Drawing.Size(41, 52);
            this.Oliveira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oliveira.TabIndex = 9;
            this.Oliveira.TabStop = false;
            // 
            // buttonentrar
            // 
            this.buttonentrar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonentrar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonentrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonentrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonentrar.Location = new System.Drawing.Point(85, 305);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(235, 30);
            this.buttonentrar.TabIndex = 8;
            this.buttonentrar.Text = "Registrar";
            this.buttonentrar.UseVisualStyleBackColor = false;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSenha.Location = new System.Drawing.Point(45, 231);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(312, 25);
            this.textBoxSenha.TabIndex = 6;
            this.textBoxSenha.Text = "Senha";
            this.textBoxSenha.Enter += new System.EventHandler(this.textBoxSenha_Enter);
            this.textBoxSenha.Leave += new System.EventHandler(this.textBoxSenha_Leave);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNome.Location = new System.Drawing.Point(45, 135);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(153, 25);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.Text = "Nome";
            this.textBoxNome.Enter += new System.EventHandler(this.textBoxNome_Enter);
            this.textBoxNome.Leave += new System.EventHandler(this.textBoxNome_Leave);
            // 
            // labelclose
            // 
            this.labelclose.AutoSize = true;
            this.labelclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelclose.Location = new System.Drawing.Point(382, 3);
            this.labelclose.Name = "labelclose";
            this.labelclose.Size = new System.Drawing.Size(14, 13);
            this.labelclose.TabIndex = 1;
            this.labelclose.Text = "X";
            this.labelclose.Click += new System.EventHandler(this.labelclose_Click);
            this.labelclose.MouseEnter += new System.EventHandler(this.labelclose_MouseEnter);
            this.labelclose.MouseLeave += new System.EventHandler(this.labelclose_MouseLeave);
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregister.Location = new System.Drawing.Point(39, 47);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(249, 22);
            this.labelregister.TabIndex = 0;
            this.labelregister.Text = "Registre um novo usuário";
            // 
            // labelGoLogin
            // 
            this.labelGoLogin.AutoSize = true;
            this.labelGoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoLogin.Location = new System.Drawing.Point(126, 344);
            this.labelGoLogin.Name = "labelGoLogin";
            this.labelGoLogin.Size = new System.Drawing.Size(148, 16);
            this.labelGoLogin.TabIndex = 14;
            this.labelGoLogin.Text = "Já tem uma conta? Entre aqui!";
            this.labelGoLogin.Click += new System.EventHandler(this.labelGoSingOn_Click);
            this.labelGoLogin.MouseEnter += new System.EventHandler(this.labelGoLogin_MouseEnter);
            this.labelGoLogin.MouseLeave += new System.EventHandler(this.labelGoLogin_MouseLeave);
            // 
            // SingOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 377);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingOnForm";
            this.Text = "SingOnForm";
            this.Load += new System.EventHandler(this.SingOnForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Oliveira;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelclose;
        private System.Windows.Forms.Label labelregister;
        private System.Windows.Forms.TextBox textBoxSenhaconf;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelGoLogin;
    }
}