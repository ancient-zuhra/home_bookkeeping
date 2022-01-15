using kursova_Zakharenko.Controller;
using System;
using System.Windows.Forms;
namespace kursova_Zakharenko
{
    public partial class ForgotPasswordForm : Form
    {
        User user;
        UserQuery controller;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            controller = new UserQuery(ConnectionString.ConnStr);
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text==user.getAnswer())
            {
                MessageBox.Show("Your password is: "+user.getPassword());
            }
            else
            {
                MessageBox.Show("Incorrect answer!");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            user = controller.getUser(textBox2.Text);
            label2.Text = user.getQuestion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
