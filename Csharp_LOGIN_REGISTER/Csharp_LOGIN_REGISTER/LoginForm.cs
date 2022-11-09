using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_LOGIN_REGISTER.VEIW
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void USUÁRIO_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelclose_MouseEnter(object sender, EventArgs e)
        {
            labelclose.ForeColor = Color.Red;
        }

        private void labelclose_MouseLeave(object sender, EventArgs e)
        {
            labelclose.ForeColor = Color.Black;
        }

        private void labelclose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonentrar_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBoxUsuario.Text;
            String password = textBoxSenha.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("INSIRA SEU USUÁRIO","CAMPO USUÁRIO VAZIO");
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("INSIRA SUA SENHA","CAMPO SENHA VAZIO");
                }
                else
                {
                    MessageBox.Show("SENHA OU USUÁRIO INCORRETO", "DADOS INVÁLIDOS");
                }
            }
        }

        private void labelGoSingOn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingOnForm singonform = new SingOnForm();
            singonform.Show();
        }

        private void labelGoSingOn_MouseEnter(object sender, EventArgs e)
        {
            labelGoSingOn.ForeColor = Color.DarkBlue;
        }

        private void labelGoSingOn_MouseLeave(object sender, EventArgs e)
        {
            labelGoSingOn.ForeColor = Color.Black;
        }
    }
}
