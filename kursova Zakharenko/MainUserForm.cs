using kursova_Zakharenko.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace kursova_Zakharenko
{
    public partial class MainUserForm : Form
    {
        User user;
        TransactionQuery controller;
        UserQuery userController;
        public MainUserForm(User USER)
        {
            InitializeComponent();
            controller = new TransactionQuery(ConnectionString.ConnStr);
            userController = new UserQuery(ConnectionString.ConnStr);
            user = USER;
        }
        void styleOfData()
        { 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())<0)
                {
                    System.Drawing.Color redColor = Color.Red;
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = redColor;
                }
                else
                {
                    System.Drawing.Color greenColor = Color.Green;
                    dataGridView1.Rows[i].Cells[2].Value = "+" + dataGridView1.Rows[i].Cells[2].Value.ToString();
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = greenColor;
                }
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.Columns["TransactionID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[2].HeaderText = "Value";
            dataGridView1.Columns[3].HeaderText = "Date";
        }
        private void MainUserForm_Load(object sender, EventArgs e)
        {
            hi_lbl.Text = "Hi, "+user.getName()+"!";
            user.setBalance(controller.calculateBalance(user.getID()));
            userController.updateBalance(user.getLogin(), user.getBalance());
            lbl_balance.Text = user.getBalance().ToString()+" uah.";
            updateTable();
        }

        private void MainUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bttn_add_transaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm form = new AddTransactionForm(user, this);
            form.Show();
            this.Hide();
        }
        void updateTable()
        {
            hi_lbl.Text = "Hi, " + user.getName() + "!";
            user.setBalance(controller.calculateBalance(user.getID()));
            userController.updateBalance(user.getLogin(), user.getBalance());
            lbl_balance.Text = user.getBalance().ToString() + " uah.";
            dataGridView1.DataSource = controller.UpdateTable(user.getID());
            styleOfData();
        }
        private void MainUserForm_Shown(object sender, EventArgs e)
        {
            updateTable();
        }

        private void bttn_stat_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm(user, this);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["TransactionID"].Value.ToString()));
            }
            updateTable();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_bttn_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr = controller.getTransactionById(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["TransactionID"].Value.ToString()));
            EditTransactionForm editTransactionForm = new EditTransactionForm(tr, user);
            editTransactionForm.Show();
        }

        private void MainUserForm_Activated(object sender, EventArgs e)
        {
            updateTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
