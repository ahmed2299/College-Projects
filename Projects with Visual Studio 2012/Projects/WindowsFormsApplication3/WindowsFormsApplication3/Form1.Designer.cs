namespace WindowsFormsApplication3
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.lb_checked = new System.Windows.Forms.CheckedListBox();
            this.projects = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "gender";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(270, 53);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(270, 103);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 4;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(138, 171);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(59, 21);
            this.rb_male.TabIndex = 5;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.rb_male_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(289, 171);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(71, 21);
            this.rb_female.TabIndex = 6;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "department";
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "cs",
            "is",
            "it"});
            this.cb_department.Location = new System.Drawing.Point(220, 238);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(121, 24);
            this.cb_department.TabIndex = 8;
            // 
            // lb_checked
            // 
            this.lb_checked.FormattingEnabled = true;
            this.lb_checked.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.lb_checked.Location = new System.Drawing.Point(220, 280);
            this.lb_checked.Name = "lb_checked";
            this.lb_checked.Size = new System.Drawing.Size(120, 89);
            this.lb_checked.TabIndex = 9;
            // 
            // projects
            // 
            this.projects.AutoSize = true;
            this.projects.Location = new System.Drawing.Point(64, 324);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(58, 17);
            this.projects.TabIndex = 10;
            this.projects.Text = "projects";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(95, 382);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 36);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "add emp";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(95, 435);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 36);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "clear file";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(288, 411);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 46);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "search employees";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 494);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.lb_checked);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.CheckedListBox lb_checked;
        private System.Windows.Forms.Label projects;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
    }
}

