namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.dgv_xml = new System.Windows.Forms.DataGridView();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xml)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_xml
            // 
            this.dgv_xml.AllowUserToOrderColumns = true;
            this.dgv_xml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xml.Location = new System.Drawing.Point(32, 128);
            this.dgv_xml.Name = "dgv_xml";
            this.dgv_xml.RowTemplate.Height = 24;
            this.dgv_xml.Size = new System.Drawing.Size(468, 217);
            this.dgv_xml.TabIndex = 1;
            this.dgv_xml.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_xml_CellContentClick);
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmb_gender.Location = new System.Drawing.Point(205, 47);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(121, 24);
            this.cmb_gender.TabIndex = 2;
            this.cmb_gender.SelectedIndexChanged += new System.EventHandler(this.cmb_gender_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 447);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.dgv_xml);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xml)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_xml;
        private System.Windows.Forms.ComboBox cmb_gender;
    }
}