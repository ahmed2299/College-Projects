namespace tgarebc_GUI
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_count = new System.Windows.Forms.Button();
            this.tb_delete = new System.Windows.Forms.Button();
            this.cb_male = new System.Windows.Forms.CheckBox();
            this.cb_female = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clb_projects = new System.Windows.Forms.CheckedListBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(258, 39);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(258, 85);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(59, 347);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(195, 345);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(100, 34);
            this.btn_count.TabIndex = 7;
            this.btn_count.Text = "count_fem";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(59, 391);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(105, 32);
            this.tb_delete.TabIndex = 8;
            this.tb_delete.Text = "delete file";
            this.tb_delete.UseVisualStyleBackColor = true;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // cb_male
            // 
            this.cb_male.AutoSize = true;
            this.cb_male.Location = new System.Drawing.Point(172, 135);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(60, 21);
            this.cb_male.TabIndex = 9;
            this.cb_male.Text = "male";
            this.cb_male.UseVisualStyleBackColor = true;
            // 
            // cb_female
            // 
            this.cb_female.AutoSize = true;
            this.cb_female.Location = new System.Drawing.Point(313, 134);
            this.cb_female.Name = "cb_female";
            this.cb_female.Size = new System.Drawing.Size(72, 21);
            this.cb_female.TabIndex = 10;
            this.cb_female.Text = "female";
            this.cb_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Department";
            // 
            // combobox_department
            // 
            this.combobox_department.FormattingEnabled = true;
            this.combobox_department.Items.AddRange(new object[] {
            "is",
            "cs ",
            "it"});
            this.combobox_department.Location = new System.Drawing.Point(226, 187);
            this.combobox_department.Name = "combobox_department";
            this.combobox_department.Size = new System.Drawing.Size(121, 24);
            this.combobox_department.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "projects";
            // 
            // clb_projects
            // 
            this.clb_projects.FormattingEnabled = true;
            this.clb_projects.Items.AddRange(new object[] {
            "project1",
            "project2",
            "project3",
            "project4"});
            this.clb_projects.Location = new System.Drawing.Point(226, 229);
            this.clb_projects.Name = "clb_projects";
            this.clb_projects.Size = new System.Drawing.Size(139, 89);
            this.clb_projects.TabIndex = 14;
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(372, 391);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(136, 34);
            this.btn_name.TabIndex = 15;
            this.btn_name.Text = "search employee";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 523);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.clb_projects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobox_department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_female);
            this.Controls.Add(this.cb_male);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button tb_delete;
        private System.Windows.Forms.CheckBox cb_male;
        private System.Windows.Forms.CheckBox cb_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox_department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clb_projects;
        private System.Windows.Forms.Button btn_name;
    }
}

