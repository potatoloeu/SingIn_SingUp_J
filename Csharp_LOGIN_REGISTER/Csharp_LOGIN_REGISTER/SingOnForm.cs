using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_LOGIN_REGISTER.VEIW;
using MySql.Data.MySqlClient;

namespace Csharp_LOGIN_REGISTER
{
    public partial class SingOnForm : Form
    {
        public SingOnForm()
        {
            InitializeComponent();
        }
        private void SingOnForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelregister;
        }

        private void textBoxNome_Enter(object sender, EventArgs e)
        {
            String nome = textBoxNome.Text;
            if (nome.ToLower().Trim().Equals("nome"))
            {
                textBoxNome.Text = "";
                textBoxNome.ForeColor = Color.Black;
            }

        }

        private void textBoxNome_Leave(object sender, EventArgs e)
        {
            String nome = textBoxNome.Text;
            if (nome.ToLower().Trim().Equals("nome") || nome.Trim().Equals(""))
            {
                textBoxNome.Text = "Nome";
                textBoxNome.ForeColor = Color.Gray;

            }
        }

        private void textBoxSobrenome_Enter(object sender, EventArgs e)
        {
            String sobrenome = textBoxSobrenome.Text;
            if (sobrenome.ToLower().Trim().Equals("sobrenome"))
            {
                textBoxSobrenome.Text = "";
                textBoxSobrenome.ForeColor = Color.Black;

            }
        }

        private void textBoxSobrenome_Leave(object sender, EventArgs e)
        {
            String sobrenome = textBoxSobrenome.Text;
            if (sobrenome.ToLower().Trim().Equals("sobrenome") || sobrenome.Trim().Equals(""))
            {
                textBoxSobrenome.Text = "Sobrenome";
                textBoxSobrenome.ForeColor = Color.Gray;
            }

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String user = textBoxUsername.Text;
            if (user.ToLower().Trim().Equals("usuário"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String user = textBoxUsername.Text;
            if (user.ToLower().Trim().Equals("usuário") || user.Trim().Equals(""))
            {
                textBoxUsername.Text = "Usuário";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            String senha = textBoxSenha.Text;
            if (senha.ToLower().Trim().Equals("senha"))
            {
                textBoxSenha.Text = "";
                textBoxSenha.UseSystemPasswordChar = true;
                textBoxSenha.ForeColor = Color.Black;
            }
        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            String senha = textBoxSenha.Text;
            if (senha.ToLower().Trim().Equals("senha") || senha.Trim().Equals(""))
            {
                textBoxSenha.Text = "Senha";
                textBoxSenha.UseSystemPasswordChar = false;
                textBoxSenha.ForeColor = Color.Gray;
            }
        }

        private void textBoxSenhaconf_Enter(object sender, EventArgs e)
        {
            String senhaconf = textBoxSenhaconf.Text;
            if (senhaconf.ToLower().Trim().Equals("confirme a senha"))
            {
                textBoxSenhaconf.Text = "";
                textBoxSenhaconf.UseSystemPasswordChar = true;
                textBoxSenhaconf.ForeColor = Color.Black;
            }
        }

        private void textBoxSenhaconf_Leave(object sender, EventArgs e)
        {
            String senhaconf = textBoxSenhaconf.Text;
            if (senhaconf.ToLower().Trim().Equals("confirme a senha") || senhaconf.ToLower().Trim().Equals("senha") || senhaconf.Trim().Equals(""))
            {
                textBoxSenhaconf.Text = "Confirme a senha";
                textBoxSenhaconf.UseSystemPasswordChar = false;
                textBoxSenhaconf.ForeColor = Color.Gray;
            }
        }

        private void labelclose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelclose_MouseEnter(object sender, EventArgs e)
        {
            labelclose.ForeColor = Color.Red;
        }

        private void labelclose_MouseLeave(object sender, EventArgs e)
        {
            labelclose.ForeColor = Color.Black;
        }
        //Adiciona novo usuario
        private void buttonentrar_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`nome`, `sobrenome`, `email`, `username`, `password`) VALUES (@nome, @sbnm, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = textBoxNome.Text;
            command.Parameters.Add("@sbnm", MySqlDbType.VarChar).Value = textBoxSobrenome.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxSenha.Text;

            db.openConnection();

            
            //Verifica se tudo foi preenchido
            if (!checkTextBoxesValues())
            {
                //Verifica se as senha combinam
                if (textBoxSenha.Text.Equals(textBoxSenhaconf.Text))
                {
                    //Verifica se o usuário exite
                    if (checkUsername())
                    {
                        MessageBox.Show("ESSE USUÁRIO JÁ EXISTE.");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("CONTA CRIADA!","CONTA REGISTRADA");
                        }
                        else
                        {
                            MessageBox.Show("ERRO","TENTE NOVAMENTE MAIS TARDE");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("AS SENHAS NÃO COINCIDEM", "AS SENHAS NÃO SÃO IGUAIS");
                }
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS");
            }
            
            

            db.closeConnection();
        }
        //Verifica se o Username já existe.
        public Boolean checkUsername()
        {
            DB db = new DB();
            
            String username = textBoxUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      // Verifica se tudo foi preenchido.
        public Boolean checkTextBoxesValues ()
        {
            String nome = textBoxNome.Text;
            String sobrenome = textBoxSobrenome.Text;
            String email = textBoxEmail.Text;
            String username = textBoxUsername.Text;
            String senha = textBoxSenha.Text;
            String senhaconf = textBoxSenhaconf.Text;

            if (nome.Equals("Nome") || sobrenome.Equals("Sobrenome") || email.Equals("Email") || username.Equals("Usuário") || senha.Equals("Senha") || senhaconf.Equals("Confirme a senha"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGoSingOn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void labelGoLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoLogin.ForeColor = Color.DarkBlue;
        }

        private void labelGoLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoLogin.ForeColor = Color.DarkBlue;
        }
    }
}

