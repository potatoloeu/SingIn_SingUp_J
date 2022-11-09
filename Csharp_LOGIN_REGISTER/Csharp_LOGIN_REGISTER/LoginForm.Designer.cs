namespace Csharp_LOGIN_REGISTER.VEIW
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Oliveira = new System.Windows.Forms.PictureBox();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.labelsenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.Cadeado = new System.Windows.Forms.PictureBox();
            this.labelusuário = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.PictureBox();
            this.labelclose = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelGoSingOn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cadeado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.labelGoSingOn);
            this.panel1.Controls.Add(this.Oliveira);
            this.panel1.Controls.Add(this.buttonentrar);
            this.panel1.Controls.Add(this.labelsenha);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.Cadeado);
            this.panel1.Controls.Add(this.labelusuário);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.User);
            this.panel1.Controls.Add(this.labelclose);
            this.panel1.Controls.Add(this.labellogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 416);
            this.panel1.TabIndex = 0;
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
            this.buttonentrar.Location = new System.Drawing.Point(45, 273);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(235, 27);
            this.buttonentrar.TabIndex = 8;
            this.buttonentrar.Text = "Entrar";
            this.buttonentrar.UseVisualStyleBackColor = false;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.Location = new System.Drawing.Point(40, 187);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(53, 18);
            this.labelsenha.TabIndex = 7;
            this.labelsenha.Text = "Senha";
            this.labelsenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(45, 210);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(235, 25);
            this.textBoxSenha.TabIndex = 6;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Cadeado
            // 
            this.Cadeado.Image = ((System.Drawing.Image)(resources.GetObject("Cadeado.Image")));
            this.Cadeado.Location = new System.Drawing.Point(12, 208);
            this.Cadeado.Name = "Cadeado";
            this.Cadeado.Size = new System.Drawing.Size(27, 27);
            this.Cadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cadeado.TabIndex = 5;
            this.Cadeado.TabStop = false;
            this.Cadeado.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelusuário
            // 
            this.labelusuário.AutoSize = true;
            this.labelusuário.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuário.Location = new System.Drawing.Point(40, 113);
            this.labelusuário.Name = "labelusuário";
            this.labelusuário.Size = new System.Drawing.Size(62, 18);
            this.labelusuário.TabIndex = 4;
            this.labelusuário.Text = "Usuário";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(45, 135);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(235, 25);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // User
            // 
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.Location = new System.Drawing.Point(12, 134);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(27, 27);
            this.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User.TabIndex = 2;
            this.User.TabStop = false;
            this.User.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelclose
            // 
            this.labelclose.AutoSize = true;
            this.labelclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelclose.Location = new System.Drawing.Point(318, 3);
            this.labelclose.Name = "labelclose";
            this.labelclose.Size = new System.Drawing.Size(14, 13);
            this.labelclose.TabIndex = 1;
            this.labelclose.Text = "X";
            this.labelclose.Click += new System.EventHandler(this.labelclose_Click);
            this.labelclose.MouseEnter += new System.EventHandler(this.labelclose_MouseEnter);
            this.labelclose.MouseLeave += new System.EventHandler(this.labelclose_MouseLeave);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.Location = new System.Drawing.Point(39, 47);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(63, 22);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Login";
            // 
            // labelGoSingOn
            // 
            this.labelGoSingOn.AutoSize = true;
            this.labelGoSingOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoSingOn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoSingOn.Location = new System.Drawing.Point(89, 343);
            this.labelGoSingOn.Name = "labelGoSingOn";
            this.labelGoSingOn.Size = new System.Drawing.Size(162, 16);
            this.labelGoSingOn.TabIndex = 10;
            this.labelGoSingOn.Text = "Novo Usuário? Registre-se aqui!";
            this.labelGoSingOn.Click += new System.EventHandler(this.labelGoSingOn_Click);
            this.labelGoSingOn.MouseEnter += new System.EventHandler(this.labelGoSingOn_MouseEnter);
            this.labelGoSingOn.MouseLeave += new System.EventHandler(this.labelGoSingOn_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 416);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cadeado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelclose;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.PictureBox Cadeado;
        private System.Windows.Forms.Label labelusuário;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.PictureBox Oliveira;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.Label labelGoSingOn;
    }
}