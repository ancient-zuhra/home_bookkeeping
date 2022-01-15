namespace kursova_Zakharenko
{
    partial class AddTransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmbbx_categories = new System.Windows.Forms.ComboBox();
            this.lbl_newCategory = new System.Windows.Forms.Label();
            this.txtbx_newCategory = new System.Windows.Forms.TextBox();
            this.txtbx_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add transaction here";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.ForestGreen;
            this.radioButton1.Location = new System.Drawing.Point(39, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 33);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "income";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton2.Location = new System.Drawing.Point(257, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 33);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "expense";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(36, 125);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(116, 29);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Category:";
            this.lbl_category.Visible = false;
            // 
            // cmbbx_categories
            // 
            this.cmbbx_categories.FormattingEnabled = true;
            this.cmbbx_categories.Location = new System.Drawing.Point(232, 125);
            this.cmbbx_categories.Name = "cmbbx_categories";
            this.cmbbx_categories.Size = new System.Drawing.Size(175, 37);
            this.cmbbx_categories.TabIndex = 4;
            this.cmbbx_categories.Visible = false;
            this.cmbbx_categories.SelectedIndexChanged += new System.EventHandler(this.cmbbx_categories_SelectedIndexChanged);
            // 
            // lbl_newCategory
            // 
            this.lbl_newCategory.AutoSize = true;
            this.lbl_newCategory.Location = new System.Drawing.Point(36, 185);
            this.lbl_newCategory.Name = "lbl_newCategory";
            this.lbl_newCategory.Size = new System.Drawing.Size(180, 29);
            this.lbl_newCategory.TabIndex = 5;
            this.lbl_newCategory.Text = "Enter category: ";
            this.lbl_newCategory.Visible = false;
            // 
            // txtbx_newCategory
            // 
            this.txtbx_newCategory.Location = new System.Drawing.Point(232, 185);
            this.txtbx_newCategory.Name = "txtbx_newCategory";
            this.txtbx_newCategory.Size = new System.Drawing.Size(175, 34);
            this.txtbx_newCategory.TabIndex = 6;
            this.txtbx_newCategory.Visible = false;
            // 
            // txtbx_value
            // 
            this.txtbx_value.Location = new System.Drawing.Point(232, 245);
            this.txtbx_value.Name = "txtbx_value";
            this.txtbx_value.Size = new System.Drawing.Size(175, 34);
            this.txtbx_value.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value:";
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(147, 335);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(161, 65);
            this.bttn_Add.TabIndex = 9;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_value);
            this.Controls.Add(this.txtbx_newCategory);
            this.Controls.Add(this.lbl_newCategory);
            this.Controls.Add(this.cmbbx_categories);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransactionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTransactionForm_FormClosing);
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmbbx_categories;
        private System.Windows.Forms.Label lbl_newCategory;
        private System.Windows.Forms.TextBox txtbx_newCategory;
        private System.Windows.Forms.TextBox txtbx_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_Add;
    }
}