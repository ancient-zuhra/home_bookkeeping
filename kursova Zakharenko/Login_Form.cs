using kursova_Zakharenko.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kursova_Zakharenko
{
    public partial class Login_Form : Form
    {
        UserQuery controller;
        User user;
        public Login_Form()
        {
            InitializeComponent();
            controller = new UserQuery(ConnectionString.ConnStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public User takeUser()
        {
            return user;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int flag;
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flag % 2 == 0)
            {
                pictureBox1.Image = Image.FromFile("crossed_eye_active.jpg");
                pass_txtbx.PasswordChar = '\0';
            }
            else
            {
                pictureBox1.Image = Image.FromFile("eye_active.jpg");
                pass_txtbx.PasswordChar = '•';

            }
            flag++;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            flag = 0;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            user = new User();
            user = controller.getUser(login_txtbx.Text);
            if (controller.checkSameLogin(login_txtbx.Text))
            {
                if (user.getLogin() == "admin" && user.getPassword() == pass_txtbx.Text)
                {
                    AdminForm adm_form = new AdminForm();
                    adm_form.Show();
                    this.Hide();
                }
                else
                {
                    string login = user.getLogin();
                    string password = user.getPassword();
                    if (pass_txtbx.Text == password)
                    {
                        MainUserForm user_form = new MainUserForm(user);
                        user_form.Show();
                        this.Hide();
                    }
                    else
                    {
                        pass_inc.Text = "Incorrect password!";
                    }
                }
            }
            else
            {
                log_inc.Text = "Incorrect login!";
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.Show();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registration_ = new RegistrationForm();
            registration_.Show();
        }
    }
}
