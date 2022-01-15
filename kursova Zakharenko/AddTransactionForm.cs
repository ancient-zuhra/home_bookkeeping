using kursova_Zakharenko.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kursova_Zakharenko
{
    public partial class AddTransactionForm : Form
    {
        string category;
        double value;
        Transaction transaction;
        TransactionQuery controller;
        User user;
        MainUserForm mainUserForm;
        public AddTransactionForm(User USER, MainUserForm mf)
        {
            InitializeComponent();
            controller = new TransactionQuery(ConnectionString.ConnStr);
            user = USER;
            mainUserForm = mf;
        }
        void showElems()
        {
            if (radioButton1.Checked)
            {
                lbl_category.Visible = false;
                lbl_newCategory.Visible = false;
                cmbbx_categories.Visible = false;
                txtbx_newCategory.Visible = false;
                label2.Location = new System.Drawing.Point(36, 125);
                txtbx_value.Location = new System.Drawing.Point(232, 125);
                bttn_Add.Location = new System.Drawing.Point(147, 185);
                Size = new Size(500, 310);
            }
            else
            {
                lbl_category.Visible = true;
                cmbbx_categories.Visible = true;
                
                if (cmbbx_categories.SelectedItem=="Other")
                {
                    lbl_newCategory.Visible = true;
                    txtbx_newCategory.Visible = true;
                    label2.Location = new System.Drawing.Point(36, 245);
                    txtbx_value.Location = new System.Drawing.Point(232, 245);
                    bttn_Add.Location = new System.Drawing.Point(147, 335);
                    Size = new Size(500, 500);
                }
                else
                {
                    lbl_newCategory.Visible = false;
                    txtbx_newCategory.Visible = false;
                    label2.Location = new System.Drawing.Point(36, 185);
                    txtbx_value.Location = new System.Drawing.Point(232, 185);
                    bttn_Add.Location = new System.Drawing.Point(147, 246);
                    Size = new Size(500, 380);
                }
                
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            showElems();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            showElems();
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {   
            showElems();
            transaction = new Transaction();
            cmbbx_categories.Items.AddRange(transaction.getCategories());
            cmbbx_categories.SelectedItem = "Food";
        }

        private void cmbbx_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            showElems();
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            {
            if (int.Parse(txtbx_value.Text)!=0)
            {
                try { 
                    if (cmbbx_categories.SelectedItem == "Other")
                    {
                        category = txtbx_newCategory.Text;
                    }
                    else
                    {
                        category = cmbbx_categories.Text;
                    }
                    if (radioButton2.Checked)
                    {
                        value = (-1) * double.Parse(txtbx_value.Text);
                        controller.Add(category, value, user.getID());
                        mainUserForm.Show();
                        this.Close();
                    }
                    else
                    {
                        value = int.Parse(txtbx_value.Text);
                        category = "Income";
                        if (double.Parse(txtbx_value.Text) < 0)
                        {
                            MessageBox.Show("Income cannot be less than 0!");
                        }
                        else
                        {
                            controller.Add(category, value, user.getID());
                            mainUserForm.Show();
                            this.Close();
                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Check entered values!");
                }
            }
            else
            {
                MessageBox.Show("Transaction value can'not be 0!");
            }
            }
            catch 
            {
                MessageBox.Show("Invalid data!");
            }
        }

        private void AddTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           mainUserForm.Show();
        }
    }
}
