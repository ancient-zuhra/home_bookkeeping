namespace kursova_Zakharenko
{
    partial class MainUserForm
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
            this.hi_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_add_transaction = new System.Windows.Forms.Button();
            this.bttn_stat = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.edit_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hi_lbl
            // 
            this.hi_lbl.AutoSize = true;
            this.hi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hi_lbl.Location = new System.Drawing.Point(60, 33);
            this.hi_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hi_lbl.Name = "hi_lbl";
            this.hi_lbl.Size = new System.Drawing.Size(45, 26);
            this.hi_lbl.TabIndex = 0;
            this.hi_lbl.Text = "Hi, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your balance:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(221, 122);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(55, 24);
            this.lbl_balance.TabIndex = 2;
            this.lbl_balance.Text = "         ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 429);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Here are your last transactions:";
            // 
            // bttn_add_transaction
            // 
            this.bttn_add_transaction.Location = new System.Drawing.Point(66, 176);
            this.bttn_add_transaction.Name = "bttn_add_transaction";
            this.bttn_add_transaction.Size = new System.Drawing.Size(213, 71);
            this.bttn_add_transaction.TabIndex = 4;
            this.bttn_add_transaction.Text = "Add Transaction";
            this.bttn_add_transaction.UseVisualStyleBackColor = true;
            this.bttn_add_transaction.Click += new System.EventHandler(this.bttn_add_transaction_Click);
            // 
            // bttn_stat
            // 
            this.bttn_stat.Location = new System.Drawing.Point(66, 267);
            this.bttn_stat.Name = "bttn_stat";
            this.bttn_stat.Size = new System.Drawing.Size(213, 79);
            this.bttn_stat.TabIndex = 5;
            this.bttn_stat.Text = "Statistics";
            this.bttn_stat.UseVisualStyleBackColor = true;
            this.bttn_stat.Click += new System.EventHandler(this.bttn_stat_Click);
            // 
            // delete_bttn
            // 
            this.delete_bttn.Location = new System.Drawing.Point(66, 363);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(98, 38);
            this.delete_bttn.TabIndex = 7;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = true;
            this.delete_bttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_bttn
            // 
            this.edit_bttn.Location = new System.Drawing.Point(182, 363);
            this.edit_bttn.Name = "edit_bttn";
            this.edit_bttn.Size = new System.Drawing.Size(97, 38);
            this.edit_bttn.TabIndex = 8;
            this.edit_bttn.Text = "Edit";
            this.edit_bttn.UseVisualStyleBackColor = true;
            this.edit_bttn.Click += new System.EventHandler(this.edit_bttn_Click);
            // 
            // exit_bttn
            // 
            this.exit_bttn.Location = new System.Drawing.Point(66, 448);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(213, 66);
            this.exit_bttn.TabIndex = 9;
            this.exit_bttn.Text = "Exit";
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 551);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.edit_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_stat);
            this.Controls.Add(this.bttn_add_transaction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hi_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUserForm";
            this.Activated += new System.EventHandler(this.MainUserForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUserForm_FormClosing);
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.Shown += new System.EventHandler(this.MainUserForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hi_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_add_transaction;
        private System.Windows.Forms.Button bttn_stat;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button edit_bttn;
        private System.Windows.Forms.Button exit_bttn;
    }
}