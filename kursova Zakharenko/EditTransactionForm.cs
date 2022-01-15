using kursova_Zakharenko.Controller;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kursova_Zakharenko
{
    public partial class EditTransactionForm : Form
    {
        Transaction transaction;
        TransactionQuery controller;
        User user;
        public EditTransactionForm(Transaction tr, User USER)
        {
            InitializeComponent();
            controller = new TransactionQuery(ConnectionString.ConnStr);
            transaction = tr;
            user = USER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Regex rgx = new Regex(@"^\d{2}.\d{2}.\d{4}$");
            if (comboBox1.SelectedItem=="Category")
            {
                label2.Text = "Enter new category:";
                controller.EditCat(transaction.getID(),textBox1.Text);
                flag = true;
            }
            else if (comboBox1.SelectedItem == "Date")
            {
                label2.Text = "Enter new date (XX.YY.ZZZZ):";
                if (rgx.IsMatch(textBox1.Text))
                {
                    try
                    {
                        controller.EditDate(transaction.getID(), textBox1.Text);
                        flag = true;
                    }
                    catch 
                    {
                        MessageBox.Show("Check inserted date!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Check inserted date!","Error");
                }
            }
            else if (comboBox1.SelectedItem == "Value")
            {
                try
                {
                    controller.EditValue(transaction.getID(), double.Parse(textBox1.Text));
                    flag = true;
                }
                catch 
                {
                    MessageBox.Show("Check inserted value!", "Error");
                }
            }
            if (flag)
            {
                MainUserForm userForm = new MainUserForm(user);
                userForm.Show();
                this.Close();
            }
        }

        private void EditTransactionForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Category");
            comboBox1.Items.Add("Date");
            comboBox1.Items.Add("Value");
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Category")
            {
                label2.Text = "Enter new category:";
            }
            else if (comboBox1.SelectedItem == "Date")
            {
                label2.Text = "Enter new date (XX.YY.ZZZZ)";

            }
            else if (comboBox1.SelectedItem == "Value")
            {
                label2.Text = "Enter new value:";
            }

        }
    }
}
