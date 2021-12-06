namespace e_commerce_project
{
    partial class Admin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewBrand = new System.Windows.Forms.Button();
            this.NewItem = new System.Windows.Forms.Button();
            this.UpdateBrand = new System.Windows.Forms.Button();
            this.UpdateItem = new System.Windows.Forms.Button();
            this.DIsplayItem = new System.Windows.Forms.Button();
            this.DisplayBrand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update Brand Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update Item Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Display items sorted by(price,colour,brand)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Display Brand Items sorted";
            // 
            // NewBrand
            // 
            this.NewBrand.AccessibleName = "";
            this.NewBrand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewBrand.Location = new System.Drawing.Point(73, 78);
            this.NewBrand.Name = "NewBrand";
            this.NewBrand.Size = new System.Drawing.Size(93, 34);
            this.NewBrand.TabIndex = 6;
            this.NewBrand.Text = "NewBrand";
            this.NewBrand.UseVisualStyleBackColor = true;
            this.NewBrand.Click += new System.EventHandler(this.NewBrand_Click);
            // 
            // NewItem
            // 
            this.NewItem.Location = new System.Drawing.Point(463, 78);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(93, 34);
            this.NewItem.TabIndex = 7;
            this.NewItem.Text = "NewItem";
            this.NewItem.UseVisualStyleBackColor = true;
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // UpdateBrand
            // 
            this.UpdateBrand.Location = new System.Drawing.Point(73, 188);
            this.UpdateBrand.Name = "UpdateBrand";
            this.UpdateBrand.Size = new System.Drawing.Size(103, 31);
            this.UpdateBrand.TabIndex = 8;
            this.UpdateBrand.Text = "UpdateBrand";
            this.UpdateBrand.UseVisualStyleBackColor = true;
            this.UpdateBrand.Click += new System.EventHandler(this.UpdateBrand_Click);
            // 
            // UpdateItem
            // 
            this.UpdateItem.Location = new System.Drawing.Point(476, 190);
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Size = new System.Drawing.Size(103, 29);
            this.UpdateItem.TabIndex = 9;
            this.UpdateItem.Text = "UpdateItem";
            this.UpdateItem.UseVisualStyleBackColor = true;
            this.UpdateItem.Click += new System.EventHandler(this.UpdateItem_Click);
            // 
            // DIsplayItem
            // 
            this.DIsplayItem.Location = new System.Drawing.Point(476, 345);
            this.DIsplayItem.Name = "DIsplayItem";
            this.DIsplayItem.Size = new System.Drawing.Size(103, 32);
            this.DIsplayItem.TabIndex = 10;
            this.DIsplayItem.Text = "DisplayItem";
            this.DIsplayItem.UseVisualStyleBackColor = true;
            this.DIsplayItem.Click += new System.EventHandler(this.DIsplayItem_Click);
            // 
            // DisplayBrand
            // 
            this.DisplayBrand.Location = new System.Drawing.Point(73, 345);
            this.DisplayBrand.Name = "DisplayBrand";
            this.DisplayBrand.Size = new System.Drawing.Size(103, 32);
            this.DisplayBrand.TabIndex = 11;
            this.DisplayBrand.Text = "DisplayBrand";
            this.DisplayBrand.UseVisualStyleBackColor = true;
            this.DisplayBrand.Click += new System.EventHandler(this.DisplayBrand_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(719, 455);
            this.Controls.Add(this.DisplayBrand);
            this.Controls.Add(this.DIsplayItem);
            this.Controls.Add(this.UpdateItem);
            this.Controls.Add(this.UpdateBrand);
            this.Controls.Add(this.NewItem);
            this.Controls.Add(this.NewBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin Functionalities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button NewBrand;
        private System.Windows.Forms.Button NewItem;
        private System.Windows.Forms.Button UpdateBrand;
        private System.Windows.Forms.Button UpdateItem;
        private System.Windows.Forms.Button DIsplayItem;
        private System.Windows.Forms.Button DisplayBrand;
    }
}