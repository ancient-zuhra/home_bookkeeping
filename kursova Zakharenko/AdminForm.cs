using kursova_Zakharenko.Controller;
using System;
using System.Windows.Forms;
namespace kursova_Zakharenko
{
    public partial class AdminForm : Form
    {
        UserQuery controller;
        public AdminForm()
        {
            InitializeComponent();
            controller = new UserQuery(ConnectionString.ConnStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["UserID"].Value.ToString()) != 1)
            { 
                DialogResult dres = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
                if (dres == DialogResult.Yes)
                {
                    controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["UserID"].Value.ToString()));
                }
                controller.UpdateTable();
            }
            else
            {
                MessageBox.Show("You can't delete administrator!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
