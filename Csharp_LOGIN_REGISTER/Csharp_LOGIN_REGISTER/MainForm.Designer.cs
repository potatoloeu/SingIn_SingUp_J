namespace Csharp_LOGIN_REGISTER
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Oliveira = new System.Windows.Forms.PictureBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelclose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).BeginInit();
            this.SuspendLayout();
            // 
            // Oliveira
            // 
            this.Oliveira.Image = ((System.Drawing.Image)(resources.GetObject("Oliveira.Image")));
            this.Oliveira.Location = new System.Drawing.Point(0, -1);
            this.Oliveira.Name = "Oliveira";
            this.Oliveira.Size = new System.Drawing.Size(61, 73);
            this.Oliveira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oliveira.TabIndex = 10;
            this.Oliveira.TabStop = false;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.Location = new System.Drawing.Point(67, 35);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(232, 37);
            this.labellogin.TabIndex = 11;
            this.labellogin.Text = "Oliveira Trade";
            // 
            // labelclose
            // 
            this.labelclose.AutoSize = true;
            this.labelclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelclose.Location = new System.Drawing.Point(879, -1);
            this.labelclose.Name = "labelclose";
            this.labelclose.Size = new System.Drawing.Size(14, 13);
            this.labelclose.TabIndex = 12;
            this.labelclose.Text = "X";
            this.labelclose.Click += new System.EventHandler(this.labelclose_Click);
            this.labelclose.MouseEnter += new System.EventHandler(this.labelclose_MouseEnter);
            this.labelclose.MouseLeave += new System.EventHandler(this.labelclose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seja bem-vindo!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelclose);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.Oliveira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Oliveira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Oliveira;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelclose;
        private System.Windows.Forms.Label label1;
    }
}